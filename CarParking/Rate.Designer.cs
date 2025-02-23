namespace CarParking
{
    partial class Rate
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
            Ratelbl = new Label();
            SuspendLayout();
            // 
            // Ratelbl
            // 
            Ratelbl.AutoSize = true;
            Ratelbl.Location = new Point(62, 74);
            Ratelbl.Name = "Ratelbl";
            Ratelbl.Size = new Size(80, 15);
            Ratelbl.TabIndex = 1;
            Ratelbl.Text = "Doluluk Oranı";
            // 
            // Rate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 168);
            Controls.Add(Ratelbl);
            Name = "Rate";
            Text = "Doluluk Oranı";
            Load += Rate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Ratelbl;
    }
}