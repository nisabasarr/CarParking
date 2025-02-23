namespace CarParking
{
    partial class CarLogin
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
            txtPlaka = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtPlaka
            // 
            txtPlaka.Location = new Point(33, 46);
            txtPlaka.Name = "txtPlaka";
            txtPlaka.Size = new Size(216, 23);
            txtPlaka.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 18);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Plaka";
            // 
            // button1
            // 
            button1.Location = new Point(95, 91);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CarLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 168);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtPlaka);
            Name = "CarLogin";
            Text = "Araç Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlaka;
        private Label label1;
        private Button button1;
    }
}