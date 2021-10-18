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
    public partial class customerlist : Form
    {
        public customerlist()
        {
            InitializeComponent();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            customerform cf = new customerform();
            cf.Show();
        }

        private void customerlist_Load(object sender, EventArgs e)
        {
            Table();
        }

        private void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
           
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            customerFormUpdate cfu = new customerFormUpdate();
            cfu.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            customerFormDelete cfd = new customerFormDelete();
            cfd.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCustname_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            string req = string.Format("select * from customers where IDC={0}", txtCustname.Text);
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
            SqlDataAdapter da = new SqlDataAdapter("select * from customers", @"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            DataTable dt = new DataTable();
            da.Fill(dt);
            bunifuDataGridView1.DataSource = dt;
        }
    }
}

