namespace InsuranceManager
{
    partial class LoginView
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
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxUsername.Location = new System.Drawing.Point(118, 107);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(249, 24);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(262, 191);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(105, 28);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Sign In";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(164, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(160, 44);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Welcome!";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPassword.Location = new System.Drawing.Point(118, 161);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(249, 24);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(135, 79);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(218, 25);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Enter your username!";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(135, 133);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(215, 25);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Enter your password!";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegBtn
            // 
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.Location = new System.Drawing.Point(118, 191);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(112, 28);
            this.RegBtn.TabIndex = 7;
            this.RegBtn.Text = "Sign Up";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 267);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtBoxUsername);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button RegBtn;
    }
}

