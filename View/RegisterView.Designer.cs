namespace InsuranceManager.View
{
    partial class RegisterView
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.ConfirmPassTxt = new System.Windows.Forms.TextBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(12, 63);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(217, 20);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Enter your desired username:";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLabel.Location = new System.Drawing.Point(153, 9);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(171, 33);
            this.RegisterLabel.TabIndex = 1;
            this.RegisterLabel.Text = "Registration";
            this.RegisterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(104, 94);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(125, 20);
            this.PassLabel.TabIndex = 2;
            this.PassLabel.Text = "Enter Password:";
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassLabel.Location = new System.Drawing.Point(88, 127);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(141, 20);
            this.ConfirmPassLabel.TabIndex = 3;
            this.ConfirmPassLabel.Text = "Confirm Password:";
            this.ConfirmPassLabel.Click += new System.EventHandler(this.ConfirmPassLabel_Click);
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UsernameTxt.Location = new System.Drawing.Point(235, 65);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(217, 20);
            this.UsernameTxt.TabIndex = 4;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Location = new System.Drawing.Point(235, 94);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(217, 20);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // ConfirmPassTxt
            // 
            this.ConfirmPassTxt.Location = new System.Drawing.Point(235, 127);
            this.ConfirmPassTxt.Name = "ConfirmPassTxt";
            this.ConfirmPassTxt.PasswordChar = '*';
            this.ConfirmPassTxt.Size = new System.Drawing.Size(217, 20);
            this.ConfirmPassTxt.TabIndex = 6;
            this.ConfirmPassTxt.TextChanged += new System.EventHandler(this.ConfirmPassTxt_TextChanged);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ReturnBtn.Location = new System.Drawing.Point(12, 170);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(125, 35);
            this.ReturnBtn.TabIndex = 7;
            this.ReturnBtn.Text = "Nevermind";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button1.Location = new System.Drawing.Point(313, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register Me!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 217);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.ConfirmPassTxt);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.ConfirmPassLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.UsernameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox ConfirmPassTxt;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Button button1;
    }
}