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
    public partial class salesform : Form
    {
        public salesform()
        {
            InitializeComponent();
        }

        private void bunifuTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("insert into Sales values({0},{1},'{2}',{3},{4})",txtrefsales.Text, txtCUSTID.Text, txtPN.Text, txtPS.Text,txtPSA.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Added successfully");
                txtCUSTID.Text = string.Empty;
                txtrefsales.Text = string.Empty;
                txtPN.Text = string.Empty;
                txtPS.Text = string.Empty;
                txtPSA.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");
        }

        private void salesform_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select IDC from customers", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            GVCUST.DataSource = dt;

            SqlDataAdapter dd = new SqlDataAdapter("select CategoryName from Category", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable tt = new DataTable();
            dd.Fill(tt);
            GVCAT.DataSource = tt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
