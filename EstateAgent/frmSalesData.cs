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
    public partial class frmSalesData : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        private string conn;
        private MySqlConnection connect;

        private List<string> propertyStatusArray = new List<string>();
        private List<string> typeArray = new List<string> ();
        private List<string> propertyTypeArray = new List<string>();
        private List<string> townArray = new List<string>();
        private List<string> roomsArray = new List<string>();

        private string selectedStatus = "";
        private string selectedType = "";
        private string selectedPropType = "";
        private string selectedTown = "";
        private string selectedRooms = "";

        public frmSalesData()
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
        
        private void frmSalesData_Load(object sender, EventArgs e)
        {
            getTownArray();
            getPropertyStatusArray();
            getTypeArray();
            getPropertyTypeArray();
            getRooms();
        }
        
        // creates a Property Status array from database and creates a distinct array
        private void getPropertyStatusArray()
        {
            List<string> tempPropStatArray = new List<string>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select status from property;";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                
                while(vRdr.Read())
                {
                    string tempStatus = "";
                    tempStatus = vRdr["status"].ToString();
                    tempPropStatArray.Add(tempStatus);
                }
                propertyStatusArray = tempPropStatArray.Distinct().ToList();
                cBoxPropertyStatus.DataSource = propertyStatusArray;
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }
        
        // creates a Sale Type array from database and creates a distinct array
        private void getTypeArray()
        {
            List<string> tempTypeArray = new List<string>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select type from property;";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                
                while (vRdr.Read())
                {
                    string tempType = "";

                    tempType = vRdr["type"].ToString();

                    tempTypeArray.Add(tempType);
                }

                typeArray = tempTypeArray.Distinct().ToList();
                cBoxType.DataSource = typeArray;
                connect.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }

        // creates a Property Type array from database and creates a distinct array
        private void getPropertyTypeArray()
        {
            List<string> tempPropertyTypeArray = new List<string>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select PropertyType from property;";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                tempPropertyTypeArray.Add("Any");
                while (vRdr.Read())
                {
                    string tempPropType = "";

                    tempPropType = vRdr["PropertyType"].ToString();

                    tempPropertyTypeArray.Add(tempPropType);
                }

                propertyTypeArray = tempPropertyTypeArray.Distinct().ToList();
                cBoxPropertyType.DataSource = propertyTypeArray;
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }

        // creates a Town Array with towns in the database and creates a distinct array
        private void getTownArray()
        {
            List<string> tempTownArray = new List<string>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select town from property;";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                tempTownArray.Add("Any");
                while (vRdr.Read())
                {
                    string tempTown = "";

                    tempTown = vRdr["town"].ToString();

                    tempTownArray.Add(tempTown);
                }

                townArray = tempTownArray.Distinct().ToList();
                cBoxTown.DataSource = townArray;
                connect.Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

            
        }
        
        // creates a Number of Rooms array from db and creates a distinct array
        private void getRooms()
        {
            List<string> tempRoomArray = new List<string>();
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select NoOfRooms from property;";
            cmd.Connection = connect;
            MySqlDataReader vRdr = cmd.ExecuteReader();

            try
            {
                tempRoomArray.Add("Any");
                while (vRdr.Read())
                {
                    string tempRoom = "";

                    tempRoom = vRdr["NoOfRooms"].ToString();

                    tempRoomArray.Add(tempRoom);
                }
                
                roomsArray = tempRoomArray.Distinct().ToList();
                cBoxNoOfRooms.DataSource = roomsArray;
                connect.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }

        // Populate datagrid
        private void populate(string id, string hNo, string address, string town, string pType, string rooms, string price, string type, string status)
        {
            dataGridProps.Rows.Add(id, hNo, address, town, pType, rooms, price, type, status);
        }

        // Query Database for properties with specified attributes using dropboxes
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // If last 3 DropBoxes are ANY - (ANY-ANY-ANY)
            if(selectedPropType == "Any" && selectedTown == "Any" && selectedRooms == "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter=0;
                

                string sql = "Select * from property where Status='" +selectedStatus+ "' and Type='"+selectedType+"'";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average=0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // IF last 2 DropBoxes are ANY - (1-ANY-ANY)
            else if(selectedPropType != "Any" && selectedTown == "Any" && selectedRooms == "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and PropertyType='"+selectedPropType+"'; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // IF Last DropBox is ANY - (1-2-ANY)
            else if (selectedPropType != "Any" && selectedTown != "Any" && selectedRooms == "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and PropertyType='" + selectedPropType + "' and Town='"+selectedTown+"'; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();
                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // DropBoxes sequence - (1-2-3)
            else if (selectedPropType != "Any" && selectedTown != "Any" && selectedRooms != "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;
                int tempSelectedRooms = Convert.ToInt32(selectedRooms);

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and PropertyType='" + selectedPropType + "' and Town='" + selectedTown + "' and NoOfRooms = "+tempSelectedRooms+"; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if(double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    

                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // DropBoxes sequence - (1-Any-3)
            else if (selectedPropType != "Any" && selectedTown == "Any" && selectedRooms != "Any")
            {
                 dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;
                int tempSelectedRooms = Convert.ToInt32(selectedRooms);

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and PropertyType='" + selectedPropType + "' and NoOfRooms = "+tempSelectedRooms+"; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // DropBoxes sequence - (Any-2-3)
            else if (selectedPropType == "Any" && selectedTown != "Any" && selectedRooms != "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;
                int tempSelectedRooms = Convert.ToInt32(selectedRooms);

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and Town='" + selectedTown + "' and NoOfRooms = " + tempSelectedRooms + "; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
             // DropBoxes Sequence - (Any-2-Any)
            else if(selectedPropType == "Any" && selectedTown != "Any" && selectedRooms == "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter=0;
                

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and Town='" + selectedTown + "'; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
            // DropBoxes Sequence - (ANY-ANY-3)
            else if (selectedPropType == "Any" && selectedTown == "Any" && selectedRooms != "Any")
            {
                dataGridProps.Rows.Clear();
                db_connection();
                double totalPrices = 0;
                int counter = 0;
                int tempSelectedRooms = Convert.ToInt32(selectedRooms);

                string sql = "Select * from property where Status='" + selectedStatus + "' and Type='" + selectedType + "' and NoOfRooms = " + tempSelectedRooms + "; ";
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                try
                {

                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        counter++;
                        populate(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                        string tempPrice = row[6].ToString();
                        double tempPriceDub = Convert.ToDouble(tempPrice);
                        totalPrices = totalPrices + tempPriceDub;
                    }
                    connect.Close();

                    // Calculate Average Price
                    double average = 0;
                    average = totalPrices / counter;
                    average = Math.Round(average, 2);
                    if (double.IsNaN(average))
                    {
                        lblAverage.Text = "No Data For Specified Attributes";
                    }
                    else
                    {
                        lblAverage.Text = "Average Price For Specified Attributes: \t€" + average;
                    }
                    //clear dt
                    dt.Rows.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connect.Close();
                }
            }
        }
        
        // Get The options selected from ComboBoxes
        private void cBoxPropertyStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStatus = cBoxPropertyStatus.Text;
        }

        private void cBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = cBoxType.Text;
        }

        private void cBoxPropertyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPropType = cBoxPropertyType.Text;
        }

        private void cBoxTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTown = cBoxTown.Text;
        }

        private void cBoxNoOfRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRooms = cBoxNoOfRooms.Text;
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain fc = new frmMain();
            fc.Show();
            this.Close();
       }
    }  
}
