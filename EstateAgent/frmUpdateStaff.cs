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
    public partial class frmUpdateStaff : Form
    {
        private string conn;
        private MySqlConnection connect;

        MySqlCommand cmd;

        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public frmUpdateStaff()
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

        private void delete(int id)
        {
            db_connection();
            string sql = "delete from employee where employeeID = " + id + "";
            cmd = new MySqlCommand(sql, connect);

            try
            {
                db_connection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = connect.CreateCommand();

                adapter.DeleteCommand.CommandText = sql;

                if (MessageBox.Show("Are you Sure?", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {

                        MessageBox.Show("Successfully Deleted");
                    }
                }
                connect.Close();

                listemp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            frmUpdateStaffDetails formCalled = new frmUpdateStaffDetails();
            formCalled.Show();
            this.Close();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            String selected = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            if(id == 1001)
            {
                MessageBox.Show("Cannot Delete Manager!");
            }
            else
            {
                delete(id);
            }
            
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee formCalled = new frmAddEmployee();
            formCalled.Show();
            this.Close();
        }

        private void btnCancelUpdateStaff_Click(object sender, EventArgs e)
        {
            frmMain formCalled = new frmMain();
            formCalled.Show();
            this.Close();
        }
        private void populate(string id, string hNo, string address, string town)
        {
            dataGridView1.Rows.Add(id, hNo, address, town);
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
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[4].ToString());
                }
                connect.Close();

                //clear dt
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }
        private void frmUpdateStaff_Load(object sender, EventArgs e)
        {
            listemp();
        }
    }
}
