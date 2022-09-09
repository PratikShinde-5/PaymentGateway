namespace PaymentGateway.View
{
    partial class ViewBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBalance));
            this.btn_Back = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BankName = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_Back.IconColor = System.Drawing.Color.Black;
            this.btn_Back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Back.IconSize = 40;
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(50, 38);
            this.btn_Back.TabIndex = 0;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "View account balance";
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CurrencyCombo.BackColor = System.Drawing.Color.White;
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Items.AddRange(new object[] {
            "INR",
            "USD",
            "SAR",
            "BHD",
            "TND"});
            this.CurrencyCombo.Location = new System.Drawing.Point(280, 72);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(121, 23);
            this.CurrencyCombo.TabIndex = 2;
            this.CurrencyCombo.Text = "Select Currency";
            this.CurrencyCombo.SelectedIndexChanged += new System.EventHandler(this.CurrencyCombo_SelectedIndexChanged);
            this.CurrencyCombo.SelectedValueChanged += new System.EventHandler(this.CurrencyCombo_SelectedValueChanged);
            // 
            // lb_name
            // 
            this.lb_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_name.Location = new System.Drawing.Point(56, 214);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(212, 25);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Saving account name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account balance:";
            // 
            // txt_BankName
            // 
            this.txt_BankName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_BankName.AutoSize = true;
            this.txt_BankName.BackColor = System.Drawing.Color.Transparent;
            this.txt_BankName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BankName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_BankName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_BankName.Location = new System.Drawing.Point(56, 256);
            this.txt_BankName.Name = "txt_BankName";
            this.txt_BankName.Size = new System.Drawing.Size(110, 27);
            this.txt_BankName.TabIndex = 5;
            this.txt_BankName.Text = "Bank Name";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Amount.AutoSize = true;
            this.txt_Amount.BackColor = System.Drawing.Color.Transparent;
            this.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Amount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Amount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Amount.Location = new System.Drawing.Point(56, 344);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(79, 27);
            this.txt_Amount.TabIndex = 6;
            this.txt_Amount.Text = "amount";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(309, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Currency";
            // 
            // ViewBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(413, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.txt_BankName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.CurrencyCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewBalance";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewDetails";
            this.Load += new System.EventHandler(this.ViewBalance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btn_Back;
        private Label label1;
        private ComboBox CurrencyCombo;
        private Label lb_name;
        private Label label2;
        private Label txt_BankName;
        private Label txt_Amount;
        private Label label3;
    }
}