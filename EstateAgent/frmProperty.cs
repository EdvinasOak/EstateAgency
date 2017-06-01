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
    public partial class frmProperty : Form
    {
        private int pID;

        public frmProperty()
        {
            InitializeComponent();

        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            Load_Table();
        }


        private void Load_Table()
        {
            string con = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            MySqlConnection conDataBase = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand("select propertyID,HouseNo,Address,Town,Price,Status from estate.property order by Town;", conDataBase);


            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dt;
                dataGridView1.DataSource = bSource;
                sda.Update(dt);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "delete from estate.property where propertyID = " + pID + ";";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been deleted successfully");
                while (myReadr.Read())
                {
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load_Table();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddProperty frm = new frmAddProperty();
            frm.Show();
            this.Hide();
        }
        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            string selectedIndex = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pID = Convert.ToInt32(selectedIndex);
        }
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Select a property from the list of properties you want to update");

            Decimal price = Convert.ToDecimal(txtPrice.Text);

            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "UPDATE property set HouseNo = '" + txtHouseNum.Text + "',Address = '" + txtAddress.Text + "',Town='" + txtTown.Text + "',price='" + price + "' where propertyID =" + pID + "";

            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been successfully updated.");
                while (myReadr.Read())
                {
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Table();
            txtHouseNum.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtPrice.Text = "";
        }
        private void dataGridView1_Click_1(object sender, EventArgs e)
        {
            txtHouseNum.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTown.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        // Methods That dont work But cant remove ------------------------------------------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddProperty frm = new frmAddProperty();
            frm.Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "delete from estate.property where propertyID = " + pID + ";";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been deleted successfully");
                while (myReadr.Read())
                {
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Load_Table();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            string selectedIndex = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pID = Convert.ToInt32(selectedIndex);
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Select a property from the list of properties you want to update");

            Decimal price = Convert.ToDecimal(txtPrice.Text);

            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            string query = "UPDATE property set HouseNo = '" + txtHouseNum.Text + "',Address = '" + txtAddress.Text + "',Town='" + txtTown.Text + "',price='" + price + "' where propertyID =" + pID + "";

            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReadr;
            try
            {
                conDataBase.Open();
                myReadr = cmdDataBase.ExecuteReader();
                MessageBox.Show("Property has been successfully updated.");
                while (myReadr.Read())
                {
                }
                conDataBase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Load_Table();
            txtHouseNum.Text = "";
            txtAddress.Text = "";
            txtTown.Text = "";
            txtPrice.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtHouseNum.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTown.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        

       

       

       


    }
}
