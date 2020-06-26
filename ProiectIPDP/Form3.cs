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
    public partial class Form3 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form3()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Info.accdb;Persist Security Info=False;";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = connection;
            command1.CommandText = "select * from Account_Info where Username ='" + txt_Username.Text + "'";
            OleDbDataReader reader = command1.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count >= 1)
            {
                MessageBox.Show("This account already exists");
            }

            else if(txt_Password.Text != txt_ConfirmP.Text)
            {
                MessageBox.Show("Passwords don't match");
            }
            else
            {
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                command2.CommandText = "insert into Account_Info ([Username],[Prenume],[Nume],[Data_Nasterii],[Password],[Data_Crearii_Contului]) values('" + txt_Username.Text + "','" + txt_FName.Text + "','" + txt_LName.Text + "','" + txt_Birthday.Text + "','" + txt_Password.Text + "','"+DateTime.Today+"')";
                command2.ExecuteNonQuery();
                MessageBox.Show("Account succesfully created");
            }
            connection.Close();
        }

    }
}
