//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: ManageOffers
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
    public partial class ManageOffers : MetroFramework.Forms.MetroForm
    {
        public ManageOffers()
        {
            InitializeComponent();
        }

        private void ManageOffers_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddUsers addUser = new AddUsers();
            addUser.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;");

        private void Button10_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
            double price = Double.Parse(txtPrice.Text);

            if (txtOfferID.Text == "" || txtOfferName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill in the required fields.");
            }
            else
            {
                string qry = "Insert Into offers values('" + offerID + "','" + offerName + "','" + price + "')";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The data has been inserted.");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
            double price = Double.Parse(txtPrice.Text);

            if (txtOfferID.Text == "" || txtOfferName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill in the required fields.");
            }
            else
            {
                string qry = "Update offers Set price = '"+price+"' Where OfferID = '"+offerID+"' or OfferName = '"+offerName+"' ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The data has been inserted.");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int offerID = int.Parse(txtOfferID.Text);
            string offerName = txtOfferName.Text;
           
            if (txtOfferID.Text == "" || txtOfferName.Text == "" )
            {
                MessageBox.Show("Please fill in the required fields.");
            }
            else
            {
                string qry = "Delete * from offers Where OfferID = '"+offerID+"' or OfferName = '"+offerName+"' ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The data has been inserted.");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtOfferID.Text = null;
            txtOfferName.Text = null;
            txtPrice = null;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
