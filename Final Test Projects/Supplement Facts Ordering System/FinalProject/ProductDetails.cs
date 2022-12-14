//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: ProductDetails
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
    public partial class Food_Details : MetroFramework.Forms.MetroForm
    {
        public Food_Details()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {

        }

        private void DgvFoodDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtFoodID.Text = null;
            txtFoodName.Text = null;
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

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        string constring = @"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;";

        private void BtnShowAll_Click_1(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM Food ";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodDetails.DataSource = DS.Tables["Food"];
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int foodid = int.Parse(txtFoodID.Text);
            string foodname = txtFoodName.Text;
            string qry = "SELECT * FROM Food where foodID = '"+foodid+"' or Name = '"+foodname+"'";

            SqlDataAdapter DA = new SqlDataAdapter(qry, constring);
            DataSet DS = new DataSet();

            DA.Fill(DS, "Food");
            dgvFoodDetails.DataSource = DS.Tables["Food"];
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
    }
}
