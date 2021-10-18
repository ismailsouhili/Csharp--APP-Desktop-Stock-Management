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
    public partial class productlist : Form
    {
        public productlist()
        {
            InitializeComponent();
        }

        private void bunifuTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = general.isnumber(e);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            productform pf = new productform();
            pf.Show();
        }
       

        private void productlist_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Product where Pname='{0}' ", txtPN.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            cleanfilters();
        }

        private void cleanfilters()
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateProduct UP = new UpdateProduct();
            UP.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteProduct DP = new DeleteProduct();
            DP.Show();
        }

        private void bunifuButton6_Click_1(object sender, EventArgs e)
        {
            Table();
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Product", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }
    }
}
