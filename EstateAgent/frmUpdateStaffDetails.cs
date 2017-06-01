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
    public partial class frmUpdateStaffDetails : Form
    {

        private string conn;
        private MySqlConnection connect;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public frmUpdateStaffDetails()
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

        private void frmUpdateStaffDetails_Load(object sender, EventArgs e)
        {
            listemp();
            txtBoxFname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBoxSalary.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);

            update(id, txtBoxFname.Text, txtBoxSurname.Text, txtBoxPassword.Text, txtBoxSalary.Text);
            listemp();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmUpdateStaff formCalled = new frmUpdateStaff();
            formCalled.Show();
            this.Close();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtBoxFname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBoxSurname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtBoxPassword.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtBoxSalary.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void populate(string id, string name, string surname, string password, string salary)
        {
            dataGridView1.Rows.Add(id, name, surname, password, salary);
        }
        private void clearTextBox()
        {
            txtBoxSurname.Text = "";
            txtBoxFname.Text = "";
            txtBoxPassword.Text = "";
            txtBoxSalary.Text = "";

        }
        void listemp()
        {
            dataGridView1.Rows.Clear();
            db_connection();

            string sql = "Select * from employee where employeeid != 1001";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                }
                connect.Close();

                //clear dt
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void update(int id, string fName, string sName, string password, string salary)
        {
            db_connection();
            string sql = "UPDATE employee set fName = '" + fName + "',sName = '" + sName + "',password='" + password + "', salary='" + salary + "' where employeeID =" + id + "";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            try
            {
                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = connect.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    clearTextBox();
                    MessageBox.Show("Successfully Updated!");
                }
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxFname_TextChanged(object sender, EventArgs e)
        {

        }

        

        
       
    }
}
