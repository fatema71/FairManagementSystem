namespace FairManagementApp.UI
{
    partial class ZoneTypeEntryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneTypeShowListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.ZoneTypeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.ZoneTypeTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone type";
            // 
            // zoneTypeShowListView
            // 
            this.zoneTypeShowListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.zoneTypeShowListView.GridLines = true;
            this.zoneTypeShowListView.Location = new System.Drawing.Point(21, 107);
            this.zoneTypeShowListView.Name = "zoneTypeShowListView";
            this.zoneTypeShowListView.Size = new System.Drawing.Size(430, 270);
            this.zoneTypeShowListView.TabIndex = 1;
            this.zoneTypeShowListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeShowListView.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zone Type";
            // 
            // ZoneTypeTextBox
            // 
            this.ZoneTypeTextBox.Location = new System.Drawing.Point(101, 16);
            this.ZoneTypeTextBox.Name = "ZoneTypeTextBox";
            this.ZoneTypeTextBox.Size = new System.Drawing.Size(228, 20);
            this.ZoneTypeTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(254, 48);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Type";
            this.columnHeader1.Width = 384;
            // 
            // ZoneTypeEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 389);
            this.Controls.Add(this.zoneTypeShowListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneTypeEntryUI";
            this.Text = "Zone Type Entry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox ZoneTypeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView zoneTypeShowListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}