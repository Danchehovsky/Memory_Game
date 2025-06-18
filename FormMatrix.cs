using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIPLOM
{
    public partial class FormMatrix : Form
    {
        String currentUser;
        String idUser;
        Random rnd = new Random();
        int replace = 0;
        int Correct = 0;
        int Require = 2;
        int Points = 0;
        bool Started = false;
        PictureBox currentpic=null;
        List<string> matrix = new List<string>()
        {
            "0","0","0","0","0","0","0","0","0","0","0","0","0","0","1","1"
        };
        List<string> mattemp = new List<string>();
        public FormMatrix()
        {
            InitializeComponent();
            AssignPictures();
            GivePicturesStart();
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        private void AssignPictures()
        {
            int random;
            for (int i = 0; i < matrix.Count; i++)
            {
                mattemp.Add(matrix[i]);
            }
            foreach (PictureBox picture in panelCardsHolder.Controls)
            {
                random = rnd.Next(0, mattemp.Count);
                picture.Tag = mattemp[random];
                mattemp.RemoveAt(random);
            }
        }
        private void GivePicturesStart()
        {
            foreach (PictureBox picture in panelCardsHolder.Controls)
            {
                if (Convert.ToString(picture.Tag) == "0")
                    picture.Image = Properties.Resources.square2;
                else if (Convert.ToString(picture.Tag) == "1")
                    picture.Image = Properties.Resources.square2c;
            }
        }
        private void GivePictures(PictureBox picture)
        {
            if (timerno.Enabled == false)
            { 
            if (Convert.ToString(picture.Tag) == "0")
            {
                if(currentpic==null)
                {
                    currentpic = picture;
                    timerno.Start();
                    picture.Image = Properties.Resources.squareno;
                    Points -= 50;
                }
                else
                {
                    picture.Image = Properties.Resources.square2;
                    currentpic = null;
                }     
            }
            else if (Convert.ToString(picture.Tag) == "1")
            {
                Correct++;
                Points += 10;
                picture.Image = Properties.Resources.squareyes;
                picture.Enabled = false;
                if(Correct==Require)
                    {
                        Points += 0;
                        RaiseDif();
                        Correct = 0;
                    }
            }
                labelPoints.Text = Convert.ToString(Points);
            }
        }
        private void RaiseDif()
        {
            buttonNext.Visible = true;
            if (replace < 6)
            {
                replace++;
                Require++;
            }
            matrix[replace] = "1";
            mattemp.Clear();
            AssignPictures();
            GivePicturesStart();
            foreach (PictureBox picture in panelCardsHolder.Controls)
            {
                picture.Enabled = false;
            }
        }
        private void StartGame()
        {
            
            foreach (PictureBox picture in panelCardsHolder.Controls)
            {
                picture.Enabled = true;
                picture.Image = Properties.Resources.square2;
            }
            buttonNext.Visible = false;
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (Started == false)
            {
                Started = true;
                timerCountdown.Start();
            }
            StartGame();
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            buttonAgain.Visible = false;
            replace = 0;
            Correct = 0;
            Require = 2;
            Points = 0;
            labelPoints.Text = Convert.ToString(Points);
            label1.Text = "60";
            timerCountdown.Stop();
            for (int i = 0; i < 13; i++)
                matrix[i] = "0";
            AssignPictures();
            GivePicturesStart();
        }
        private void SavePoints()
        {
            if (currentUser != null && idUser != null)
            {
                int PointsOld = 0;
                int PointsNew = Points;
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
                command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = idUser;
                command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "matrix";
                db.openConnection();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    PointsOld = Convert.ToInt32(reader[0].ToString());
                }
                db.closeConnection();
                if (PointsNew > PointsOld && PointsOld == 0)
                {
                    command = new MySqlCommand("INSERT INTO `scores`(`iduser`, `nickname`, `score`, `game`) VALUES (@idUser, @name, @score, @game)", db.getConnection());
                    command.Parameters.Add("@idUser", MySqlDbType.Int32).Value = idUser;
                    command.Parameters.Add("@name", MySqlDbType.VarChar).Value = currentUser;
                    command.Parameters.Add("@score", MySqlDbType.Int32).Value = PointsNew;
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "matrix";
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
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "matrix";
                    db.openConnection();
                    if (command.ExecuteNonQuery() != 1)
                    {
                        return;
                    }
                    db.closeConnection();
                }
            }
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label1.Text);
            time -= 1;
            label1.Text = Convert.ToString(time);
            if (time == 0)
            {
                timerCountdown.Stop();
                buttonAgain.Visible = true;
                foreach (PictureBox pictureBox in panelCardsHolder.Controls)
                {
                    pictureBox.Enabled = false;
                }
                SavePoints();
            }
        }
        private void timerno_Tick(object sender, EventArgs e)
        {
            timerno.Stop();
            GivePictures(currentpic);
        }
        #region picBoxes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox9);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox10);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox11);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox14);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox15);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            GivePictures(pictureBox16);
        }
        #endregion
        #region controlmenu
        private void pictureBoxUser_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxUser.Image = Properties.Resources.userhover;
        }

        private void pictureBoxUser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxUser.Image = Properties.Resources.user;
        }

        private void pictureBoxLeader_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLeader.Image = Properties.Resources.leaderboardhover;
        }

        private void pictureBoxLeader_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLeader.Image = Properties.Resources.leaderboard;
        }
        private void pictureBoxLeader_Click(object sender, EventArgs e)
        {
            FormLeader leader = new FormLeader();
            leader.DesktopLocation = this.DesktopLocation;
            leader.SetUser(currentUser, idUser);
            leader.Show();
            this.Hide();
        }
        private void pictureBoxHome_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHome.Image = Properties.Resources.homehover;
        }

        private void pictureBoxHome_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome.Image = Properties.Resources.home;
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.SetUser(currentUser, idUser);
            form1.Show();
            form1.DesktopLocation = this.DesktopLocation;
            this.Hide();
        }
        private void pictureBoxX_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxX.Image = Properties.Resources.Xhover;
        }

        private void pictureBoxX_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxX.Image = Properties.Resources.X;
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile();
            profile.DesktopLocation = this.DesktopLocation;
            profile.SetUser(currentUser, idUser);
            profile.Show();
            this.Hide();
        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region moveForm
        MoveForm move = new MoveForm();
        private void FormMatrix_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormMatrix_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion
        #region buttons
        private void buttonNext_MouseDown(object sender, MouseEventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.buttonpress;
        }

        private void buttonNext_MouseEnter(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonNext_MouseLeave(object sender, EventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.button;
        }

        private void buttonAgain_MouseDown(object sender, MouseEventArgs e)
        {
            buttonAgain.BackgroundImage = Properties.Resources.buttonpress;
        }

        private void buttonAgain_MouseEnter(object sender, EventArgs e)
        {
            buttonAgain.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonAgain_MouseLeave(object sender, EventArgs e)
        {
            buttonAgain.BackgroundImage = Properties.Resources.button;
        }
        #endregion

    }
}
