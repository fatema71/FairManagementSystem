using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FairManagementApp.BLL;
using FairManagementApp.Model;

namespace FairManagementApp.UI
{
    public partial class ZoneWiseVisitorNumberUI : Form
    {
        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
        }

        private void ZoneWiseVisitorNumberUI_Load(object sender, EventArgs e)
        {   
            ManagerZone objManagerZone = new ManagerZone();
          DataTable dt=objManagerZone.ShowLIstViewItem();
        int total = 0;
          int i = 0;
            if(dt.Rows.Count>0)
            {
                while (i < dt.Rows.Count)
                {
                    DataTable data = objManagerZone.GetVisitorNumber(Convert.ToInt16(dt.Rows[i][0]));
                    ListViewItem item = new ListViewItem(dt.Rows[i][1].ToString());
                    item.SubItems.Add(data.Rows[0][0].ToString());
                    zoneWiseNumberShowListView.Items.Add(item);
                    i++;
                    total = total + Convert.ToInt16(data.Rows[0][0]);
                }

            }
            totalTextBox.Text = total.ToString();

        }
    }
}
