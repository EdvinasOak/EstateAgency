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
    public partial class formOffer : Form
    {
        public formOffer()
        {
            InitializeComponent();
        }

        private void formOffer_Load(object sender, EventArgs e)
        {
            load_Table();
            load_buyers();
            load_prop();
            panel1.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtOffer.Text != "")
            {
                MessageBox.Show("Can't Save existing Offer!");

            }
            else
            {
                if (txtAmt.Text == "" || txtBuy.Text == "" || txtProp.Text == "")
                {
                    MessageBox.Show("All Details must be Filled!");
                }
                else
                {
                    int propInt = Convert.ToInt32(txtProp.Text);
                    decimal amtDec = Convert.ToDecimal(txtAmt.Text);
                    int buyerInt = Convert.ToInt32(txtBuy.Text);

                    Console.WriteLine(propInt + " " + amtDec + " " + buyerInt);

                    string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
                    string query = "insert into estate.offer (propertyID,AmountOffered,buyerID) values ( " + propInt + ", " + amtDec + ", " + buyerInt + ");";
                    string queryStatus = "update estate.property set Status = 'Under Offer' where propertyID= " + propInt + " ;";

                    MySqlConnection conDataBase = new MySqlConnection(constr);
                    MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                    MySqlDataReader myReadr;

                    try
                    {
                        conDataBase.Open();
                        myReadr = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Offer Saved");
                        while (myReadr.Read())
                        {
                        }
                        load_Table();
                        load_prop();
                        load_buyers();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MySqlConnection conDataBs = new MySqlConnection(constr);
                    MySqlCommand cmdDataBs = new MySqlCommand(queryStatus, conDataBs);
                    MySqlDataReader myReader;

                    try
                    {
                        conDataBs.Open();
                        myReader = cmdDataBs.ExecuteReader();
                        MessageBox.Show("Saved to Database");
                        while (myReader.Read())
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
           
            

            txtAmt.Text = "";
            txtBuy.Text = "";
            txtProp.Text = "";
        }

        void load_Table()
        {
            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand("select offerID,propertyID,buyerID,AmountOffered from estate.offer;", conDataBase);


            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if(txtOffer.Text == "")
            {
                MessageBox.Show("Select The Offer to Update!");
            }
            else
            {
                string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
                string query = "update estate.offer set propertyID='" + this.txtProp.Text + "',AmountOffered='" + this.txtAmt.Text + "',buyerID='" + this.txtBuy.Text + "'where offerID='" + this.txtOffer.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constr);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReadr;
                try
                {
                    conDataBase.Open();
                    myReadr = cmdDataBase.ExecuteReader();
                    MessageBox.Show("updated");
                    while (myReadr.Read())
                    {
                    }
                    load_buyers();
                    load_prop();
                    load_Table();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

            txtAmt.Text = "";
            txtBuy.Text = "";
            txtProp.Text = "";
            txtOffer.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain fc = new frmMain();
            fc.Show();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(txtOffer.Text == "")
            {
                MessageBox.Show("Select Offer to Delete!");
            }
            else
            {
                string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
                string query = "delete from estate.offer where offerID='" + this.txtOffer.Text + "';";
                MySqlConnection conDataBase = new MySqlConnection(constr);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReadr;
                try
                {
                    conDataBase.Open();
                    myReadr = cmdDataBase.ExecuteReader();
                    MessageBox.Show("deleted");
                    while (myReadr.Read())
                    {
                    }
                    conDataBase.Close();
                    load_buyers();
                    load_prop();
                    load_Table();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conDataBase.Close();
                }
            }
            
            txtAmt.Text = "";
            txtBuy.Text = "";
            txtProp.Text = "";
            txtOffer.Text = "";
        }

        void load_buyers()
        {
            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand("select buyerID, fName, lName, phoneNo from estate.buyer order by lName;", conDataBase);


            try
            {
                conDataBase.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }

        }

        void load_prop()
        {
            string constr = "datasource=localhost;Database=estate;Uid=root;Pwd=;";
            MySqlConnection conDataBase = new MySqlConnection(constr);
            MySqlCommand cmdDataBase = new MySqlCommand("select propertyID, HouseNo, Address, Town,PropertyType, Status from estate.property where property.status != 'Sold' order by HouseNo;", conDataBase);


            try
            {
                conDataBase.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView3.DataSource = bSource;
                sda.Update(dbdataset);


            }
            catch (Exception ef)
            {
                MessageBox.Show(ef.Message);
            }

        }

        private void btnUnderOffr_Click(object sender, EventArgs e)
        {
            FormUnderOffer of = new FormUnderOffer();
            of.Show();
            this.Close();
        }

        private void txtOffer_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            txtOffer.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtProp.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtBuy.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtAmt.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            panel1.Hide();
            
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            txtOffer.Text = "";
            txtBuy.Text = "";
            txtAmt.Text = "";
            txtProp.Text = "";
            
            txtBuy.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            panel1.Show();
        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            txtAmt.Text = "";
            txtOffer.Text = "";
            txtProp.Text = "";
            
            if(txtBuy.Text==null)
            {
                MessageBox.Show("Please Select a Buyer First!");
            }
            
            txtProp.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }





    }
}
