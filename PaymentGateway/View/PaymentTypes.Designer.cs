namespace PaymentGateway
{
    partial class PaymentTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentTypes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Back = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_CardPayment = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Phone = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Bank = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_CardPayment);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_Phone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Bank);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 109);
            this.panel1.TabIndex = 0;
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_Back.IconColor = System.Drawing.Color.Black;
            this.btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Back.IconSize = 40;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(50, 38);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(296, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Card Payment";
            // 
            // btn_CardPayment
            // 
            this.btn_CardPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CardPayment.BackColor = System.Drawing.Color.Transparent;
            this.btn_CardPayment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_CardPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_CardPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CardPayment.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CardPayment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.btn_CardPayment.IconColor = System.Drawing.Color.Black;
            this.btn_CardPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CardPayment.Location = new System.Drawing.Point(307, 12);
            this.btn_CardPayment.Name = "btn_CardPayment";
            this.btn_CardPayment.Size = new System.Drawing.Size(62, 66);
            this.btn_CardPayment.TabIndex = 4;
            this.btn_CardPayment.UseVisualStyleBackColor = false;
            this.btn_CardPayment.Click += new System.EventHandler(this.btn_CardPayment_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone number";
            // 
            // btn_Phone
            // 
            this.btn_Phone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Phone.BackColor = System.Drawing.Color.Transparent;
            this.btn_Phone.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Phone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Phone.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Phone.IconChar = FontAwesome.Sharp.IconChar.MobileRetro;
            this.btn_Phone.IconColor = System.Drawing.Color.Black;
            this.btn_Phone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Phone.Location = new System.Drawing.Point(199, 12);
            this.btn_Phone.Name = "btn_Phone";
            this.btn_Phone.Size = new System.Drawing.Size(62, 66);
            this.btn_Phone.TabIndex = 2;
            this.btn_Phone.UseVisualStyleBackColor = false;
            this.btn_Phone.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bank transfer  ";
            // 
            // btn_Bank
            // 
            this.btn_Bank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Bank.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bank.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Bank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bank.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Bank.IconChar = FontAwesome.Sharp.IconChar.Bank;
            this.btn_Bank.IconColor = System.Drawing.Color.Black;
            this.btn_Bank.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Bank.Location = new System.Drawing.Point(90, 12);
            this.btn_Bank.Name = "btn_Bank";
            this.btn_Bank.Size = new System.Drawing.Size(62, 66);
            this.btn_Bank.TabIndex = 0;
            this.btn_Bank.UseVisualStyleBackColor = false;
            this.btn_Bank.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDesktop.BackgroundImage")));
            this.panelDesktop.Location = new System.Drawing.Point(0, 109);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(413, 402);
            this.panelDesktop.TabIndex = 1;
            // 
            // PaymentTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 511);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PaymentTypes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentTypes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private FontAwesome.Sharp.IconButton btn_Phone;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_Bank;
        private Panel panelDesktop;
        private Label label3;
        private FontAwesome.Sharp.IconButton btn_CardPayment;
        private FontAwesome.Sharp.IconButton btn_Back;
    }
}