using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstateAgent
{
    public partial class frmMain : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmMain()
        {
            InitializeComponent();
        }
        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=estate;Uid=root;Pwd=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                throw;
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Variables.Manager == "1001")
            {
                panelUpdateStaff.Show();
            }
            else
            {
                panelUpdateStaff.Hide();
            }

        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            frmUpdateStaff fc = new frmUpdateStaff();
            fc.Show();
            this.Close();
        }

        private void btnOffer_Click(object sender, EventArgs e)
        {
            formOffer fc = new formOffer();
            fc.Show();
            this.Close();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            frmProperty fc = new frmProperty();
            fc.Show();
            this.Close();
        }

        private void btnProSalesRep_Click(object sender, EventArgs e)
        {
            frmSalesData fc = new frmSalesData();
            fc.Show();
            this.Close();
        }

        private void btnCheckView_Click(object sender, EventArgs e)
        {
            frmViewings2 formCalled = new frmViewings2();
            formCalled.Show();
            this.Close();
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            frmEmail formaCalled = new frmEmail();
            formaCalled.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void panelUpdateStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdateStaff_Click_1(object sender, EventArgs e)
        {
            frmUpdateStaff fc = new frmUpdateStaff();
            fc.Show();
            this.Close();
        }
    }
}