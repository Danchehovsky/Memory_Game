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
    public partial class FormLeader : Form
    {
        String currentUser;
        String idUser;
        public FormLeader()
        {
            InitializeComponent();
            GetPoints();
        }

        public void SetUser(String User, String id)
        {
            currentUser = User;
            idUser = id;
        }
        public void GetPoints()
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `nickname`,`score` FROM `scores` WHERE `game`=@game ORDER BY `score` DESC", db.getConnection());
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "memory";
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if(labelUser11.Text=="User1")
                {
                    labelUser11.Text = reader.GetValue(0).ToString();
                    labelPoints11.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser12.Text == "User2")
                {
                    labelUser12.Text = reader.GetValue(0).ToString();
                    labelPoints12.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser13.Text == "User3")
                {
                    labelUser13.Text = reader.GetValue(0).ToString();
                    labelPoints13.Text = reader.GetValue(1).ToString();
                }
            }
            reader.Close();
            command = new MySqlCommand("SELECT `nickname`,`score` FROM `scores` WHERE `game`=@game ORDER BY `score` DESC", db.getConnection());
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "matrix";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (labelUser21.Text == "User1")
                {
                    labelUser21.Text = reader.GetValue(0).ToString();
                    labelPoints21.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser22.Text == "User2")
                {
                    labelUser22.Text = reader.GetValue(0).ToString();
                    labelPoints22.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser23.Text == "User3")
                {
                    labelUser23.Text = reader.GetValue(0).ToString();
                    labelPoints23.Text = reader.GetValue(1).ToString();
                }
            }
            reader.Close();
            command = new MySqlCommand("SELECT `nickname`,`score` FROM `scores` WHERE `game`=@game ORDER BY `score` DESC", db.getConnection());
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "simon";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (labelUser31.Text == "User1")
                {
                    labelUser31.Text = reader.GetValue(0).ToString();
                    labelPoints31.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser32.Text == "User2")
                {
                    labelUser32.Text = reader.GetValue(0).ToString();
                    labelPoints32.Text = reader.GetValue(1).ToString();
                }
                else if (labelUser33.Text == "User3")
                {
                    labelUser33.Text = reader.GetValue(0).ToString();
                    labelPoints33.Text = reader.GetValue(1).ToString();
                }
            }
            db.closeConnection();
        }

        MoveForm move = new MoveForm();
        private void FormLeader_MouseMove(object sender, MouseEventArgs e)
        {

            move.Move(sender, e, this);
        }

        private void FormLeader_MouseDown(object sender, MouseEventArgs e)
        {

            move.MouseDown(sender, e);
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
    }
}
