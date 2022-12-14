//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: AdminDashboard
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

namespace FinalProject
{
    public partial class Admin_Dashboard : MetroFramework.Forms.MetroForm
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            AddUsers addUser = new AddUsers();
            addUser.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Add_food add_Food = new Add_food();
            add_Food.Show();
            this.Hide();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Manage_Food manage_Food = new Manage_Food();
            manage_Food.Show();
            this.Hide();
        }

        private void BtnFoodDetails_Click(object sender, EventArgs e)
        {
            Food_Details food_Details = new Food_Details();
            food_Details.Show();
            this.Hide();
        }

        private void BtnManageOffers_Click(object sender, EventArgs e)
        {
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void MetroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOfferDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
