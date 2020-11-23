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
    public partial class AdminHome : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        //Two string queries that retrieve active & archived clubs respectively
        public string activeClubs = "SELECT * FROM CLUB WHERE ClubStatus=1";
        public string archivedClubs = "SELECT * FROM CLUB WHERE ClubStatus=0";
        //Boolean used to separate archive/unarchive functions
        bool showingActive;

        //Constuctor loads navbar
        public AdminHome()
        {
            InitializeComponent();
            NavBar frmNavBar = new NavBar("Administrator");
            LoadFormIntoPanel.load(pnlNav, frmNavBar);
        }

        //To fix issue where debugging wouldnt end after closing form
        private void AdminHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //Initial state of the form
        private void AdminHome_Shown(object sender, EventArgs e)
        {
            pnlAdminFunctions.Show();
            DisplayClubs(activeClubs);
            lblSubPageTitle.Text = "Active Clubs";
            btnClubType.Text = "Show Archive";
            btnUnarchive.Visible = false;
            showingActive = true;
        }

        //Button click to request a display of archived/unarchived clubs
        private void btnTest_Click(object sender, EventArgs e)
        {
            if (showingActive)
            {
                DisplayClubs(archivedClubs);
                pnlAdminFunctions.Hide();
                btnClubType.Text = "Show Active";
                showingActive = false;
                lblSubPageTitle.Text = "Archived Clubs";
                btnUnarchive.Visible = true;
            }
            else
            {
                DisplayClubs(activeClubs);
                pnlAdminFunctions.Show();
                btnClubType.Text = "Show Archive";
                showingActive = true;
                lblSubPageTitle.Text = "Active Clubs";
                btnUnarchive.Visible = false;
            }
        }

        //Function that displays active or archived clubs, depending on argument
        public void DisplayClubs(string typeOfClub)
        {
            SqlCommand cmd = new SqlCommand(typeOfClub, con);

            try
            {
                lstClubs.Items.Clear();
                lstClubs.Visible = false;
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem item = new ListViewItem(dr["ClubName"].ToString());
                    item.SubItems.Add(dr["ClubDescription"].ToString());
                    item.SubItems.Add(dr["ClubPresident"].ToString());
                    item.SubItems.Add(dr["ClubVice"].ToString());
                    item.SubItems.Add(dr["ClubSecretary"].ToString());
                    item.SubItems.Add(dr["ClubEstablished"].ToString());

                    lstClubs.Items.Add(item);
                }
                con.Close();
                lstClubs.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnAddClub_Click(object sender, EventArgs e)
        {
            AdminAddEdit frmAddClub = new AdminAddEdit();
            LoadFormIntoPanel.load(pnlContainer, frmAddClub);
            //lblSubPageTitle.Text = "Add New Club";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                AdminAddEdit frmEditClub = new AdminAddEdit(lstClubs.SelectedItems[0].Text);
                LoadFormIntoPanel.load(pnlContainer, frmEditClub);
                //lblSubPageTitle.Text = "Edit Club";
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Please select a club to edit", ex.Message);
            }
        }

        //Searching through listview
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                for (int i = lstClubs.Items.Count - 1; i >= 0; i--)
                {
                    var item = lstClubs.Items[i];
                    //Searches through Club names & 4 SubItems(Description & Committee Members)
                    if (item.Text.ToLower().Contains(txtSearch.Text.ToLower()) ||
                        item.SubItems[1].Text.ToLower().Contains(txtSearch.Text.ToLower())||
                        item.SubItems[2].Text.ToLower().Contains(txtSearch.Text.ToLower())||
                        item.SubItems[3].Text.ToLower().Contains(txtSearch.Text.ToLower())||
                        item.SubItems[4].Text.ToLower().Contains(txtSearch.Text.ToLower()))
                    {
                        //Nothing needs to happen here, row containing the text will remain shown
                    }
                    else
                    {
                        //Remove row where no match is found
                        lstClubs.Items.Remove(item);
                    }
                }
            }
            //If the textbox is blank, show the clubs
            else
            {
                if (showingActive)
                    DisplayClubs(activeClubs);
                else
                    DisplayClubs(archivedClubs);
            }
        }

        //Button click event to Archive Club
        private void btnArchiveClub_Click(object sender, EventArgs e)
        {
            try
            {
                //Loads function depending with selected row as argument
                ArchiveUnarchiveClub(lstClubs.SelectedItems[0].Text,0);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please select a club to archive", ex.Message);
            }
        }

        //Button click event to Unarchive Club
        private void btnUnarchive_Click(object sender, EventArgs e)
        {
            try
            {
                ArchiveUnarchiveClub(lstClubs.SelectedItems[0].Text, 1);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please select a club to unarchive", ex.Message);
            }
        }

        //Function for Archiving/Unarchiving Selected Club. 
        //Takes two arguments; the name of the club, and whether to change the status to 0 or 1
        private void ArchiveUnarchiveClub(string club, int changeTo)
        {
            //Query that takes care of changing clubstatus to 0 or 1 
            string archiveClub = "UPDATE CLUB SET ClubStatus="+changeTo+"WHERE ClubName='"+club+"'";
            DialogResult res = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            //confirmation of change
            if (res == DialogResult.OK)
            {
                con.Open();
                SqlCommand archiveCmd = new SqlCommand(archiveClub, con);
                archiveCmd.ExecuteScalar();
                con.Close();

                //refreshes the table depending on where user is
                if (changeTo.Equals(1))
                {
                    DisplayClubs(archivedClubs);
                }
                else
                {
                    DisplayClubs(activeClubs);
                }
            }
        }

        //Refresh picturebox click handler
        private void picRefresh_Click(object sender, EventArgs e)
        {
            if (showingActive)
                DisplayClubs(activeClubs);
            else
                DisplayClubs(archivedClubs);
        }

        private void btnGenClubList_Click(object sender, EventArgs e)
        {
            AdminReports frmReports = new AdminReports("clubs");
            LoadFormIntoPanel.load(pnlContainer, frmReports);
        }

        private void btnGenActivityList_Click(object sender, EventArgs e)
        {
            AdminReports frmReports = new AdminReports("updates");
            LoadFormIntoPanel.load(pnlContainer, frmReports);
        }
    }
}
