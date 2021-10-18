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
    public partial class saleslist : Form
    {
        public saleslist()
        {
            InitializeComponent();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            salesform frm = new salesform();
            frm.Show();
        }

        private void saleslist_Load(object sender, EventArgs e)
        {
            Table();
           
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteSales DS = new DeleteSales();
            DS.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateSales US = new UpdateSales();
            US.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Sales where CustID={0} ", txtCUSTNAME.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Table();
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Sales", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Sales where ProductName='{0}' ", txtPNAME.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Sales where SalesDate between '{0}' and '{1}' ", txtDate1.Text,txtDate2.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
