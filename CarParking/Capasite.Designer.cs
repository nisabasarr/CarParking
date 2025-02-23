namespace CarParking
{
    partial class Capasite
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
            numKapasite = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numKapasite).BeginInit();
            SuspendLayout();
            // 
            // numKapasite
            // 
            numKapasite.Location = new Point(23, 39);
            numKapasite.Name = "numKapasite";
            numKapasite.Size = new Size(226, 23);
            numKapasite.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Kapasite";
            // 
            // button1
            // 
            button1.Location = new Point(87, 83);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Capasite
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 168);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(numKapasite);
            Name = "Capasite";
            Text = "Kapasite";
            Load += Capasite_Load;
            ((System.ComponentModel.ISupportInitialize)numKapasite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numKapasite;
        private Label label1;
        private Button button1;
    }
}