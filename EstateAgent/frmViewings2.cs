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
    public partial class frmViewings2 : Form
    {
        private string conn;
        private MySqlConnection connect;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        

        public frmViewings2()
        {
            InitializeComponent();
            MonthCalendar ViewingsCalendar = new MonthCalendar();

            // get todays date and assign it to Global variable
            DateTime thisDay = DateTime.Today;
            thisDay.ToShortDateString();
            string td = thisDay.ToString("yyyy-MM-dd");
            Variables.TodaysDate = td;
            Variables.SelectedDate = td;
            label4.Text = "Date: " + Variables.SelectedDate;
            Variables.SelectedProp = "1";

            DateTime lastDate = new DateTime();
            lastDate = thisDay.AddDays(21);
            this.ViewingsCalendar.MinDate = thisDay;
            this.ViewingsCalendar.MaxDate = lastDate;

            //datagrid properties
            dataGridProperties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProperties.MultiSelect = false;
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
        
        private void frmViewings2_Load(object sender, EventArgs e)
        {
            listProps();

            

            
        }
       
        private void dataGridProperties_SelectionChanged(object sender, EventArgs e)
        {
            
        }
       
        private void ViewingsCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime sDate = ViewingsCalendar.SelectionStart;
            sDate.ToShortDateString();
            string selectedDate = sDate.ToString("yyyy-MM-dd");
            Variables.SelectedDate = selectedDate;
            label4.Text = "Date: " + Variables.SelectedDate;

            string tempSelectedPropString = Variables.SelectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);
            
            fillDataGridWithViewings(tempSelectedProp, Variables.SelectedDate);
            
        }
        
        private void populate(string id, string hNo, string address, string town)
        {
            dataGridProperties.Rows.Add(id, hNo, address, town);
        }
        
        void listProps()
        {
            dataGridProperties.Rows.Clear();
            db_connection();

            string sql = "Select * from property where status != 'Sold'";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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
        

        private void dataGridProperties_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       

        private void dataGridProperties_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewingsCalendar.SetDate(DateTime.Today);
            Variables.SelectedProp = dataGridProperties.SelectedRows[0].Cells[0].Value.ToString();
            string tempSelectedPropString = Variables.SelectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);
            fillDataGridWithViewings(tempSelectedProp, Variables.SelectedDate);
            
        }
       
        private void populateViewings(string date, string time, string lname, string fname)
        {
            dataGridViewings.Rows.Add(date, time, lname, fname);
        }
        
        void fillDataGridWithViewings(int id, string date)
        {
            dataGridViewings.Rows.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText ="SELECT viewing.date, viewing.time, buyer.fName, buyer.lName FROM buyer JOIN viewing ON buyer.buyerID = viewing.buyerID where viewing.date = @date and viewing.propertyID =@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Connection = connect;
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateViewings(row["date"].ToString(), row["time"].ToString(), row["fName"].ToString(), row["lName"].ToString());
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

        private void btnNewViewing_Click(object sender, EventArgs e)
        {
            frmNewViewing2 fC = new frmNewViewing2();
            fC.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain fc = new frmMain();
            fc.Show();
            this.Close();
        }

        private void btnCancelViewings_Click(object sender, EventArgs e)
        {
            frmCancelViewings fc = new frmCancelViewings();
            fc.Show();
            this.Close();
        }

        private void dataGridProperties_MouseClick(object sender, MouseEventArgs e)
        {
           
        }
        

        
    }
}
