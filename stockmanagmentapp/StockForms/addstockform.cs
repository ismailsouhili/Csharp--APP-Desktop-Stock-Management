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
    public partial class addstockform : Form
    {
        public addstockform()
        {
            InitializeComponent();
        }
        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox4_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {

        }

        private void addstockform_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from Stock", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;


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

            SqlConnection cnxx = new SqlConnection(@"data source=DESKTOP-OF1I649\SQLEXPRESS ;initial catalog=StockManager ;integrated security=true");
            SqlCommand cm = new SqlCommand("select Pname from Product", cnxx);
            SqlDataReader drrr;
            cnxx.Open();
            drrr = cm.ExecuteReader();
            while (drrr.Read())
            {
                cmbPN.Items.Add(drrr[0]);
            }
            drrr.Close();
        }

        private void bunifuButton5_Click_1(object sender, EventArgs e)
        {
           

        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton5_Click_2(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("insert into Stock values({0},'{1}','{2}',{3})",txtIDS.Text, cmbCAT.Text, cmbPN.Text, txtPS.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Added successfully");
                cmbCAT.Text = string.Empty;
                cmbPN.Text = string.Empty;
                txtPS.Text = string.Empty;
                txtIDS.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("update Stock set Category='{0}', PName='{1}', PStock={2}  where IDStock={3} ", cmbCAT.Text, cmbPN.Text,txtPS.Text,txtIDS.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Update successfully");
                txtIDS.Text = string.Empty;
                txtPS.Text = string.Empty;
                cmbCAT.Text = string.Empty;
                cmbPN.Text = string.Empty;
            }
            else
                MessageBox.Show("Error");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("delete from Stock where IDStock={0}", txtIDS.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Delete successfully");
                txtIDS.Text = "";
            }
            else
                MessageBox.Show("Error");
        }

        private void bunifuButton6_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
