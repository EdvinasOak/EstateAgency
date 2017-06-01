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
    public partial class frmNewViewing2 : Form
    {
        
        private List<string> bookedTimes = new List<string>();
        private List<string> availableTimes = new List<string>();
        private string timeSelected = "";
        private string selectedProp = "";
        private string selectedClient = "";
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        private string conn;
        private MySqlConnection connect;

        public frmNewViewing2()
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
        private void frmNewViewing2_Load(object sender, EventArgs e)
        {
            lblDatePicked.Text = Variables.SelectedDate;
            selectedProp = Variables.SelectedProp;

            
            
            string tempSelectedPropString = selectedProp;
            int tempSelectedProp = Int32.Parse(tempSelectedPropString);
            getSelectedProperty(tempSelectedProp);

            getBookedTimes(tempSelectedProp, Variables.SelectedDate);
            RemoveBookedTimesFromList();
            fillGridWithClients();

            Variables.SelectedBuyer = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            selectedClient = Variables.SelectedBuyer;
        }
        // Getting Selected property to Display on the label
        public void getSelectedProperty(int propid)
        {
            db_connection();
           int hNum=0;
           string add="";
           string town="";
            
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from property where propertyID=@propid";
            cmd.Parameters.AddWithValue("@propid", propid);
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            while (vRdr.Read())
            {
                
                hNum = Convert.ToInt32(vRdr["HouseNo"]);
                add = vRdr["Address"].ToString();
                town = vRdr["Town"].ToString();
                

            }
            connect.Close();
            lblPropPicked.Text = hNum + " " + add + " " + town;
          
        }
        void populateClients(string buyerid, string fName, string lName, string pNum)
        {
            dataGridViewClients.Rows.Add(buyerid, fName, lName, pNum);
        }
        // Display the Clients in a grid
        void fillGridWithClients()
        {
            dataGridViewClients.Rows.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select * from buyer";
            cmd.Connection = connect;
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateClients(row["buyerID"].ToString(), row["fName"].ToString(), row["lName"].ToString(), row["phoneNo"].ToString());
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
        
        // Remove the times from the dropbox that are already occupied for that property and that date
        void RemoveBookedTimesFromList()
        {
            List<string> tempBookedTimes = new List<string>();
            List<string> tempTimes = new List<string>();
            string[] arrayTimes = new string[] { };
            string[] arrayBookedTimes = new string[] { };
            string[] availableTimes = new string[] { };

            tempTimes = new List<string>(Variables._arrayTimes);
            tempBookedTimes = new List<string>(bookedTimes);
            arrayTimes = tempTimes.ToArray();
            arrayBookedTimes = tempBookedTimes.ToArray();

            IEnumerable<string> tempNewTimes = tempTimes.Except(tempBookedTimes);
            availableTimes = tempNewTimes.ToArray();

            comboBoxAvailableTimes.DataSource = availableTimes;
        }
        
        // Get the booked times for removeal from the dropbox
        void getBookedTimes(int id, string date)
        {
            dataGridViewClients.Rows.Clear();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select time from viewing where propertyID=@id and date=@date;";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                while (vRdr.Read())
                {
                    string tempTime = "";

                    tempTime = vRdr["time"].ToString();

                    bookedTimes.Add(tempTime);
                }
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
            
        }
        
        // Create Viewing method
        void createViewing(int viewBuyerId, int viewPropId, string viewDate, string viewTime)
        {
            try
            {
                db_connection();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = "insert into viewing (buyerID, propertyID, date, time) values (@buyerID, @propertyID, @date, @time)";
                cmd.Parameters.AddWithValue("@buyerID", viewBuyerId);
                cmd.Parameters.AddWithValue("@propertyID", viewPropId);
                cmd.Parameters.AddWithValue("@date", viewDate);
                cmd.Parameters.AddWithValue("@time", viewTime);
                cmd.Connection = connect;
                cmd.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("New Viewing Was Successfully Created");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                    connect.Close();
            }
            
        }
        private void dataGridViewClients_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        
        // Create viewing button
        private void btnCreateViewing_Click(object sender, EventArgs e)
        {
            
            int tempSelectedBuyer = 0;
            try
            {
                tempSelectedBuyer = Int32.Parse(selectedClient);
                int tempSelectedProp = Int32.Parse(selectedProp);

                createViewing(tempSelectedBuyer, tempSelectedProp, Variables.SelectedDate, timeSelected);
                frmViewings2 fc = new frmViewings2();
                fc.Show();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Choose Client again");
            }
          
            
        }

        private void comboBoxAvailableTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            timeSelected = comboBoxAvailableTimes.Text;
        }

        private void dataGridViewClients_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Variables.SelectedBuyer = dataGridViewClients.SelectedRows[0].Cells[0].Value.ToString();
            selectedClient = Variables.SelectedBuyer;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmViewings2 fc = new frmViewings2();
            fc.Show();
            this.Close();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.Show();
            this.Close();
            Variables.Previous = "view";
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
