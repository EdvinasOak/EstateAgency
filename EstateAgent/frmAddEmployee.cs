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
    public partial class frmAddEmployee : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        private string conn;
        private MySqlConnection connect;

        public frmAddEmployee()
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
        private void clearTextBox()
        {
            txtBoxFname.Text = "";
            txtBoxSurname.Text = "";
            txtBoxPassword.Text = "";
            txtBoxSalary.Text = "";
        }
        private void frmAddEmployee_Load(object sender, EventArgs e)
        {

        }
        private void add(string fname, string sName, string password, string salary)
        {
            db_connection();
            string sql = "Insert into employee(fName,sName,password,salary) Values(@fname, @sName, @password,@salary)";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            // add params
            cmd.Parameters.AddWithValue("@fname", fname);
            cmd.Parameters.AddWithValue("@sName", sName);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@salary", salary);

            try
            {
                db_connection();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    clearTextBox();
                    MessageBox.Show("Successfully Inserted!");
                }
                connect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }


        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            add(txtBoxFname.Text, txtBoxSurname.Text, txtBoxPassword.Text, txtBoxSalary.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmUpdateStaff formCalled = new frmUpdateStaff();
            formCalled.Show();
            this.Close();
        }
    }
}
