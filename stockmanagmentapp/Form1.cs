using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace stockmanagmentapp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private bool isvalidlogin()
        {
            if(adminTextBox1.Text.Trim()==string.Empty|adminTextBox1.Text.Length<5)
            {
                MessageBox.Show("Admin Name is required!", "Error!");
                return false;
            }
            else if(passwordTextBox2.Text.TrimStart()==string.Empty|passwordTextBox2.Text.Length<8)
            {
                MessageBox.Show("Password is incorrect", "Error!");
                return false;
            }
            return true;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if(isvalidlogin())
            {
                using(SqlConnection conn=new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True"))
                {
                    string query = string.Format("SELECT * FROM login WHERE adminname='{0}' and adminpassword={1}", adminTextBox1.Text.Trim(), passwordTextBox2.Text.Trim());
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    DataTable dta = new DataTable();
                    sda.Fill(dta);
                    if(dta.Rows.Count==1)
                    {
                        dashboard dashboard = new dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                }
            }

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
