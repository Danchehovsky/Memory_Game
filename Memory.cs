using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOM
{
    class Memory
    {
        String currentUser;
        String idUser;
        Random rnd = new Random();
        List<string> pictemp = new List<string>();
        List<string> pictures = new List<string>();
        PictureBox flippedImage1;
        PictureBox flippedImage2;
        int Correct;
        public void AssignPictures(Timer timerCountdown, List<string> picturesnew, Panel panelCardsHolder)
        {
            pictures = picturesnew;
            timerCountdown.Start();
            int randomnumber;
            for (int i = 0; i < pictures.Count; i++)
            {
                pictemp.Add(pictures[i]);
            }
            foreach (PictureBox picture in panelCardsHolder.Controls)
            {
                randomnumber = rnd.Next(0, pictemp.Count);
                picture.Tag = pictemp[randomnumber];
                picture.Image = Properties.Resources.qmark;
                pictemp.RemoveAt(randomnumber);
            }
        }
        public void GivePictures(PictureBox Box, Timer timerFlip, Timer timerCountdown, Label labelWin, Label labelPoints, Label label1, Button buttonAgain, Button buttonNext, int Win, int Points, String User, String ID)
        {
            if (timerFlip.Enabled == false)
            {
                currentUser = User;
                idUser = ID;
                Points = Convert.ToInt32(labelPoints.Text);
                if (Convert.ToString(Box.Tag) == "1")
                    Box.Image = Properties.Resources.circle;
                else if (Convert.ToString(Box.Tag) == "2")
                    Box.Image = Properties.Resources.heart;
                else if (Convert.ToString(Box.Tag) == "3")
                    Box.Image = Properties.Resources.square;
                else if (Convert.ToString(Box.Tag) == "4")
                    Box.Image = Properties.Resources.star;
                else if (Convert.ToString(Box.Tag) == "5")
                    Box.Image = Properties.Resources.rhombus;
                else if (Convert.ToString(Box.Tag) == "6")
                    Box.Image = Properties.Resources.pentagon;
                if (flippedImage1 == null)
                {
                    flippedImage1 = Box;
                    flippedImage1.Enabled = false;
                }
                else if (flippedImage1 != null && flippedImage2 == null)
                {
                    flippedImage2 = Box;
                    flippedImage2.Enabled = false;
                }
                if (flippedImage1 != null && flippedImage2 != null)
                {
                    if (flippedImage1.Tag == flippedImage2.Tag)
                    {
                        flippedImage1.Enabled = false;
                        flippedImage2.Enabled = false;
                        flippedImage1 = null;
                        flippedImage2 = null;
                        Points += 50;
                        Correct++;
                        if (Correct == Win)
                        {
                            labelWin.Visible = true;
                            buttonAgain.Visible = true;
                            buttonNext.Visible = true;
                            Points +=(Convert.ToInt32(label1.Text)*10);
                            timerCountdown.Stop();
                            SavePoints(currentUser, idUser, Points);
                        }
                        labelPoints.Text = Convert.ToString(Points);
                    }
                    else
                    {
                        timerFlip.Start();
                    }

                }
            }
        }
        public void SavePoints(String currentUser, String idUser, int Points)
        {
            if (currentUser != null && idUser != null)
            {
                int PointsOld = 0;
                int PointsNew = Points;
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
                command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = idUser;
                command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "memory";
                db.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PointsOld = Convert.ToInt32(reader[0].ToString());
                }
                db.closeConnection();
                if (PointsNew > PointsOld && PointsOld==0)
                {
                    command = new MySqlCommand("INSERT INTO `scores`(`iduser`, `nickname`, `score`, `game`) VALUES (@idUser, @name, @score, @game)", db.getConnection());
                    command.Parameters.Add("@idUser", MySqlDbType.Int32).Value = idUser;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = currentUser;
                    command.Parameters.Add("@score", MySqlDbType.Int32).Value = PointsNew;
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "memory";
                    db.openConnection();
                    if (command.ExecuteNonQuery() != 1)
                    {
                        return;
                    }
                    db.closeConnection();
                }
                else if (PointsNew > PointsOld)
                {
                    command = new MySqlCommand("UPDATE `scores` SET `score`= @score WHERE `iduser`= @idUser AND `game` = @game", db.getConnection());
                    command.Parameters.Add("@idUser", MySqlDbType.Int32).Value = idUser;
                    command.Parameters.Add("@score", MySqlDbType.Int32).Value = PointsNew;
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "memory";
                    db.openConnection();
                    if (command.ExecuteNonQuery() != 1)
                    {
                        return;
                    }
                    db.closeConnection();
                }
            }
        }
        public void timerFlip_Tick(Timer timerFlip)
        {
            timerFlip.Stop();
            flippedImage1.Enabled = true;
            flippedImage2.Enabled = true;
            flippedImage1.Image = Properties.Resources.qmark;
            flippedImage2.Image = Properties.Resources.qmark;
            flippedImage1 = null;
            flippedImage2 = null;
        }
        public void timerCountdown_Tick(Label label1, Label labelLose, Timer timerCountdown, Button buttonAgain, Panel panelCardsHolder)
        {
            int time = Convert.ToInt32(label1.Text);
            time -= 1;
            label1.Text = Convert.ToString(time);
            if (time == 0)
            {
                flippedImage1 = null;
                flippedImage2 = null;
                timerCountdown.Stop();
                labelLose.Visible = true;
                buttonAgain.Visible = true;
                foreach (PictureBox pictureBox in panelCardsHolder.Controls)
                {
                    pictureBox.Enabled = false;
                }
            }
        }
        public void buttonAgain_Click(Label labelWin, Label labelLose, Label label1, Label labelPoints, Button buttonAgain, Button buttonNext, Timer timerCountdown, Panel panelCardsHolder, int time, int oldpoints)
        {
            labelWin.Visible = false;
            labelLose.Visible = false;
            buttonAgain.Visible = false;
            buttonNext.Visible = false;
            Correct = 0;
            labelPoints.Text = Convert.ToString(oldpoints);
            label1.Text = Convert.ToString(time);
            AssignPictures(timerCountdown, pictures, panelCardsHolder);
            foreach (PictureBox pictureBox in panelCardsHolder.Controls)
            {
                pictureBox.Enabled = true;
            }
        }
    }
}
