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
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
