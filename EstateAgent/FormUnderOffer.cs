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
    public partial class FormUnderOffer : Form
    {
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        MySqlCommand cmd;
        private string conn;
        private MySqlConnection connect;

        public FormUnderOffer()
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
        private void FormUnderOffer_Load(object sender, EventArgs e)
        {
            loadUnderOfferProps();
            
        }
        // Method used when offer is accepted that gets the amount and the propid
        // and updates the porperty with the price accepted and status to sold.
        // Also it deletes all the other offers that were made for that property
        private void offerAccepted(double priceSold, int propertyid)
        {
            db_connection();
            string sql = "UPDATE property SET property.price = " + priceSold + " ,property.Status = 'Sold' WHERE property.propertyid =" + propertyid + "";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = connect.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    
                    MessageBox.Show("Property Sold and Database Updated!");
                }
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }
        private void populateUnderOffer(string offerid, string amount, string buyerid, string propid)
        {
            dataGridUnderOffer.Rows.Add(offerid, amount, buyerid, propid);
        }
        private void loadUnderOfferProps()
        {
            dataGridUnderOffer.Rows.Clear();
            db_connection();

            string sql = "Select offer.offerid, offer.amountoffered, offer.buyerid, offer.propertyid from offer";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    populateUnderOffer(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString());
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

        private void changeOfferStatusToSold(int propertyid)
        {
            db_connection();
            string sql = "UPDATE offer SET offerAccepted = 'Sold' WHERE propertyid =" + propertyid + "";
            MySqlCommand cmd = new MySqlCommand(sql, connect);

            try
            {

                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = connect.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;

                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    
                    
                }
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        }

        private void deleteOffersForSoldProperty()
        {
            db_connection();
            string sql = "delete from offer where offer.offerAccepted='Sold'";
            cmd = new MySqlCommand(sql, connect);

            try
            {
                db_connection();

                adapter = new MySqlDataAdapter(cmd);

                adapter.DeleteCommand = connect.CreateCommand();

                adapter.DeleteCommand.CommandText = sql;

                
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        
                        
                    }
                
                connect.Close();


                connect.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            String selected = dataGridUnderOffer.SelectedRows[0].Cells[3].Value.ToString();
            int propertyid = Convert.ToInt32(selected);

            String amount = dataGridUnderOffer.SelectedRows[0].Cells[1].Value.ToString();
            double soldPrice = Convert.ToDouble(amount);

            offerAccepted(soldPrice, propertyid);

            changeOfferStatusToSold(propertyid);

            deleteOffersForSoldProperty();

            loadUnderOfferProps();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            formOffer fc = new formOffer();
            fc.Show();
            this.Close();
        }

        private void dataGridUnderOffer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
