using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubSys
{
    public partial class AdminAddEdit : Form
    {
        AdminHome frmAdminHome = new AdminHome();

        //Used to differentiate between Creating new club & Editing an existing one
        bool addingClub;
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor for Creating New Club
        public AdminAddEdit()
        {
            InitializeComponent();
            addingClub = true;
            btnCreateUpdate.Text = "Create New Club";
            frmAdminHome.lblSubPageTitle.Text = "Create New Club";
            txtClubName.Enabled = true;
        }

        //Constructor for Editing Existing Club
        public AdminAddEdit(string clubName)
        {
            InitializeComponent();
            addingClub = false;
            btnCreateUpdate.Text = "Update Club Info";
            frmAdminHome.lblSubPageTitle.Text = "Edit Info For " +clubName;
            try
            {
                con.Open();
                SqlCommand cmdFetch = new SqlCommand("SELECT ClubDescription, ClubPresident, ClubVice, ClubSecretary, ClubSecretaryID, ClubEstablished FROM CLUB " +
                    "WHERE ClubName='" + clubName + "'", con);
                SqlDataReader dr = cmdFetch.ExecuteReader();
                

                //Displays SQL Data in Textboxes
                while (dr.Read())
                {
                    txtClubName.Text = clubName;
                    txtClubDescription.Text = (dr["ClubDescription"].ToString());
                    txtClubPresident.Text = (dr["ClubPresident"].ToString());
                    txtClubVice.Text = (dr["ClubVice"].ToString());
                    txtClubSecretary.Text = (dr["ClubSecretary"].ToString());
                    txtClubSecretaryID.Text = (dr["ClubSecretaryID"].ToString());
                    dtpClubEstablished.Text = (dr["ClubEstablished"].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to retrieve data", ex.Message);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            //Function for adding a new club
            if (addingClub)
            {
                try
                {
                    DateTime myDateTime = dtpClubEstablished.Value;
                    string clubEstablished = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    Club newObj = new Club(txtClubName.Text, txtClubDescription.Text, txtClubPresident.Text, txtClubVice.Text, txtClubSecretary.Text, txtClubSecretaryID.Text, clubEstablished);
                    int nameExists = checkDuplicateName(newObj.ClubName);
                    if (nameExists==1)
                    {
                        MessageBox.Show(newObj.ClubName+" already exists! Choose a different name", "Error: Duplicate ClubName");
                    }
                    else if (nameExists==0)
                    {
                        con.Open();
                        SqlCommand cmdRego = new SqlCommand("INSERT INTO CLUB (ClubName, ClubDescription, ClubPresident, ClubVice, ClubSecretary, ClubSecretaryID, ClubEstablished, ClubStatus) VALUES" +
                            "(@ClubName, @ClubDescription, @ClubPresident, @ClubVice, @ClubSecretary, @ClubSecretaryID, @ClubDateEstablished, 1)", con);
                        cmdRego.Parameters.AddWithValue("@ClubName", newObj.ClubName);
                        cmdRego.Parameters.AddWithValue("@ClubDescription", newObj.ClubDescription);
                        cmdRego.Parameters.AddWithValue("@ClubPresident", newObj.ClubPresident);
                        cmdRego.Parameters.AddWithValue("@ClubVice", newObj.ClubVice);
                        cmdRego.Parameters.AddWithValue("@ClubSecretary", newObj.ClubSecretary);
                        cmdRego.Parameters.AddWithValue("@ClubSecretaryID", newObj.ClubSecretaryID);
                        cmdRego.Parameters.AddWithValue("@ClubDateEstablished", newObj.ClubEstablished);
                        cmdRego.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Done!", "Registration Success");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Unable to verify if name is duplicate", "Unexpected Error");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Registration Failed.",ex.Message);
                    this.Close();
                }
            }

            //Function for editing existing club
            else
            {
                try
                {
                    Club updateObj = new Club(txtClubName.Text, txtClubDescription.Text, txtClubPresident.Text, 
                        txtClubVice.Text, txtClubSecretary.Text, txtClubSecretaryID.Text);
                    con.Open();
                    SqlCommand cmdUpdate = new SqlCommand("UPDATE CLUB SET ClubName=@ClubName, ClubDescription=@ClubDescription, " +
                        "ClubPresident=@ClubPresident, ClubVice=@ClubVice," +
                        "ClubSecretary=@ClubSecretary, ClubSecretaryID=@ClubSecretaryID, ClubEstablished=@ClubEstablished, " +
                        "ClubStatus=1 WHERE ClubName='" + updateObj.ClubName + "'", con);
                    cmdUpdate.Parameters.AddWithValue("@ClubName", updateObj.ClubName);
                    cmdUpdate.Parameters.AddWithValue("@ClubDescription", updateObj.ClubDescription);
                    cmdUpdate.Parameters.AddWithValue("@ClubPresident", updateObj.ClubPresident);
                    cmdUpdate.Parameters.AddWithValue("@ClubVice", updateObj.ClubVice);
                    cmdUpdate.Parameters.AddWithValue("@ClubSecretary", updateObj.ClubSecretary);
                    cmdUpdate.Parameters.AddWithValue("@ClubSecretaryID", updateObj.ClubSecretaryID);
                    cmdUpdate.Parameters.AddWithValue("@ClubEstablished", dtpClubEstablished.Value.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    cmdUpdate.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Done!", "Update Success");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update Failed.", ex.Message);
                    this.Close();
                }
            }
        }
        private int checkDuplicateName(string clubName)
        {
            string query = "SELECT COUNT(*) FROM CLUB WHERE ClubName='" + clubName + "'";
            con.Open();
            SqlCommand cmdDuplicateCheck = new SqlCommand(query, con);
            int result = Convert.ToInt32(cmdDuplicateCheck.ExecuteScalar());
            con.Close();
            return result;
        }
    }
}