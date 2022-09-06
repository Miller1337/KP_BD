
namespace KP_BD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LOgBYUz = new System.Windows.Forms.Button();
            this.LogByADM = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LOgBYUz
            // 
            this.LOgBYUz.BackColor = System.Drawing.Color.Coral;
            this.LOgBYUz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOgBYUz.Location = new System.Drawing.Point(68, 123);
            this.LOgBYUz.Name = "LOgBYUz";
            this.LOgBYUz.Size = new System.Drawing.Size(130, 58);
            this.LOgBYUz.TabIndex = 0;
            this.LOgBYUz.Text = "Войти как арендатор";
            this.LOgBYUz.UseVisualStyleBackColor = false;
            this.LOgBYUz.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogByADM
            // 
            this.LogByADM.BackColor = System.Drawing.Color.SlateGray;
            this.LogByADM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogByADM.Location = new System.Drawing.Point(581, 123);
            this.LogByADM.Name = "LogByADM";
            this.LogByADM.Size = new System.Drawing.Size(130, 58);
            this.LogByADM.TabIndex = 1;
            this.LogByADM.Text = "Войти как арендодатель";
            this.LogByADM.UseVisualStyleBackColor = false;
            this.LogByADM.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit.BackgroundImage")));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Location = new System.Drawing.Point(324, 385);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(130, 53);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LogByADM);
            this.Controls.Add(this.LOgBYUz);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LOgBYUz;
        private System.Windows.Forms.Button LogByADM;
        private System.Windows.Forms.Button Exit;
    }
}

