﻿namespace CarParking
{
    partial class DayReport
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
            ReportGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ReportGrid).BeginInit();
            SuspendLayout();
            // 
            // ReportGrid
            // 
            ReportGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ReportGrid.Location = new Point(12, 12);
            ReportGrid.Name = "ReportGrid";
            ReportGrid.Size = new Size(629, 426);
            ReportGrid.TabIndex = 0;
            // 
            // DayReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(ReportGrid);
            Name = "DayReport";
            Text = "Günlük Rapor";
            Load += DayReport_Load;
            ((System.ComponentModel.ISupportInitialize)ReportGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ReportGrid;
    }
}