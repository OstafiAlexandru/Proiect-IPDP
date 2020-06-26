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
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "select * from Account_Info where Status ='Online'";
                int counter = 0;
                OleDbDataReader reader1 = command1.ExecuteReader();
                while (reader1.Read())
                {
                    counter = counter + 1;
                }
                if (counter == 1)
                {
                    connection.Close();
                    connection.Dispose();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                checkConnection.Text = "Connection Successful";
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            command2.CommandText = "select * from Account_Info where Username ='"+txt_Username.Text+"' and Password ='"+txt_Password.Text+"'";
            OleDbDataReader reader2 = command2.ExecuteReader();
            int count = 0;
            while(reader2.Read())
            {
                count = count + 1;
            }

            if(count==1)
            {
                MessageBox.Show("Log In Successful");
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;
                command3.CommandText = "update Account_Info set [Status] = 'Online' where [Username] ='"+txt_Username.Text+"'";
                command3.ExecuteNonQuery();
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else if (count > 1)
            {
                MessageBox.Show("There is a duplicate of the account in the database");
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
