using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace stockmanagmentapp.mainforms
{
    public partial class customerform : Form
    {
        public customerform()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("insert into customers values({0},'{1}','{2}',{3})", txtIDC.Text,txtCustName.Text, txtEMAIL.Text,txtTEL.Text);
            SqlCommand cmd = new SqlCommand(req,cnx);
            cnx.Open();
            int i= cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {
              
                MessageBox.Show("Added successfully");
                txtIDC.Text = string.Empty;
                txtCustName.Text = string.Empty;
                txtEMAIL.Text = string.Empty;
                txtTEL.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");

        }
    }
}
