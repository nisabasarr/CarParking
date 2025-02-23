namespace CarParking
{
    partial class DateReport
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
            dtpBaslangic = new DateTimePicker();
            dtpBitis = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            RaporGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)RaporGrid).BeginInit();
            SuspendLayout();
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(36, 62);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(200, 23);
            dtpBaslangic.TabIndex = 0;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(287, 62);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(200, 23);
            dtpBitis.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(535, 64);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Raporla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 44);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 3;
            label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 44);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Bitiş Tarihi";
            // 
            // RaporGrid
            // 
            RaporGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RaporGrid.Location = new Point(12, 121);
            RaporGrid.Name = "RaporGrid";
            RaporGrid.Size = new Size(629, 317);
            RaporGrid.TabIndex = 5;
            // 
            // DateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(RaporGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Name = "DateReport";
            Text = "Tarih Raporu";
            ((System.ComponentModel.ISupportInitialize)RaporGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBaslangic;
        private DateTimePicker dtpBitis;
        private Button button1;
        private Label label1;
        private Label label2;
        private DataGridView RaporGrid;
    }
}