using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubSys
{
    public partial class AdminReports : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        //Constructor for list of clubnames
        public AdminReports(string type)
        {
            //passes a different value of the string query depending on whether the user had requested a list of clubs, or a list of updates
            InitializeComponent();
            string query;
            if (type == "clubs")
            {
                query = "SELECT ClubName, ClubPresident FROM CLUB";
            }
            else
            {
                query = "SELECT UpdateClub, UpdateDescription FROM UPDATES WHERE " +
                                    "UpdateDate >= DATEADD(day,-7, GETDATE())";
            }
            GenerateReport(query);
        }

        
        //function for generating report
        private void GenerateReport(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                lstReport.Items.Clear();
                while (dr.Read())
                {
                    lstReport.Items.Add(dr.GetString(0) + " - " + dr.GetString(1));
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error retrieving data from database");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //exports to a .txt file
        private void btnExport_Click(object sender, EventArgs e)
        {
            const string fileName = "report.txt";
            try
            {
                System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(fileName);
               
                foreach (var item in lstReport.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
                SaveFile.Close();
                MessageBox.Show("Exported successfully as " + fileName, "Exported");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Failed to export");
            }
        }
    }
}

