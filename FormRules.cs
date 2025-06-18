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
    public partial class FormRules : Form
    {
        String currentUser;
        String idUser;
        public FormRules()
        {
            InitializeComponent();
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        public void ChoosePanel1()
        {
            panel1.Visible = true;
            label2.Visible = true;
        }
        public void ChoosePanel2()
        {
            panel2.Visible = true;
            label5.Visible = true;
        }
        public void ChoosePanel3()
        {
            panel3.Visible = true;
            label8.Visible = true;
        }

        #region moveForm
        MoveForm move = new MoveForm();
        private void FormRules_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormRules_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
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
