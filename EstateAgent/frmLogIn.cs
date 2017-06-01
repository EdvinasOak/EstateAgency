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
    public partial class frmLogIn : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmLogIn()
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
                MessageBox.Show("Could not establish connection to Database");
                
            }
        }
        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from employee where employeeID=@user and password=@pass";
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);
            cmd.Connection = connect;
            MySqlDataReader employee = cmd.ExecuteReader();
            if (employee.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }
        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string user = txtBoxUsername.Text;
            string pass = txtBoxPassword.Text;
            if (user == "" || pass == "")
            {
                MessageBox.Show("Empty Fields Detected ! Please fill up all the fields");
                return;
            }
            bool r = validate_login(user, pass);
            if (r)
            {
                MessageBox.Show("Correct Login Credentials");
                //instantiate a new form and display it
                Variables.Manager = txtBoxUsername.Text;
                frmMain formcalled = new frmMain();
                formcalled.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Login Credentials");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //CODE NOT USED
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
