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
    public partial class FormRegister : Form
    {
        String currentUser;
        String idUser;
        public FormRegister()
        {
            InitializeComponent();
            textBoxNickname.Text = "Нікнейм";
            textBoxNickname.ForeColor = Color.Gray;
            textBoxLogin.Text = "Логін";
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPass.Text = "Пароль";
            textBoxPass.ForeColor = Color.Gray;
            ControlMenu.Parent = pictureBoxFrame;
            labelRegister.Parent = pictureBoxFrame;
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
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
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxNickname.Text == "Нікнейм" || textBoxLogin.Text == "Логін" || textBoxPass.Text == "Пароль")
            {
                if (textBoxNickname.Text == "Нікнейм")
                    label1.Visible = true;
                if (textBoxLogin.Text == "Логін")
                    label2.Visible = true;
                if (textBoxPass.Text == "Пароль")
                    label3.Visible = true;
                return;
            }
            if (CheckUser())
                return;
            if(textBoxNickname.Text.Length<5 || textBoxNickname.Text.Length>15 || textBoxPass.Text.Length < 5)
            { 
                labelError.Visible = true;
                return;
            }
            FormLogin formLogin = new FormLogin();
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users`(`login`, `pass`, `nickname`) VALUES (@login, @pass, @nickname)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value=textBoxLogin.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBoxPass.Text;
            command.Parameters.Add("@nickname", MySqlDbType.VarChar).Value = textBoxNickname.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                formLogin.DesktopLocation = this.DesktopLocation;
                formLogin.SetUser(currentUser, idUser);
                formLogin.Show();
                formLogin.AccountMade();
                this.Hide();
            }
            else
                labelError.Visible = true;
            db.closeConnection();
        }

        private void textBoxNickname_Enter(object sender, EventArgs e)
        {
            if(textBoxNickname.Text=="Нікнейм")
            {
                textBoxNickname.Text = "";
                textBoxNickname.ForeColor = Color.Black;
            }
            label1.Visible = false;
            labelError.Visible = false;
        }

        private void textBoxNickname_Leave(object sender, EventArgs e)
        {
            if(textBoxNickname.Text=="")
            {
                textBoxNickname.Text = "Нікнейм";
                textBoxNickname.ForeColor = Color.Gray;
            }
        }
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логін")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
            label2.Visible = false;
            labelError.Visible = false;
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Логін";
                textBoxLogin.ForeColor = Color.Gray;
            }
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Пароль")
            {
                textBoxPass.Text = "";
                textBoxPass.ForeColor = Color.Black;
            }
            label3.Visible = false;
            labelError.Visible = false;
        }

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
            {
                textBoxPass.Text = "Пароль";
                textBoxPass.ForeColor = Color.Gray;
            }
        }


        public Boolean CheckUser()
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @userLogin", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = textBoxLogin.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                label4.Visible = true;
                return true;
            }
            else
            {
                label4.Visible = false;
                return false;
            }
               
        }

        private void textBoxNickname_MouseClick(object sender, MouseEventArgs e)
        {
            labelRules1.Visible = true;
            labelRules2.Visible = false;
            labelRules3.Visible = false;
        }

        private void textBoxLogin_MouseClick(object sender, MouseEventArgs e)
        {
            labelRules1.Visible = false;
            labelRules2.Visible = true;
            labelRules3.Visible = false;
        }

        private void textBoxPass_MouseClick(object sender, MouseEventArgs e)
        {
            labelRules1.Visible = false;
            labelRules2.Visible = false;
            labelRules3.Visible = true;
        }

        private void FormRegister_MouseClick(object sender, MouseEventArgs e)
        {
            labelRules1.Visible = false;
            labelRules2.Visible = false;
            labelRules3.Visible = false;
        }

        private void textBoxNickname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || (i >= 48 && i <= 57) || (i >= 65 && i <= 90)|| (i >= 97 && i <= 122)))
            {
                e.Handled = true;
            }
        }
        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || (i >= 48 && i <= 57) || (i >= 65 && i <= 90) || (i >= 97 && i <= 122) || i == 95))
            {
                e.Handled = true;
            }
        }
        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            int i = (int)c;
            if (!(i == 8 || (i >= 33 && i <= 126)))
            {
                e.Handled = true;
            }
        }
        #region moveform
        MoveForm move = new MoveForm();
        private void FormRegister_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormRegister_MouseDown(object sender, MouseEventArgs e)
        {

            move.MouseDown(sender, e);
        }

        private void pictureBoxFrame_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }
        private void pictureBoxFrame_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void labelRegister_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void labelRegister_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion
        private void buttonRegister_MouseEnter(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonRegister_MouseLeave(object sender, EventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.button;
        }

        private void buttonRegister_MouseDown(object sender, MouseEventArgs e)
        {
            buttonRegister.BackgroundImage = Properties.Resources.buttonpress;
        }
    }
}
