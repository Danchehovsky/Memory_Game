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
    public partial class FormPairsDif3 : Form
    {
        String currentUser;
        String idUser;
        int Win = 6;
        int Time = 40;
        int Points=0;
        int Oldpoints;
        Memory mem3 = new Memory();
        List<string> pictures = new List<string>()
        {
            "1","2","3","4","5","6","1","2","3","4","5","6"
        };
        public FormPairsDif3()
        {
            InitializeComponent();
            mem3.AssignPictures(timerCountdown, pictures, panelCardsHolder);
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        public void carryPoints(int Points3)
        {
            Oldpoints=Points3;
            this.labelPoints.Text = Convert.ToString(Points3);
        }
        private void GivePictures(PictureBox Box)
        {
            mem3.GivePictures(Box, timerFlip, timerCountdown, labelWin, labelPoints, label1, buttonAgain, buttonNext, Win, Points, currentUser, idUser);
        }
        private void timerFlip_Tick(object sender, EventArgs e)
        {
            mem3.timerFlip_Tick(timerFlip);
        }
        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            mem3.timerCountdown_Tick(label1, labelLose, timerCountdown, buttonAgain, panelCardsHolder);
        }

        private void buttonAgain_Click(object sender, EventArgs e)
        {
            mem3.buttonAgain_Click(labelWin, labelLose, label1, labelPoints, buttonAgain, buttonNext, timerCountdown, panelCardsHolder, Time, Oldpoints);
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.SetUser(currentUser, idUser);
            form1.Show();
            form1.DesktopLocation = this.DesktopLocation;
            this.Hide();
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
        private void FormPairsDif3_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormPairsDif3_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion

        private void buttonAgain_MouseEnter(object sender, EventArgs e)
        {
            buttonAgain.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonAgain_MouseLeave(object sender, EventArgs e)
        {
            buttonAgain.BackgroundImage = Properties.Resources.button;
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

        private void buttonNext_MouseDown(object sender, MouseEventArgs e)
        {
            buttonNext.BackgroundImage = Properties.Resources.buttonpress;
        }

    }
}
