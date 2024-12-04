﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ISDS454_IMS_Forms
{
    public partial class ViewLastUpdatesForm : Form
    {

        DisplayLogInformation logInfo = new DisplayLogInformation();
        public ViewLastUpdatesForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ViewLogInformationDataTable.DataSource = logInfo.getLogInformation();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            ViewLastUpdatesLabel = new Label();
            ViewLogInformationDataTable = new DataGridView();
            ViewLastUpdatesCancelButton = new Button();
            ((ISupportInitialize)ViewLogInformationDataTable).BeginInit();
            SuspendLayout();
            // 
            // ViewLastUpdatesLabel
            // 
            ViewLastUpdatesLabel.AutoSize = true;
            ViewLastUpdatesLabel.Location = new Point(371, 9);
            ViewLastUpdatesLabel.Name = "ViewLastUpdatesLabel";
            ViewLastUpdatesLabel.Size = new Size(388, 54);
            ViewLastUpdatesLabel.TabIndex = 0;
            ViewLastUpdatesLabel.Text = "View: Last Updated";
            ViewLastUpdatesLabel.Click += label1_Click;
            // 
            // ViewLogInformationDataTable
            // 
            ViewLogInformationDataTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ViewLogInformationDataTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ViewLogInformationDataTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = SystemColors.Control;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.True;
            ViewLogInformationDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            ViewLogInformationDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ViewLogInformationDataTable.Location = new Point(14, 232);
            ViewLogInformationDataTable.Name = "ViewLogInformationDataTable";
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = SystemColors.Control;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            ViewLogInformationDataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            ViewLogInformationDataTable.RowHeadersWidth = 51;
            ViewLogInformationDataTable.Size = new Size(1118, 489);
            ViewLogInformationDataTable.TabIndex = 10;
            ViewLogInformationDataTable.CellContentClick += ViewLogInformationDataTable_CellContentClick;
            // 
            // ViewLastUpdatesCancelButton
            // 
            ViewLastUpdatesCancelButton.BackColor = Color.FromArgb(255, 128, 128);
            ViewLastUpdatesCancelButton.Font = new Font("Segoe UI", 9F);
            ViewLastUpdatesCancelButton.Location = new Point(14, 877);
            ViewLastUpdatesCancelButton.Margin = new Padding(3, 4, 3, 4);
            ViewLastUpdatesCancelButton.Name = "ViewLastUpdatesCancelButton";
            ViewLastUpdatesCancelButton.Size = new Size(233, 60);
            ViewLastUpdatesCancelButton.TabIndex = 9;
            ViewLastUpdatesCancelButton.Text = "Cancel";
            ViewLastUpdatesCancelButton.UseVisualStyleBackColor = false;
            ViewLastUpdatesCancelButton.Click += ViewLastUpdatesCancelButton_Click;
            // 
            // ViewLastUpdatesForm
            // 
            ClientSize = new Size(1145, 953);
            Controls.Add(ViewLastUpdatesCancelButton);
            Controls.Add(ViewLogInformationDataTable);
            Controls.Add(ViewLastUpdatesLabel);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            Location = new Point(235, 12);
            Name = "ViewLastUpdatesForm";
            Text = "View: Last Updates";
            ((ISupportInitialize)ViewLogInformationDataTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ViewIMSLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ViewLogInformationDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewLastUpdatesCancelButton_Click(object sender, EventArgs e)
        {
            ViewInventoryMain df = new ViewInventoryMain();
            this.Close();   //Closes this window leaving the Main Menu visible
            df.Show();
        }
    }
}
