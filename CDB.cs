using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace KP_BD
{
    class CDB
    {
        MySqlConnection KP = new MySqlConnection ("server=localhost; port=3306; username=root; password = 4021;database = kp_bd");
        
        public void OpenConnection()
        {
            if (KP.State == System.Data.ConnectionState.Closed)
                KP.Open();
        }
        public void CloseConnection()
        {
            if (KP.State == System.Data.ConnectionState.Open)
                KP.Close();
        }
        public MySqlConnection getConnection()
        {
            return KP;
        }
    }
}
