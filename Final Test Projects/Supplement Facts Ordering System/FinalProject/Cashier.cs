//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: Cashier
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class Cashier : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        
        public Cashier()
        {
            InitializeComponent();
            dt = new DataTable("OrderTable");
            
            dt.Columns.Add("ID");
            
            dt.Columns.Add("Name");
            
            dt.Columns.Add("Quantity");
            
            dt.Columns.Add("Price");
            


        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {

        }
        string constring = @"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;";

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM Food ";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodGrid.DataSource = DS.Tables["Food"];
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {

            string foodid = txtFoodCodeC.Text;
            string foodname = txtFoodNameC.Text;
           
            string qry = "SELECT * FROM Food where foodID = '" + foodid + "' or Name = '" + foodname + "'";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodGrid.DataSource = DS.Tables["Food"];
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                DataRow rw = dt.NewRow();

                string itemid = txtItemCode.Text;
                int Quantity = int.Parse(txtQuantity.Text);

                string qry = "SELECT * FROM Food where foodID = '" + itemid + "'";

                SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
                DataSet DS = new DataSet();

                DA.Fill(DS, "Food");
                rw["ID"] = itemid;
                rw["Quantity"] = Quantity.ToString();
                rw["Name"] = DS.Tables["Food"].Rows[0]["Name"];
                rw["Price"] = (Quantity * int.Parse(DS.Tables["Food"].Rows[0]["Price"].ToString())).ToString();

                dt.Rows.Add(rw);

                dgvBasket1.DataSource = dt;

                txtQuantity.Text = null;
                txtItemCode.Text = null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
            }
                

        }

        private void TxtItemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroTile2_Click(object sender, EventArgs e)
        {
            string itemid = txtItemCode.Text;
            DataRow rw = dt.NewRow();

            dt.AcceptChanges();
            
            {
                foreach (DataRow row in dt.Rows)
                {
                    string id = row[0].ToString();
                    if (id == itemid )
                    {
                        row.Delete();
                    }
                }
  
            }
            dt.AcceptChanges();
        }
                 

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtFoodNameC_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM offers ";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "offers");
            dgvOffers.DataSource = DS.Tables["offers"];
        }

        private void MetroTile1_Click_1(object sender, EventArgs e)
        {
            try
            {

                DataRow rw1 = dt.NewRow();

                string offerid = txtOfferId.Text;
                int Quantity = 1; 

                string qry = "SELECT * FROM offers where OfferId = '" + offerid + "'";

                SqlDataAdapter DA1 = new SqlDataAdapter(qry, constring);
                DataSet DS1 = new DataSet();

                DA1.Fill(DS1, "offers");


                rw1["ID"] = offerid;
                rw1["Quantity"] = Quantity;
                rw1["Name"] = DS1.Tables["offers"].Rows[0]["OfferName"];
                rw1["Price"] = (Quantity * int.Parse(DS1.Tables["offers"].Rows[0]["Price"].ToString())).ToString();

                 

                dt.Rows.Add(rw1);

                dgvBasket1.DataSource = dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show("" + ex);
            }
            txtOfferId.Text = null;
        }

        private void MetroTile4_Click(object sender, EventArgs e)
        {
            if(!(txtPayment.Text == ""))
            {
                
                double discount = double.Parse(txtDiscount.Text);
                double payment = double.Parse(txtPayment.Text);

                dgvBasket1.AllowUserToAddRows = false;
                lblSubTotal.Text = "0";
                for (int i = 0; i < dgvBasket1.Rows.Count; i++)
                {
                    lblSubTotal.Text = Convert.ToString(double.Parse(lblSubTotal.Text) + double.Parse(dgvBasket1.Rows[i].Cells[3].Value.ToString()));
                }

                lblDiscount.Text = discount.ToString();
                lblBalance.Text = (payment - double.Parse(lblSubTotal.Text)).ToString();
                lblTotal.Text = (double.Parse(lblSubTotal.Text) - discount).ToString();
            }
            else
            {
                MessageBox.Show("Please enter the payment information.");

            }


        }

        private void MetroTile5_Click(object sender, EventArgs e)
        {
            lblBalance.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblSubTotal.Text = "0.00";
            lblTotal.Text = "0.00";
            txtPayment.Text = null;
            txtDiscount.Text = "0";
            dgvBasket1.DataSource = null;
            dgvBasket1.Rows.Clear();
            dgvBasket1.Refresh();
        }

        private void DgvOffers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MetroTile3_Click(object sender, EventArgs e)
        {
            string offerid = txtOfferId.Text;
            DataRow rw = dt.NewRow();

            dt.AcceptChanges();

            {
                foreach (DataRow row in dt.Rows)
                {
                    string id = row[0].ToString();
                    if (id == offerid)
                    {
                        row.Delete();
                    }
                }

            }
            dt.AcceptChanges();
        }
        
    
    }
}
