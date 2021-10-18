using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using stockmanagmentapp.mainforms;
using System.Data.SqlClient;

namespace stockmanagmentapp.mainforms
{
    public partial class categorylist : Form
    {
        public categorylist()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddCategory cf = new AddCategory();
            cf.Show();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void categorylist_Load(object sender, EventArgs e)
        {
            Table();

        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            UpdateCategory upc = new UpdateCategory();
            upc.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            DeleteCategory dc = new DeleteCategory();
            dc.Show();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from Category where ID={0}", txtID.Text);
            SqlDataAdapter da = new SqlDataAdapter(req, @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCat.DataSource = dt;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            Table();
        }

        public void Table()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Category", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvCat.DataSource = dt;
        }
    }
}
