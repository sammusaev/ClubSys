using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubSys
{
    public partial class Login : Form
    {
        AdminHome frmAdmin = new AdminHome();
        
        StudentHome frmStudent = new StudentHome();

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Assign login input to variables
            string uname = txtUser.Text;
            string pass = txtPass.Text;

            //SQL connection & retrieval of login data
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();
                string query = "SELECT UserRole FROM USERS WHERE UserName = '" + uname + "' AND UserPassword = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                //If a match between username & password found
                if (dt.Rows.Count == 1)
                {
                    //retrieve userRole & redirect user
                    string userRole = cmd.ExecuteScalar().ToString();
                    if (userRole == "admin")
                        frmAdmin.Show();
                    else if (userRole == "rep")
                    {
                        RepHome frmRep = new RepHome(uname);
                        frmRep.Show();
                    }
                        
                    else
                        frmStudent.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed");
                con.Close();
            }
        }

        //To fix issue where debugging wouldnt end after closing form
        private void Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    }

