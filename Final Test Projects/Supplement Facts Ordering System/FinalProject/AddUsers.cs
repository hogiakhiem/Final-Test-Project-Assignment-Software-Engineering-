//
// Name: Ho Gia Khiem
// Student ID: 520K0341
// Final Test Project (Software Engineering)
// Project theme: Supplement Facts Ordering System
// Filename: AddUsers
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
    public partial class AddUsers : MetroFramework.Forms.MetroForm
    {
        string ValueOfCombo;
        public AddUsers()
        {
            InitializeComponent();
        }



        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string nic = txtNIC.Text,
                   name = txtName.Text,
                   username = txtUname.Text,
                   email = txtEmail.Text,
                   password = txtPassword.Text,
                   confirmPassword = txtConfirmPassword.Text;

            
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            int phoneNumber = int.Parse(txtPhoneNumber.Text);
          
            if (txtNIC.Text == "" || txtName.Text == "" || txtUname.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "" || ValueOfCombo == null)
            {
                MessageBox.Show("Please fill in the required fields.");
            }
            else
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    
                    string qry = "Insert Into userdetails Values('" + nic+"','"+name+"','"+username+"','"+email+"','"+password+"','"+confirmPassword+"','"+age+"','"+address+"','"+phoneNumber+ "','" + ValueOfCombo + "')";
                    

                    try
                    {
                        
                        MessageBox.Show("The data has been inserted.");
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show("" + sqlex);
                    }
                }
                else
                {
                    MessageBox.Show("The passwords don't match.");
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Manage_Users manage_Users = new Manage_Users();
            manage_Users.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddUsers addUser = new AddUsers();
            addUser.Show();
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
            ManageOffers manageOffers = new ManageOffers();
            manageOffers.Show();
            this.Hide();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            txtNIC.Text = null;
            txtName.Text = null;
            txtUname.Text = null;
            txtEmail.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
            txtAge.Text = null;
            txtAddress.Text = null;
            txtPhoneNumber.Text = null;
        }


        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
           ValueOfCombo = cmbType.Text;
        }
    }
}
