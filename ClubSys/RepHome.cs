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
    public partial class RepHome : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public RepHome(string user)
        {
            InitializeComponent();
            NavBar frmNavBar = new NavBar("Representative");
            LoadFormIntoPanel.load(pnlNav, frmNavBar);

            string queryShowClubInfo = "SELECT ClubName, ClubDescription, ClubPresident, ClubVice, ClubSecretary, ClubSecretaryID, ClubEstablished FROM CLUB" +
                " WHERE ClubSecretaryID='" + user + "'";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(queryShowClubInfo, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lblClubName.Text = (dr["ClubName"].ToString());
                    txtClubDescription.Text = (dr["ClubDescription"].ToString());
                    lblPresident.Text = (dr["ClubPresident"].ToString()); 
                    lblVice.Text = (dr["ClubVice"].ToString());
                    lblSecretary.Text = (dr["ClubSecretary"].ToString());
                    lblEstablished.Text = (dr["ClubEstablished"].ToString());
                }
                con.Close();
                ShowPastUpdates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Failed to retrieve club data");
            }
        }

        //To fix issue where debugging wouldnt end after closing form
        private void RepHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateDescription_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand updateDescription = new SqlCommand("UPDATE CLUB SET ClubDescription = '" + txtClubDescription.Text + "' WHERE ClubName = '" + lblClubName.Text + "'", con);
            updateDescription.ExecuteNonQuery();
            con.Close();
        }

        private void btnPostUpdate_Click(object sender, EventArgs e)
        {
            DateTime myDateTime = DateTime.Now;
            string currentDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
            con.Open();
            SqlCommand cmdPostUpdate = new SqlCommand("INSERT INTO UPDATES (UpdateClub, UpdateDate, UpdateDescription) VALUES (@Club, @Date, @Description)", con);
            cmdPostUpdate.Parameters.AddWithValue("@Club", lblClubName.Text);
            cmdPostUpdate.Parameters.AddWithValue("@Date", currentDate);
            cmdPostUpdate.Parameters.AddWithValue("@Description", txtUpdate.Text);
            cmdPostUpdate.ExecuteNonQuery();
            con.Close();
            pnlRight.Refresh();
            ShowPastUpdates();
        }

        private void ShowPastUpdates()
        {
            try
            {
                string query = "SELECT UpdateDescription, UpdateDate FROM UPDATES WHERE UpdateClub = '" + lblClubName.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                lstUpdates.Items.Clear();
                while (dr.Read())
                {
                    lstUpdates.Items.Add(dr["UpdateDate"].ToString() + " - " + dr.GetString(0));
                }
                con.Close();
            }
            //any exception errors then will showing it in the MessageBox. 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error retrieving data from database");
            }
        }
    }
}
