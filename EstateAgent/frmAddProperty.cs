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
    public partial class frmAddProperty : Form
    {
        private int ownerID;


        public frmAddProperty()
        {
            InitializeComponent();
        }


        private void frmAddProperty_Load(object sender, EventArgs e)
        {
            Load_Table();
            string selectedIndex = dataGridOwners.SelectedRows[0].Cells[0].Value.ToString();
            ownerID = Convert.ToInt32(selectedIndex);
        }

        private void Load_Table()
        {
            string con = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            MySqlConnection conDataBase = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand("select * from estate.owner;", conDataBase);


            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                dataGridOwners.DataSource = bSource;
                sda.Update(dt);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
             frmProperty frm = new frmProperty();
            frm.Show();
            this.Close();
        
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string houseNo = txtHouseNum.Text.ToString();
            string address = txtAddress.Text.ToString();
            string town = txtTown.Text.ToString();
            string propertyType = comboBoxPropType.SelectedItem.ToString();
            string noOfRooms = txtNumRooms.Text.ToString();
            string price = txtPrice.Text.ToString();
            string type = comboBoxPropType.SelectedItem.ToString();


            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "insert into estate.property (HouseNo,Address,Town,PropertyType,NoOfRooms,Price,Type,ownerID) values ('" + houseNo + "','" + address + "','" + town + "','" + propertyType + "','" + noOfRooms + "','" + price + "','" + type + "'," + ownerID + ");";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been added successfully");
                while (myReadr.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void dataGridOwners_MouseClick_1(object sender, MouseEventArgs e)
        {
            //string selectedIndex = dataGridOwners.CurrentCell.RowIndex.ToString();
            string selectedIndex = dataGridOwners.SelectedRows[0].Cells[0].Value.ToString();
            ownerID = Convert.ToInt32(selectedIndex);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            frmClients fc = new frmClients();
            fc.Show();
            this.Close();
            Variables.Previous = "prop";
        }
        // Methods not used!!!--------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            //frmProperty frm = new frmProperty();
            //frm.Show();
            //this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string houseNo = txtHouseNum.Text.ToString();
            string address = txtAddress.Text.ToString();
            string town = txtTown.Text.ToString();
            string propertyType = comboBoxPropType.SelectedItem.ToString();
            string noOfRooms = txtNumRooms.Text.ToString();
            string price = txtPrice.Text.ToString();
            string type = comboBoxPropType.SelectedItem.ToString();


            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "insert into estate.property (HouseNo,Address,Town,PropertyType,NoOfRooms,Price,Type,ownerID) values ('" + houseNo + "','" + address + "','" + town + "','" + propertyType + "','" + noOfRooms + "','" + price + "','" + type + "'," + ownerID + ");";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been added successfully");
                while (myReadr.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridOwners_MouseClick(object sender, MouseEventArgs e)
        {
            //string selectedIndex = dataGridOwners.CurrentCell.RowIndex.ToString();
            string selectedIndex = dataGridOwners.SelectedRows[0].Cells[0].Value.ToString();
            ownerID = Convert.ToInt32(selectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        

        

       

    }
}