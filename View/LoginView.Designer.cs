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
            this.PasswordIconPictureBox = new System.Windows.Forms.PictureBox();
            this.UserIconPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxUsername.Location = new System.Drawing.Point(40, 115);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(249, 24);
            this.txtBoxUsername.TabIndex = 0;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEnter.FlatAppearance.BorderSize = 2;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.Aqua;
            this.btnEnter.Location = new System.Drawing.Point(169, 225);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(120, 32);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Sign In";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.ForeColor = System.Drawing.Color.Aqua;
            this.lblLogin.Location = new System.Drawing.Point(86, 33);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(160, 44);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Welcome!";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxPassword.Location = new System.Drawing.Point(40, 185);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(249, 24);
            this.txtBoxPassword.TabIndex = 3;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(57, 87);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(218, 25);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Enter your username:";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(57, 157);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(215, 25);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Enter your password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegBtn
            // 
            this.RegBtn.BackColor = System.Drawing.Color.Transparent;
            this.RegBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegBtn.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.RegBtn.FlatAppearance.BorderSize = 2;
            this.RegBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.RegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.ForeColor = System.Drawing.Color.Aqua;
            this.RegBtn.Location = new System.Drawing.Point(40, 225);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(120, 32);
            this.RegBtn.TabIndex = 7;
            this.RegBtn.Text = "Sign Up";
            this.RegBtn.UseVisualStyleBackColor = false;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // PasswordIconPictureBox
            // 
            this.PasswordIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordIconPictureBox.BackgroundImage = global::InsuranceManager.Properties.Resources.lock_icon_black_white_black_background_illustration_lock_icon_black_white_black_background_vector_illustration_170336738_removebg_preview;
            this.PasswordIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordIconPictureBox.Location = new System.Drawing.Point(-2, 176);
            this.PasswordIconPictureBox.Name = "PasswordIconPictureBox";
            this.PasswordIconPictureBox.Size = new System.Drawing.Size(45, 47);
            this.PasswordIconPictureBox.TabIndex = 8;
            this.PasswordIconPictureBox.TabStop = false;
            // 
            // UserIconPictureBox
            // 
            this.UserIconPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UserIconPictureBox.BackgroundImage = global::InsuranceManager.Properties.Resources.profile_user_round_white_icon_symbol_png_11639594348fn8rlcxrqo_removebg_preview;
            this.UserIconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UserIconPictureBox.Location = new System.Drawing.Point(2, 109);
            this.UserIconPictureBox.Name = "UserIconPictureBox";
            this.UserIconPictureBox.Size = new System.Drawing.Size(36, 36);
            this.UserIconPictureBox.TabIndex = 9;
            this.UserIconPictureBox.TabStop = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InsuranceManager.Properties.Resources.ActualBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.UserIconPictureBox);
            this.Controls.Add(this.PasswordIconPictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.PasswordIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserIconPictureBox)).EndInit();
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
        private System.Windows.Forms.PictureBox PasswordIconPictureBox;
        private System.Windows.Forms.PictureBox UserIconPictureBox;
    }
}

