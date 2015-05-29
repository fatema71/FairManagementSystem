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
    public partial class VisitorEntryInformationUI : Form
    {
        ManagerZone objManagerZone = new ManagerZone();
        ManagerVisitor objManagerVisitor = new ManagerVisitor();
        Visitor objVisitor = new Visitor();
        Panel pnl = new Panel();
        public VisitorEntryInformationUI()
        {
            InitializeComponent();
        }

        private void VisitorEntryInformationUI_Load(object sender, EventArgs e)
        {
           // int btnPos = 1;
            
            pnl.AutoScroll = true;
            pnl.Top = 15;
            pnl.Left = 2;
            pnl.Width = groupBox2.Width - 8;
            pnl.Height = groupBox2.Height - 8;
            for (int i = 0; i <22; i++)
            {
                DataTable data = objManagerZone.ShowLIstViewItem();
                int j = 0;
                while (j < data.Rows.Count)
                {
                    CheckBox objCheckBox = new CheckBox();
                    objCheckBox.Width = groupBox2.Width - 100;
                    objCheckBox.Name = "chk" + data.Rows[j][0].ToString();
                    objCheckBox.Text = data.Rows[j][1].ToString();
                    objCheckBox.Top = (j + 1) * 20;
                    objCheckBox.Left = 50;
                    pnl.Controls.Add(objCheckBox);
                    j++;
                }
            }
            groupBox2.Controls.Add(pnl);
           
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "" || emailTextBox.Text == "" || contactNumberTextBox.Text == "")
            {
                MessageBox.Show("Please Fill all the input");
                return;
            }
            objVisitor.Name = nameTextBox.Text;
            objVisitor.Email = emailTextBox.Text;
            objVisitor.ContactNumber = contactNumberTextBox.Text;
            
            if (!objManagerVisitor.CheckEmail(objVisitor))
            {
                string status = objManagerVisitor.SaveVisitorInformation(objVisitor);
                string finalStatus = "";
                if (status == "saved")
                {
                    string visitorID = objManagerVisitor.GetVisitorID(objVisitor.Email);
                    foreach (CheckBox chk in pnl.Controls)
                    {
                        if (chk.Checked == true)
                        {
                            int zoneID = Convert.ToInt16(chk.Name.Replace("chk", ""));
                            finalStatus = objManagerVisitor.SaveZoneAccessInformation(visitorID, zoneID);

                        }

                    }
                    MessageBox.Show(finalStatus);
                }
            }
            else 
            {
                MessageBox.Show("Email already exist");
                return;
            }


        }
    }
}
