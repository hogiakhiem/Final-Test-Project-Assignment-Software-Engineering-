//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: ManageUsers
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
    public partial class Manage_Users : MetroFramework.Forms.MetroForm
    {
        public Manage_Users()
        {
            InitializeComponent();
        }

        private void Manage_Users_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-5S178792; Initial Calatog = FinalProject; Integrated Security = True;");

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            string nic = txtNIC.Text,
                   name = txtName.Text,
                   username = txtUname.Text,
                   email = txtEmail.Text,
                   password = txtPassword.Text,
                   confirmPassword = txtConfirmPassword.Text;
            
            string address = txtAddress.Text;
            int phoneNumber = int.Parse(txtPhoneNumber.Text);

            if (txtNIC.Text == "" && txtPhoneNumber.Text == "")
            {
                MessageBox.Show("The NIC or phone number is missing.");
            }
            else
            {
                string qry = "Update userdetails Set Name='" + name + "' Uname = '"+username+"' Email = '"+email+"' Password = '"+password+"' ConfirmPassword = '"+confirmPassword+"' Address = '"+address+"' PhoneNumber = '"+phoneNumber+"' where NIC ='" + nic + "' or PhoneNumber='" + phoneNumber + "'";
                SqlCommand cmd = new SqlCommand(qry,con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The data has been updated.");
                }
                catch (SqlException sqlex)
                {
                    MessageBox.Show("" + sqlex);
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text;

            string qry = "Delete * from userdetails Where NIC = '" + nic+"' ";
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtNIC.Text = null;
            txtName.Text = null;
            txtUname.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtAge.Text = null;
            txtAddress.Text = null;
            txtPhoneNumber = null;
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
    }
}
