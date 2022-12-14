namespace PaymentGateway
{
    partial class OTPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_OTP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_3 = new FontAwesome.Sharp.IconButton();
            this.btn_clear = new FontAwesome.Sharp.IconButton();
            this.btn_9 = new FontAwesome.Sharp.IconButton();
            this.btn_0 = new FontAwesome.Sharp.IconButton();
            this.btn_8 = new FontAwesome.Sharp.IconButton();
            this.btn_7 = new FontAwesome.Sharp.IconButton();
            this.btn_6 = new FontAwesome.Sharp.IconButton();
            this.btn_5 = new FontAwesome.Sharp.IconButton();
            this.btn_4 = new FontAwesome.Sharp.IconButton();
            this.btn_2 = new FontAwesome.Sharp.IconButton();
            this.btn_1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txt_OTP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Confirm);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 511);
            this.panel1.TabIndex = 0;
            // 
            // txt_OTP
            // 
            this.txt_OTP.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_OTP.Location = new System.Drawing.Point(62, 80);
            this.txt_OTP.Mask = "0000";
            this.txt_OTP.Name = "txt_OTP";
            this.txt_OTP.PromptChar = 'X';
            this.txt_OTP.Size = new System.Drawing.Size(304, 32);
            this.txt_OTP.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please Enter OTP here ";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirm.Location = new System.Drawing.Point(91, 451);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(253, 46);
            this.btn_Confirm.TabIndex = 15;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btn_3);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_9);
            this.panel2.Controls.Add(this.btn_0);
            this.panel2.Controls.Add(this.btn_8);
            this.panel2.Controls.Add(this.btn_7);
            this.panel2.Controls.Add(this.btn_6);
            this.panel2.Controls.Add(this.btn_5);
            this.panel2.Controls.Add(this.btn_4);
            this.panel2.Controls.Add(this.btn_2);
            this.panel2.Controls.Add(this.btn_1);
            this.panel2.Location = new System.Drawing.Point(54, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 327);
            this.panel2.TabIndex = 13;
            // 
            // btn_3
            // 
            this.btn_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_3.FlatAppearance.BorderSize = 0;
            this.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.IconChar = FontAwesome.Sharp.IconChar._3;
            this.btn_3.IconColor = System.Drawing.Color.Black;
            this.btn_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_3.IconSize = 40;
            this.btn_3.Location = new System.Drawing.Point(234, 18);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(55, 54);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "\r\n";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.IconChar = FontAwesome.Sharp.IconChar.C;
            this.btn_clear.IconColor = System.Drawing.Color.Black;
            this.btn_clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_clear.IconSize = 40;
            this.btn_clear.Location = new System.Drawing.Point(234, 263);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 54);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "\r\n";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_9
            // 
            this.btn_9.FlatAppearance.BorderSize = 0;
            this.btn_9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.IconChar = FontAwesome.Sharp.IconChar._9;
            this.btn_9.IconColor = System.Drawing.Color.Black;
            this.btn_9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_9.IconSize = 40;
            this.btn_9.Location = new System.Drawing.Point(234, 184);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(55, 54);
            this.btn_9.TabIndex = 10;
            this.btn_9.Text = "\r\n";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.FlatAppearance.BorderSize = 0;
            this.btn_0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.IconChar = FontAwesome.Sharp.IconChar._0;
            this.btn_0.IconColor = System.Drawing.Color.Black;
            this.btn_0.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_0.IconSize = 40;
            this.btn_0.Location = new System.Drawing.Point(124, 263);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(55, 54);
            this.btn_0.TabIndex = 11;
            this.btn_0.Text = "\r\n";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_8
            // 
            this.btn_8.FlatAppearance.BorderSize = 0;
            this.btn_8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.IconChar = FontAwesome.Sharp.IconChar._8;
            this.btn_8.IconColor = System.Drawing.Color.Black;
            this.btn_8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_8.IconSize = 40;
            this.btn_8.Location = new System.Drawing.Point(124, 184);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(55, 54);
            this.btn_8.TabIndex = 9;
            this.btn_8.Text = "\r\n";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_7
            // 
            this.btn_7.FlatAppearance.BorderSize = 0;
            this.btn_7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.IconChar = FontAwesome.Sharp.IconChar._7;
            this.btn_7.IconColor = System.Drawing.Color.Black;
            this.btn_7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_7.IconSize = 40;
            this.btn_7.Location = new System.Drawing.Point(10, 184);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(55, 54);
            this.btn_7.TabIndex = 8;
            this.btn_7.Text = "\r\n";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_6
            // 
            this.btn_6.FlatAppearance.BorderSize = 0;
            this.btn_6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.IconChar = FontAwesome.Sharp.IconChar._6;
            this.btn_6.IconColor = System.Drawing.Color.Black;
            this.btn_6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_6.IconSize = 40;
            this.btn_6.Location = new System.Drawing.Point(234, 101);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(55, 54);
            this.btn_6.TabIndex = 7;
            this.btn_6.Text = "\r\n";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.FlatAppearance.BorderSize = 0;
            this.btn_5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.IconChar = FontAwesome.Sharp.IconChar._5;
            this.btn_5.IconColor = System.Drawing.Color.Black;
            this.btn_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_5.IconSize = 40;
            this.btn_5.Location = new System.Drawing.Point(124, 101);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(55, 54);
            this.btn_5.TabIndex = 6;
            this.btn_5.Text = "\r\n";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.FlatAppearance.BorderSize = 0;
            this.btn_4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.IconChar = FontAwesome.Sharp.IconChar._4;
            this.btn_4.IconColor = System.Drawing.Color.Black;
            this.btn_4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_4.IconSize = 40;
            this.btn_4.Location = new System.Drawing.Point(10, 101);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(55, 54);
            this.btn_4.TabIndex = 5;
            this.btn_4.Text = "\r\n";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_2
            // 
            this.btn_2.FlatAppearance.BorderSize = 0;
            this.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.IconChar = FontAwesome.Sharp.IconChar._2;
            this.btn_2.IconColor = System.Drawing.Color.Black;
            this.btn_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_2.IconSize = 40;
            this.btn_2.Location = new System.Drawing.Point(124, 19);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(55, 54);
            this.btn_2.TabIndex = 3;
            this.btn_2.Text = "\r\n";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_1
            // 
            this.btn_1.FlatAppearance.BorderSize = 0;
            this.btn_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.IconChar = FontAwesome.Sharp.IconChar._1;
            this.btn_1.IconColor = System.Drawing.Color.Black;
            this.btn_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_1.IconSize = 40;
            this.btn_1.Location = new System.Drawing.Point(10, 19);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(55, 54);
            this.btn_1.TabIndex = 2;
            this.btn_1.Text = "\r\n";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // OTPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 511);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OTPForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btn_clear;
        private FontAwesome.Sharp.IconButton btn_9;
        private FontAwesome.Sharp.IconButton btn_0;
        private FontAwesome.Sharp.IconButton btn_8;
        private FontAwesome.Sharp.IconButton btn_7;
        private FontAwesome.Sharp.IconButton btn_6;
        private FontAwesome.Sharp.IconButton btn_5;
        private FontAwesome.Sharp.IconButton btn_4;
        private FontAwesome.Sharp.IconButton btn_2;
        private FontAwesome.Sharp.IconButton btn_1;
        private Button btn_Confirm;
        private FontAwesome.Sharp.IconButton btn_3;
        private Label label1;
        private MaskedTextBox txt_OTP;
    }
}