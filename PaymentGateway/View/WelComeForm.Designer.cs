namespace PaymentGateway
{
    partial class WelComeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelComeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btn_Logout = new FontAwesome.Sharp.IconButton();
            this.btn_Transaction = new FontAwesome.Sharp.IconButton();
            this.btn_View = new FontAwesome.Sharp.IconButton();
            this.lb_Name = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.btn_Transaction);
            this.panel1.Controls.Add(this.btn_View);
            this.panel1.Controls.Add(this.lb_Name);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 468);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome,";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 144;
            this.iconPictureBox1.Location = new System.Drawing.Point(128, 81);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(151, 144);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // btn_Logout
            // 
            this.btn_Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btn_Logout.IconColor = System.Drawing.Color.Black;
            this.btn_Logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Logout.Location = new System.Drawing.Point(336, 15);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(45, 59);
            this.btn_Logout.TabIndex = 4;
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Transaction
            // 
            this.btn_Transaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Transaction.BackColor = System.Drawing.Color.Transparent;
            this.btn_Transaction.FlatAppearance.BorderSize = 0;
            this.btn_Transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Transaction.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.btn_Transaction.IconColor = System.Drawing.Color.Black;
            this.btn_Transaction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Transaction.IconSize = 35;
            this.btn_Transaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Transaction.Location = new System.Drawing.Point(3, 302);
            this.btn_Transaction.Name = "btn_Transaction";
            this.btn_Transaction.Size = new System.Drawing.Size(243, 45);
            this.btn_Transaction.TabIndex = 3;
            this.btn_Transaction.Text = "Show transaction history";
            this.btn_Transaction.UseVisualStyleBackColor = false;
            this.btn_Transaction.Click += new System.EventHandler(this.btn_Transaction_Click);
            // 
            // btn_View
            // 
            this.btn_View.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_View.BackColor = System.Drawing.Color.Transparent;
            this.btn_View.FlatAppearance.BorderSize = 0;
            this.btn_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_View.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_View.IconChar = FontAwesome.Sharp.IconChar.Bank;
            this.btn_View.IconColor = System.Drawing.Color.Black;
            this.btn_View.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_View.IconSize = 35;
            this.btn_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_View.Location = new System.Drawing.Point(3, 250);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(243, 46);
            this.btn_View.TabIndex = 2;
            this.btn_View.Text = "View Account Balance";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // lb_Name
            // 
            this.lb_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_Name.AutoSize = true;
            this.lb_Name.BackColor = System.Drawing.Color.Transparent;
            this.lb_Name.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Name.Location = new System.Drawing.Point(12, 35);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(50, 19);
            this.lb_Name.TabIndex = 1;
            this.lb_Name.Text = "label1";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(94, 386);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(218, 58);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "New payment";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // WelComeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WelComeForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label lb_Name;
        private FontAwesome.Sharp.IconButton btn_Transaction;
        private FontAwesome.Sharp.IconButton btn_View;
        private FontAwesome.Sharp.IconButton btn_Logout;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
    }
}