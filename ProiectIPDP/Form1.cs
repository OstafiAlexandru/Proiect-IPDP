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
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Info.accdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Connection Successful";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Account_Info where Username ='"+txt_Username.Text+"' and Password ='"+txt_Password.Text+"'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count = count + 1;
            }

            if(count==1)
            {
                MessageBox.Show("Log In Successful");
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("There is a duplicate of the username and password in the database");
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}
