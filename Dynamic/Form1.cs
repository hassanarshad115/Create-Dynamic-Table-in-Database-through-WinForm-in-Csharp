using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["d"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
           
            string command = "CREATE TABLE [dbo]."+textBox3.Text+" ([Id]  INT IDENTITY(1, 1) NOT NULL,"+textBox1.Text+" NVARCHAR(50) NOT NULL,"+textBox2.Text+"  NVARCHAR(50) NOT NULL,PRIMARY KEY CLUSTERED([Id] ASC))";

            SqlCommand cmd = new SqlCommand(command, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("successfully created Table");
            conn.Close();
        


        }
    }
}
