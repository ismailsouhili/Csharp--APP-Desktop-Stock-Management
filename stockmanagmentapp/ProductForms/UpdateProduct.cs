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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
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

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("update Product set CatName='{0}',Pprice={1}  where Pname='{2}' ", cmbCAT.SelectedItem, txtPRICE.Text, txtPN.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Update successfully");
                txtPN.Text = string.Empty;
                txtPRICE.Text = string.Empty;
                cmbCAT.Text = string.Empty;

            }
            else
                MessageBox.Show("Error");
        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
