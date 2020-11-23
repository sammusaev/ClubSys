using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubSys
{
    public partial class NavBar : Form
    {
        public NavBar(string title)
        {
            InitializeComponent();
            lblPageTitle.Text = title;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            ParentForm.Hide();
        }

    }
}

