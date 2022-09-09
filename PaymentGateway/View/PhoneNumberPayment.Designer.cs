namespace PaymentGateway
{
    partial class PhoneNumberPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneNumberPayment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_PContinue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.txt_PhoneNumber);
            this.panel1.Controls.Add(this.btn_PContinue);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 402);
            this.panel1.TabIndex = 0;
            // 
            // btn_PContinue
            // 
            this.btn_PContinue.BackColor = System.Drawing.Color.Transparent;
            this.btn_PContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_PContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PContinue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PContinue.Location = new System.Drawing.Point(95, 297);
            this.btn_PContinue.Name = "btn_PContinue";
            this.btn_PContinue.Size = new System.Drawing.Size(208, 40);
            this.btn_PContinue.TabIndex = 5;
            this.btn_PContinue.Text = "Continue";
            this.btn_PContinue.UseVisualStyleBackColor = false;
            this.btn_PContinue.Click += new System.EventHandler(this.btn_PContinue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(77, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "+91";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pay someone using an UPI-verified phone number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a phone number";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_PhoneNumber.Location = new System.Drawing.Point(131, 137);
            this.txt_PhoneNumber.Mask = "0000000000";
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.PromptChar = 'x';
            this.txt_PhoneNumber.Size = new System.Drawing.Size(211, 32);
            this.txt_PhoneNumber.TabIndex = 6;
            // 
            // PhoneNumberPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "PhoneNumberPayment";
            this.Size = new System.Drawing.Size(413, 402);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button btn_PContinue;
        private MaskedTextBox txt_PhoneNumber;
    }
}
