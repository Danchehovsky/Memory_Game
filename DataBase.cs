using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPLOM
{
    class DataBase
    {
        MySqlConnection connect=new MySqlConnection("server=localhost;port=3306;username=root;password=;database=Diplom");

        public void openConnection()
        {
            if (connect.State == System.Data.ConnectionState.Closed)
                connect.Open();
        }
        public void closeConnection()
        {
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
        }
        public MySqlConnection getConnection()
        {
            return connect;
        }
    }
}
