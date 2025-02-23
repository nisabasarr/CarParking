namespace CarParking
{
    partial class Main
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
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(170, 116);
            button1.Name = "button1";
            button1.Size = new Size(487, 29);
            button1.TabIndex = 0;
            button1.Text = "Araç Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 42F);
            label1.Location = new Point(241, 33);
            label1.Name = "label1";
            label1.Size = new Size(317, 63);
            label1.TabIndex = 1;
            label1.Text = "N | U PARK";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(170, 151);
            button2.Name = "button2";
            button2.Size = new Size(487, 29);
            button2.TabIndex = 2;
            button2.Text = "Araç Çıkış Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(170, 221);
            button3.Name = "button3";
            button3.Size = new Size(487, 29);
            button3.TabIndex = 3;
            button3.Text = "Otopark Kapasite Belirle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(170, 256);
            button4.Name = "button4";
            button4.Size = new Size(487, 29);
            button4.TabIndex = 4;
            button4.Text = "Tarihe Göre Araç Raporu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(170, 291);
            button5.Name = "button5";
            button5.Size = new Size(487, 29);
            button5.TabIndex = 5;
            button5.Text = "Son 24 Saatteki Araçlar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(170, 326);
            button6.Name = "button6";
            button6.Size = new Size(487, 29);
            button6.TabIndex = 6;
            button6.Text = "Doluluk Oranı";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(170, 186);
            button7.Name = "button7";
            button7.Size = new Size(487, 29);
            button7.TabIndex = 7;
            button7.Text = "Otopark Saatlik Fiyat Belirle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Main";
            Text = "N | U PARK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}