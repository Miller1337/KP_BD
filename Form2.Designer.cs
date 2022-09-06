
namespace KP_BD
{
    partial class Form2
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
            this.LogIN = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogIN
            // 
            this.LogIN.FlatAppearance.BorderSize = 0;
            this.LogIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIN.Location = new System.Drawing.Point(129, 321);
            this.LogIN.Margin = new System.Windows.Forms.Padding(4);
            this.LogIN.Name = "LogIN";
            this.LogIN.Size = new System.Drawing.Size(158, 52);
            this.LogIN.TabIndex = 0;
            this.LogIN.Text = "Вход";
            this.LogIN.UseVisualStyleBackColor = true;
            this.LogIN.Click += new System.EventHandler(this.LogIN_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.Location = new System.Drawing.Point(130, 130);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(157, 26);
            this.username.TabIndex = 1;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password.Location = new System.Drawing.Point(130, 236);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(157, 26);
            this.password.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KP_BD.Properties.Resources.bokeh_2072271_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.LogIN);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form2";
            this.Text = "Войти как арендодатель";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIN;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}