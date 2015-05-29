using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FairManagementApp.UI
{
    public partial class MainAreaUI : Form
    {
        public MainAreaUI()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryUI objZoneTypeEntryUI = new ZoneTypeEntryUI();
            objZoneTypeEntryUI.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryInformationUI objVisitorEntryInformationUI = new VisitorEntryInformationUI();
            objVisitorEntryInformationUI.Show();
        }

        private void zoneSpecificVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorNumberUI objZoneSpecificVisitorNumberUI = new ZoneSpecificVisitorNumberUI();
            objZoneSpecificVisitorNumberUI.Show();
        }

        private void zoneWiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberUI objZoneWiseVisitorNumberUI = new ZoneWiseVisitorNumberUI();
            objZoneWiseVisitorNumberUI.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
