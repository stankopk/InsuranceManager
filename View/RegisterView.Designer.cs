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
            this.button1 = new System.Windows.Forms.Button();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.RegLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(12, 145);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(117, 35);
            this.ReturnBtn.TabIndex = 1;
            this.ReturnBtn.Text = "Take me back!";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            this.ReturnBtn.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLbl.Location = new System.Drawing.Point(161, 9);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(187, 37);
            this.RegLbl.TabIndex = 2;
            this.RegLbl.Text = "Registration";
            this.RegLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your desired username:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your desired password:";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(231, 69);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(268, 24);
            this.UsernameTxt.TabIndex = 7;
            this.UsernameTxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(231, 104);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(268, 24);
            this.PasswordTxt.TabIndex = 8;
            this.PasswordTxt.TextChanged += new System.EventHandler(this.PasswordTxt_TextChanged);
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 199);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegLbl);
            this.Controls.Add(this.ReturnBtn);
            this.Controls.Add(this.button1);
            this.Name = "RegisterView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
    }
}