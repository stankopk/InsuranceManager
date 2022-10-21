namespace InsuranceManager.View
{
    partial class AdminView
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
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DelateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.Location = new System.Drawing.Point(170, 66);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(160, 26);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome Admin";
            // 
            // CreateBtn
            // 
            this.CreateBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.Location = new System.Drawing.Point(48, 347);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(82, 33);
            this.CreateBtn.TabIndex = 1;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(158, 347);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(82, 33);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(267, 347);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(82, 33);
            this.UpdateBtn.TabIndex = 3;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DelateBtn
            // 
            this.DelateBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelateBtn.Location = new System.Drawing.Point(375, 347);
            this.DelateBtn.Name = "DelateBtn";
            this.DelateBtn.Size = new System.Drawing.Size(86, 33);
            this.DelateBtn.TabIndex = 4;
            this.DelateBtn.Text = "Delate";
            this.DelateBtn.UseVisualStyleBackColor = true;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 427);
            this.Controls.Add(this.DelateBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.WelcomeLbl);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DelateBtn;
    }
}