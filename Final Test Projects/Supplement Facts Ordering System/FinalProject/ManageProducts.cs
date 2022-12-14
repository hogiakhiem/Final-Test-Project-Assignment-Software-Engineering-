//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: ManageProducts
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
    public partial class Manage_Food : MetroFramework.Forms.MetroForm
    {
        public Manage_Food()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnUserDetails_Click(object sender, EventArgs e)
        {

        }

        private void BtnAddFood_Click(object sender, EventArgs e)
        {

        }

        private void BtnManageFood_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;");
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

          
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;


        }
        
        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
        }

        private void Button6_Click(object sender, EventArgs e)
        {
        }

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            AddUsers addUser = new AddUsers();
            addUser.Show();
            this.Hide();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void Button6_Click_1(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

       
        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            int foodID = int.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            double price = double.Parse(txtPrice.Text);

            if (txtFoodName.Text == "" || txtFoodID.Text == null && !(txtPrice.Text == ""))
            {

                string qry = "Update Food Set price='" + price + "' where foodID='" + foodID + "' or Name='" + name + "'";
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
            else
            {
                MessageBox.Show("Please fill in the required fields.");
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            if (txtFoodID.Text == "")
            {
                MessageBox.Show("The product ID is missing.");
            }
            else
            {
                int foodID = int.Parse(txtFoodID.Text);
                string qry = "Delete from Food where FoodID = '" + foodID + "' ";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The data has been deleted.");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
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
