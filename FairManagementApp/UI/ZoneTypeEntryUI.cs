using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FairManagementApp.Model;
using FairManagementApp.BLL;

namespace FairManagementApp.UI
{
    public partial class ZoneTypeEntryUI : Form
    {
        public ZoneTypeEntryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Zone objZone = new Zone();
            ManagerZone objManagerZone = new ManagerZone();
            objZone.ZoneType = ZoneTypeTextBox.Text;
            if (ZoneTypeTextBox.Text != "")
            {
                if (!objManagerZone.CheckZoneType(objZone))
                {
                    string saveZone = objManagerZone.SaveZoneType(objZone);
                    MessageBox.Show(saveZone);
                    zoneTypeShowListView.Items.Clear();
                    DataTable data = objManagerZone.ShowLIstViewItem();

                    int i = 0;
                    while (i < data.Rows.Count)
                    {
                        ListViewItem item = new ListViewItem(data.Rows[i][1].ToString());
                        zoneTypeShowListView.Items.Add(item);
                        i++;
                    }
                }
                else
                {
                    MessageBox.Show("Zone Is Already Exist");
                    return;
                }
            }
            else
            {
                zoneTypeShowListView.Items.Clear();
                DataTable data = objManagerZone.ShowLIstViewItem();

                int i = 0;
                while (i < data.Rows.Count)
                {
                    ListViewItem item = new ListViewItem(data.Rows[i][1].ToString());
                    zoneTypeShowListView.Items.Add(item);
                    i++;
                }
            }
        }
    }
}
