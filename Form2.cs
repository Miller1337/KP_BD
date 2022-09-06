using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KP_BD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LogIN_Click(object sender, EventArgs e)
        {
            String LoG = username.Text;
            String PaS = password.Text;

            CDB dB = new CDB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM kp_bd.enterthegungeon WHERE 'Name'= @username AND 'Pass'= @password", dB.getConnection());
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = LoG;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = PaS;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                MessageBox.Show("Верный пароль");
            else
                MessageBox.Show("Неверный пароль");

        }
    }
}
