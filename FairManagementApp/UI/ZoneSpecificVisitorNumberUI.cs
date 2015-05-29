using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FairManagementApp.BLL;

namespace FairManagementApp.UI
{
    public partial class ZoneSpecificVisitorNumberUI : Form
    {
        ManagerZone objManagerZone = new ManagerZone();
        public ZoneSpecificVisitorNumberUI()
        {
            InitializeComponent();
        }

        private void ZoneSpecificVisitorNumberUI_Load(object sender, EventArgs e)
        {
            DataTable dt = objManagerZone.ShowLIstViewItem();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Zone_Type";
            comboBox1.ValueMember = "ID";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            detailShowListView.Items.Clear();
            string value = comboBox1.SelectedValue.ToString();
            DataTable dt = objManagerZone.GetZoneMember();
            int total = 0;
            int i = 0;
            if (dt.Rows.Count > 0)
            {
                while (i < dt.Rows.Count)
                {
                    if (dt.Rows[i][0].ToString() == value)
                    {
                        ListViewItem item = new ListViewItem(dt.Rows[i][2].ToString());
                        item.SubItems.Add(dt.Rows[i][3].ToString());
                        item.SubItems.Add(dt.Rows[i][4].ToString());
                        detailShowListView.Items.Add(item);
                        total++;
                    }
                    i++;
                }

            }
            totalTextBox.Text = total.ToString();

        }

        private void extractToExcelButton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            int i = 1;
            int i2 = 1;
            foreach (ListViewItem lvi in detailShowListView.Items)
            {
                i = 1;
                foreach (ListViewItem.ListViewSubItem lvs in lvi.SubItems)
                {
                    ws.Cells[i2, i] = lvs.Text;
                    i++;
                }
                i2++;
            }
        }
      
    }
}

