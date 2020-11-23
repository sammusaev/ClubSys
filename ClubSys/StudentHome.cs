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
    public partial class StudentHome : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public StudentHome()
        {
            InitializeComponent();
            NavBar frmNavBar = new NavBar("Student");
            LoadFormIntoPanel.load(pnlNav, frmNavBar);
            PopulateListbox("SELECT ClubName FROM CLUB WHERE ClubStatus=1");
            dynamicPanel.Visible = false;
            //retrieve clubnames & show them inside list box
        }

        //To fix issue where debugging wouldnt end after closing form
        private void StudentHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ShowClubInfo(lstClubs.SelectedItem.ToString());
        }

        private void ShowClubInfo(string clubName)
        {
            con.Open();
            SqlCommand cmdClub = new SqlCommand("SELECT ClubDescription, ClubPresident, ClubVice, ClubSecretary, ClubEstablished FROM CLUB " +
                "WHERE ClubName='" + clubName + "'", con);
            SqlDataReader dr = cmdClub.ExecuteReader();
            //This function contains the SQL data and when the Student clicks to the ViewClub button it will pass the selected Item from list box to a label
            while (dr.Read())
            {
                lblClubName.Text = clubName;
                lblClubDescription.Text = (dr["ClubDescription"].ToString());
                lblClubPresident.Text = (dr["ClubPresident"].ToString());
                lblClubVicePresident.Text = (dr["ClubVice"].ToString());
                lblClubSecretary.Text = (dr["ClubSecretary"].ToString());
                lblClubEstablished.Text = (dr["ClubEstablished"].ToString());
            }
            con.Close();
            dynamicPanel.Visible = true;
        }
        //For load a list of the clubs from SQL 
        private void PopulateListbox(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                lstClubs.Items.Clear();
                while (dr.Read())
                {
                    lstClubs.Items.Add(dr.GetString(0));
                }
                con.Close();
            }
            //any exception errors then will showing it in the MessageBox. 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error retrieving data from database");
            }
        }
        //Searching through listClubs for getting the Club names
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                for (int i = lstClubs.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstClubs.Items[i];
                    if (item.ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        //Nothing
                    }
                    else
                    {
                        lstClubs.Items.Remove(item);
                    }
                }
            }
            //If the textbox is blank, show the clubs
            else
            {
                PopulateListbox("SELECT ClubName FROM CLUB");
            }
        }
    }

}