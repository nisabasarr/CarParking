namespace CarParking
{
    partial class Price
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
            numFiyat = new NumericUpDown();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            SuspendLayout();
            // 
            // numFiyat
            // 
            numFiyat.Location = new Point(25, 40);
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(224, 23);
            numFiyat.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(92, 80);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Saatlik Ücret";
            // 
            // Price
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 168);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(numFiyat);
            Name = "Price";
            Text = "Saatlik Ücret";
            Load += Price_Load;
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown numFiyat;
        private Button button1;
        private Label label1;
    }
}