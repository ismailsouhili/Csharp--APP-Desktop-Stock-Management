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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("delete from Category where ID={0}", txtID.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Delete successfully");
                txtID.Text = "";
            }
            else
                MessageBox.Show("Error");
        }
    }
}
