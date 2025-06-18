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
    public partial class FormProfile : Form
    {
        String currentUser;
        String idUser;
        public FormProfile()
        {
            InitializeComponent();
        }
        public void SetUser(String User, String id)
        {
            if(User!=null)
            {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "memory";
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                labelmem.Text = reader[0].ToString();
            }
            reader.Close();
            command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "matrix";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelmat.Text = reader[0].ToString();
            }
            reader.Close();
            command = new MySqlCommand("SELECT score FROM `scores` WHERE `iduser`= @iduser AND `game`= @game", db.getConnection());
            command.Parameters.Add("@iduser", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@game", MySqlDbType.VarChar).Value = "simon";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                labelsim.Text = reader[0].ToString();
            }
            reader.Close();
            db.closeConnection();
            }
            currentUser = User;
            idUser = id;
            labelUser.Text = User;
            if(User==null)
            {
                labelNull.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.DesktopLocation = this.DesktopLocation;
            formLogin.SetUser(currentUser, idUser);
            formLogin.Show();
            this.Hide();
        }
        #region moveform
        MoveForm move = new MoveForm();
        private void FormProfile_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void FormProfile_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            move.Move(sender, e, this);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            move.MouseDown(sender, e);
        }
        #endregion
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

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Sienna;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.SandyBrown;
        }

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
