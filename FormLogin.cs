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
    public partial class FormLogin : Form
    {
        FormProfile profile = new FormProfile();
        String currentUser;
        String idUser;
        public FormLogin()
        {
            InitializeComponent();
            textBoxLogin.Text = "Логін";
            textBoxLogin.ForeColor = Color.Gray;
            textBoxPass.Text = "Пароль";
            textBoxPass.ForeColor = Color.Gray;
            labelLogin.Parent = pictureBoxFrame;
            ControlMenu.Parent = pictureBoxFrame;
        }
        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        public void AccountMade()
        {
            this.labelAccMade.Visible = true;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Логін" || textBoxPass.Text == "Пароль")
            {
                if (textBoxLogin.Text == "Логін")
                    label2.Visible = true;
                if (textBoxPass.Text == "Пароль")
                    label3.Visible = true;
                return;
            }
            String userLogin = textBoxLogin.Text;
            String userPass = textBoxPass.Text;
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`= @userLogin AND `pass`= @userPass", db.getConnection());
            command.Parameters.Add("@userLogin", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = userPass;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.openConnection();
            if (table.Rows.Count > 0)
            {
                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    idUser = reader[0].ToString();
                    currentUser = reader[3].ToString();
                }
                reader.Close();
                profile.DesktopLocation = this.DesktopLocation;
                profile.SetUser(currentUser, idUser);
                profile.Show();
                this.Hide();
            }
            else
            {
                labelAccMade.Visible = false;
                labelError.Visible = true; }
            db.closeConnection();
        }
        
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Brown;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.DesktopLocation = this.DesktopLocation;
            formRegister.SetUser(currentUser, idUser);
            formRegister.Show();
            this.Hide();
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
        #region controlmenu
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

        private void pictureBoxX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region moveForm
        MoveForm move = new MoveForm();
        private void FormLogin_MouseMove(object sender, MouseEventArgs e)
        {

            move.Move(sender, e, this);
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
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

        private void labelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void labelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion
        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackgroundImage = Properties.Resources.buttonhover;
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackgroundImage = Properties.Resources.button;
        }

        private void buttonLogin_MouseDown(object sender, MouseEventArgs e)
        {
            buttonLogin.BackgroundImage = Properties.Resources.buttonpress;
        }

    }
}
