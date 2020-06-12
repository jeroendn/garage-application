namespace GarageProject
{
    partial class Form1
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxWachtwoord = new System.Windows.Forms.TextBox();
            this.btnInlog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(218, 111);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(218, 143);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lblWachtwoord.TabIndex = 1;
            this.lblWachtwoord.Text = "Wachtwoord";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(308, 108);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(100, 20);
            this.tbxEmail.TabIndex = 2;
            // 
            // tbxWachtwoord
            // 
            this.tbxWachtwoord.Location = new System.Drawing.Point(308, 140);
            this.tbxWachtwoord.Name = "tbxWachtwoord";
            this.tbxWachtwoord.Size = new System.Drawing.Size(100, 20);
            this.tbxWachtwoord.TabIndex = 3;
            // 
            // btnInlog
            // 
            this.btnInlog.Location = new System.Drawing.Point(278, 201);
            this.btnInlog.Name = "btnInlog";
            this.btnInlog.Size = new System.Drawing.Size(75, 23);
            this.btnInlog.TabIndex = 4;
            this.btnInlog.Text = "Inloggen";
            this.btnInlog.UseVisualStyleBackColor = true;
            this.btnInlog.Click += new System.EventHandler(this.btnInlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInlog);
            this.Controls.Add(this.tbxWachtwoord);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.lblEmail);
            this.Name = "Form1";
            this.Text = "Inloggen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWachtwoord;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxWachtwoord;
        private System.Windows.Forms.Button btnInlog;
    }
}

