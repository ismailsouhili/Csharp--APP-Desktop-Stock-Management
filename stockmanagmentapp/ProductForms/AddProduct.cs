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
    public partial class productform : Form
    {
        public productform()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
        private void productform_Load(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=StockManager ;integrated security=true");
            SqlCommand cmd = new SqlCommand("select CategoryName from Category", cnx);
            SqlDataReader dr;
            cnx.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbCAT.Items.Add(dr[0]);
            }
            dr.Close();

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("insert into Product values('{0}','{1}',{2})", txtPN.Text, cmbCAT.Text, txtPRICE.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Added successfully");
                txtPN.Text = string.Empty;
                cmbCAT.Text = string.Empty;
                txtPRICE.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");
        }
    }
}
