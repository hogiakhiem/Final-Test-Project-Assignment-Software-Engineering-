//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: AddProducts
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Add_food : MetroFramework.Forms.MetroForm
    {
        public Add_food()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnManageFood_Click(object sender, EventArgs e)
        {
            Manage_Food mngFood = new Manage_Food();
            mngFood.Show();
            this.Hide();
        }

        private void Add_food_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            int foodID = int.Parse(txtFoodID.Text);
            string name = txtFoodName.Text;
            double price = double.Parse(txtPrice.Text);

            if (txtFoodID.Text == "" || txtFoodName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fillout required fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;");
                string qry = "Insert Into Food values('" + foodID + "','" + name + "','" + price + "')";
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
            txtFoodID.Text = null;
            txtFoodName.Text = null;
            txtPrice.Text = null;
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

        private void Btnuserdetails_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btnaddfood_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void Btnmanagefood_Click_1(object sender, EventArgs e)
        {
            Manage_Food mngFood = new Manage_Food();
            mngFood.Show();
            this.Hide();
        }

        private void Btnfooddetails_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void Btnmanageoffers_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void Btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btnofferdetails_Click(object sender, EventArgs e)
        {
            this.Show();
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
    }
}
