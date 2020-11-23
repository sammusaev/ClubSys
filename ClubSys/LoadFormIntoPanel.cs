using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubSys
{
    class LoadFormIntoPanel
    {
        public static void load(Panel pnl, Form frm)
        {
            frm.TopLevel = false; ;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnl.Controls.Add(frm);
            pnl.Tag = frm;
            frm.BringToFront();
            frm.Show();
        }
    }
}
