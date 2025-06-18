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
    public partial class Form1 : Form
    {
        String currentUser;
        String idUser;
        public Form1()
        {
            InitializeComponent();
        }
        public void SetUser(String User, String id)
        {
            currentUser=User;
            idUser=id;
        }
        #region controlmenu
        private void pictureBoxUser_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxUser.Image = Properties.Resources.userhover;
        }

        private void pictureBoxUser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxUser.Image = Properties.Resources.user;
        }
        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile();
            profile.DesktopLocation = this.DesktopLocation;
            profile.SetUser(currentUser, idUser);
            profile.Show();
            this.Hide();
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

        private void pictureBoxX_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxX.Image = Properties.Resources.Xhover;
        }

        private void pictureBoxX_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxX.Image = Properties.Resources.X;
        }

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region games
        private void pictureBoxMemory_Click(object sender, EventArgs e)
        {
            FormPairsDif1 pairs = new FormPairsDif1();
            pairs.DesktopLocation = this.DesktopLocation;
            pairs.SetUser(currentUser, idUser);
            pairs.Show();
            this.Hide();
        }

        private void pictureBoxMemory_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMemory.Image = Properties.Resources.memoryIconhover;
            labelMemory.ForeColor = Color.DarkRed;
        }

        private void pictureBoxMemory_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMemory.Image = Properties.Resources.memoryIcon;
            labelMemory.ForeColor = Color.SandyBrown;
        }

        private void pictureBoxMatrix_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMatrix.Image = Properties.Resources.matrixIconhover;
            labelMatrix.ForeColor = Color.DarkRed;
        }

        private void pictureBoxMatrix_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMatrix.Image = Properties.Resources.matrixIcon;
            labelMatrix.ForeColor = Color.SandyBrown;
        }

        private void pictureBoxMatrix_Click(object sender, EventArgs e)
        {
            FormMatrix mat = new FormMatrix();
            mat.DesktopLocation = this.DesktopLocation;
            mat.SetUser(currentUser, idUser);
            mat.Show();
            this.Hide();
        }
        private void pictureBoxSimon_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxSimon.Image = Properties.Resources.simonIconhover;
            labelSimon.ForeColor = Color.DarkRed;
        }

        private void pictureBoxSimon_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxSimon.Image = Properties.Resources.simonIcon;
            labelSimon.ForeColor = Color.SandyBrown;
        }

        private void pictureBoxSimon_Click(object sender, EventArgs e)
        {
            FormSimon simon = new FormSimon();
            simon.DesktopLocation = this.DesktopLocation;
            simon.SetUser(currentUser, idUser);
            simon.Show();
            this.Hide();
        }
        #endregion
        #region controlmenu2
        private void pictureBoxUser2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxUser2.Image = Properties.Resources.userhover;
        }

        private void pictureBoxUser2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxUser2.Image = Properties.Resources.user;
        }

        private void pictureBoxLeader2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLeader2.Image = Properties.Resources.leaderboardhover;
        }

        private void pictureBoxLeader2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLeader2.Image = Properties.Resources.leaderboard;
        }
        private void pictureBoxLeader2_Click(object sender, EventArgs e)
        {
            FormLeader leader = new FormLeader();
            leader.DesktopLocation = this.DesktopLocation;
            leader.SetUser(currentUser, idUser);
            leader.Show();
            this.Hide();
        }
        private void pictureBoxHome2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHome2.Image = Properties.Resources.homehover;
        }

        private void pictureBoxHome2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHome2.Image = Properties.Resources.home;
        }

        private void pictureBoxHome2_Click(object sender, EventArgs e)
        {
            panelGames.Visible = false;
            panelGames.Enabled = false;
        }
        private void pictureBoxX2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxX2.Image = Properties.Resources.Xhover;
        }

        private void pictureBoxX2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxX2.Image = Properties.Resources.X;
        }

        private void pictureBoxUser2_Click(object sender, EventArgs e)
        {
            FormProfile profile = new FormProfile();
            profile.DesktopLocation = this.DesktopLocation;
            profile.SetUser(currentUser, idUser);
            profile.Show();
            this.Hide();
        }

        private void pictureBoxX2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region buttons
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            panelGames.Enabled = true;
            panelGames.Visible = true;
        }

        private void buttonPlay_MouseEnter(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonPlay_MouseLeave(object sender, EventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.button;
        }

        private void buttonPlay_MouseDown(object sender, MouseEventArgs e)
        {
            buttonPlay.BackgroundImage = Properties.Resources.buttonpress;
        }
        #endregion
        #region moveForm
        MoveForm move = new MoveForm();
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void pictureBoxLogo_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }
        private void panelGames_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panelGames_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion
        #region info
        private void pictureBoxInfo3_Click(object sender, EventArgs e)
        {
            FormRules rules = new FormRules();
            rules.DesktopLocation = this.DesktopLocation;
            rules.SetUser(currentUser, idUser);
            rules.ChoosePanel3();
            rules.Show();
            this.Hide();
        }

        private void pictureBoxInfo2_Click(object sender, EventArgs e)
        {
            FormRules rules = new FormRules();
            rules.DesktopLocation = this.DesktopLocation;
            rules.SetUser(currentUser, idUser);
            rules.ChoosePanel2();
            rules.Show();
            this.Hide();
        }

        private void pictureBoxInfo1_Click(object sender, EventArgs e)
        {
            FormRules rules = new FormRules();
            rules.DesktopLocation = this.DesktopLocation;
            rules.SetUser(currentUser, idUser);
            rules.ChoosePanel1();
            rules.Show();
            this.Hide();
        }

        private void pictureBoxInfo3_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInfo3.Image = Properties.Resources.infohover;
        }

        private void pictureBoxInfo3_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInfo3.Image = Properties.Resources.info;
        }

        private void pictureBoxInfo2_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInfo2.Image = Properties.Resources.infohover;
        }

        private void pictureBoxInfo2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInfo2.Image = Properties.Resources.info;
        }

        private void pictureBoxInfo1_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxInfo1.Image = Properties.Resources.infohover;
        }

        private void pictureBoxInfo1_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxInfo1.Image = Properties.Resources.info;
        }
        #endregion

    }
}
