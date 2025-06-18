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
    public partial class FormSimon : Form
    {
        String currentUser;
        String idUser;
        Random rnd = new Random();
        int randomnumber;
        int start = 0;
        int streak = 1;
        int correct = 0;
        int oldStreak = 0;
        int points = 0;
        List<int> order = new List<int>();
        public FormSimon()
        {
            InitializeComponent();
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerWait.Start();
            buttonStart.Visible = false;
            points = 0;
            labelPoints.Text = Convert.ToString(points);
        }
        private void Startgame()
        {
            if (start == streak)
            {
                foreach (PictureBox picture in panelBack.Controls)
                    picture.Enabled = true;
            }
            else if (start < streak && start<oldStreak)
            {
                if (order[start] == 0)
                    pictureBox1.Image = Properties.Resources.circlegreendark;
                else if (order[start] == 1)
                    pictureBox2.Image = Properties.Resources.circlereddark;
                else if (order[start] == 2)
                    pictureBox3.Image = Properties.Resources.circleyellowdark;
                else if (order[start] == 3)
                    pictureBox4.Image = Properties.Resources.circlebluedark;
                start++;
                oldStreak++;
                timerStart.Start();
            }
            else if(start < streak && start>=oldStreak)
            {
                randomnumber = rnd.Next(0, panelBack.Controls.Count);
                order.Add(randomnumber);
                if (order[start] == 0)
                    pictureBox1.Image = Properties.Resources.circlegreendark;
                else if (order[start] == 1)
                    pictureBox2.Image = Properties.Resources.circlereddark;
                else if (order[start] == 2)
                    pictureBox3.Image = Properties.Resources.circleyellowdark;
                else if (order[start] == 3)
                    pictureBox4.Image = Properties.Resources.circlebluedark;
                start++;
                timerStart.Start();
            }
        }
        private void Check(PictureBox picture1)
        {
            if (correct < streak)
            {
                if (Convert.ToInt32(picture1.Tag) == order[correct])
                {
                    correct++;
                    points += 50;
                    labelPoints.Text = Convert.ToString(points);
                }
                else
                {
                    foreach (PictureBox picture in panelBack.Controls)
                        picture.Enabled = false;
                    buttonStart.Visible = true;
                    start = 0;
                    streak = 1;
                    correct = 0;
                    oldStreak = 0;
                    order.Clear();
                    labelWin.Text = "Неправильно";
                    labelWin.ForeColor = Color.Red;
                    timerStart.Interval = 700;
                    timerWait.Interval = 700;
                    SavePoints();
                }
                if (correct == streak)
                {
                    foreach (PictureBox picture in panelBack.Controls)
                        picture.Enabled = false;
                    label1.Text =Convert.ToString(streak);
                    labelWin.Text = "Правильно";
                    labelWin.ForeColor = Color.Green;
                    points += 50;
                    labelPoints.Text = Convert.ToString(points);
                    start = 0;
                    streak++;
                    correct = 0;
                    if (streak % 5 == 0 && timerStart.Interval != 200)
                        timerStart.Interval -= 100;
                    if (streak % 5 == 0 && timerWait.Interval != 100)
                        timerWait.Interval -= 100;
                    timerWait.Start();
                }
            }
        }
        private void SavePoints()
        {
            if (currentUser != null && idUser != null)
            {
                int PointsOld = 0;
                int PointsNew = points;
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
                command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = idUser;
                command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "simon";
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
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "simon";
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
                    command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "simon";
                    db.openConnection();
                    if (command.ExecuteNonQuery() != 1)
                    {
                        return;
                    }
                    db.closeConnection();
                }
            }
        }
        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            foreach (PictureBox picture in panelBack.Controls)
            {
                if (Convert.ToString(picture.Tag) == "0")
                    picture.Image = Properties.Resources.circlegreen;
                else if (Convert.ToString(picture.Tag) == "1")
                    picture.Image = Properties.Resources.circlered;
                else if (Convert.ToString(picture.Tag) == "2")
                    picture.Image = Properties.Resources.circleyellow;
                else if (Convert.ToString(picture.Tag) == "3")
                    picture.Image = Properties.Resources.circleblue;
            }
            timerWait.Start();
        }

        private void timerWait_Tick(object sender, EventArgs e)
        {
            timerWait.Stop();
            Startgame();
        }

        #region picBoxes
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Check(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Check(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Check(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Check(pictureBox4);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.circlegreendark;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.circlegreen;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.circlereddark;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.circlered;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.circleyellowdark;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.circleyellow;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.circlebluedark;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.circleblue;
        }
        #endregion
        #region buttons
        private void buttonStart_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.buttonpress;
        }

        private void buttonStart_MouseEnter(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonStart_MouseLeave(object sender, EventArgs e)
        {
            buttonStart.BackgroundImage = Properties.Resources.button;
        }
        #endregion
        #region moveForm
        MoveForm move = new MoveForm();
        private void FormSimon_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormSimon_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
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
            form1.DesktopLocation = this.DesktopLocation;
            form1.SetUser(currentUser, idUser);
            form1.Show();
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

        private void pictureBoxLeader_Click(object sender, EventArgs e)
        {
            FormLeader leader = new FormLeader();
            leader.DesktopLocation = this.DesktopLocation;
            leader.SetUser(currentUser, idUser);
            leader.Show();
            this.Hide();
        }
    }
}
