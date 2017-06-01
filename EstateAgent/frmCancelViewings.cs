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
    public partial class frmCancelViewings : Form
    {
        private string conn;
        private MySqlConnection connect;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        MySqlCommand cmd;

        public frmCancelViewings()
        {
            InitializeComponent();
            MonthCalendar monthCalCancelViewings = new MonthCalendar();

            // get todays date and assign it to Global variable
            DateTime thisDay = DateTime.Today;
            thisDay.ToShortDateString();
            string td = thisDay.ToString("yyyy-MM-dd");
            Variables.TodaysDate = td;
            Variables.SelectedDate = td;
            DateTime lastDate = new DateTime();
            lastDate = thisDay.AddDays(21);
            this.monthCalCancelViewings.MinDate = thisDay;
            this.monthCalCancelViewings.MaxDate = lastDate;

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
        private void frmCancelViewings_Load(object sender, EventArgs e)
        {
            fillDataGridWithViewings(Variables.SelectedDate);
        }
        private void populateViewings(string VNo, string date, string time, string lname, string fname, string HouseNo, string address)
        {
            dataGridViewings.Rows.Add(VNo,date, time, lname, fname, HouseNo, address);
        }
        private void fillDataGridWithViewings(string date)
        {
            dataGridViewings.Rows.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT viewing.viewingNo, viewing.date, viewing.time, buyer.fName, buyer.lName, property.HouseNo, property.Address FROM buyer JOIN viewing ON buyer.buyerID = viewing.buyerID JOIN property on property.propertyID = viewing.propertyID where viewing.date = @date";
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Connection = connect;
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateViewings(row["viewingNo"].ToString(), row["date"].ToString(), row["time"].ToString(), row["fName"].ToString(), row["lName"].ToString(), row["HouseNo"].ToString(), row["Address"].ToString());
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

        private void dataGridViewings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalCancelViewings_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime sDate = monthCalCancelViewings.SelectionStart;
            sDate.ToShortDateString();
            string selectedDate = sDate.ToString("yyyy-MM-dd");
            Variables.SelectedDate = selectedDate;

            fillDataGridWithViewings(Variables.SelectedDate);
        }
        private void deleteViewing(int id)
        {
            db_connection();
            string sql = "delete from viewing where viewingNo = " + id + "";
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

                fillDataGridWithViewings(Variables.SelectedDate);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelViewing_Click(object sender, EventArgs e)
        {
            String selected = dataGridViewings.SelectedRows[0].Cells[0].Value.ToString();
            int id = Convert.ToInt32(selected);
            deleteViewing(id);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmViewings2 fc = new frmViewings2();
            fc.Show();
            this.Close();
        }
        
    }
}
