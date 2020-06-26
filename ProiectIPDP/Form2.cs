using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ProiectIPDP
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Info.accdb;Persist Security Info=False;";
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection; 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Account_Info where Status ='Online'";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt_FirstN.Text = reader["Prenume"].ToString();
                txt_LastN.Text = reader["Nume"].ToString();
                txt_Birthday.Text = reader["Data_Nasterii"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "select * from Account_Info where Password ='" + txt_NPass.Text + "' and Status = 'Online'";
            OleDbDataReader reader = command1.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count >= 1)
            {
                MessageBox.Show("New password must be different from the old password");
            }
            else if (txt_NPass.Text != txt_ConfirmP.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                command.CommandText = "update Account_Info set [Password] = '"+txt_NPass.Text+"' where [Status] ='Online'";
                command.ExecuteNonQuery();
                MessageBox.Show("Password changed successfully");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "update Account_Info set [Status] = 'Offline' where [Status] ='Online'";
            command.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
