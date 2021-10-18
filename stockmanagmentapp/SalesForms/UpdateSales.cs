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
    public partial class UpdateSales : Form
    {
        public UpdateSales()
        {
            InitializeComponent();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection(@"Data Source= DESKTOP-OF1I649\SQLEXPRESS  ;initial catalog= StockManager  ;Integrated Security=True");
            string req = string.Format("update Sales set CustID={0}, ProductName='{1}', productStock={2}, SalesDate={3}  where Refsales={4} ",txtCUSTID.Text, txtPN.Text, txtPS.Text,txtPSA.Text,txtrefsales.Text);
            SqlCommand cmd = new SqlCommand(req, cnx);
            cnx.Open();
            int i = cmd.ExecuteNonQuery();
            cnx.Close();

            if (i == 1)
            {

                MessageBox.Show("Update successfully");
                txtCUSTID.Text = string.Empty;
                txtPN.Text = string.Empty;
                txtPS.Text = string.Empty;
                txtPSA.Text = string.Empty;
                txtrefsales.Text = string.Empty;

            }
            else
                MessageBox.Show("Error");
        }
    }
}
