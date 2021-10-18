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

namespace stockmanagmentapp
{
    public partial class customerFormUpdate : Form
    {
        public customerFormUpdate()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("update customers set Name='{0}' , Email='{1}' , Tel={2}  where IDC={3} ",txtCustName.Text,txtEMAIL.Text,txtTEL.Text, txtIDC.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Update successfully");
                txtIDC.Text = string.Empty;
                txtCustName.Text = string.Empty;
                txtEMAIL.Text = string.Empty;
                txtTEL.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
