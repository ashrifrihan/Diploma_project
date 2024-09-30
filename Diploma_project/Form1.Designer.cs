namespace Diploma_project
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
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.GroupBox();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.checkBox_Show = new System.Windows.Forms.CheckBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.usernm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(712, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(44, 44);
            this.btnclose.TabIndex = 56;
            this.btnclose.Text = "X";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 44);
            this.panel1.TabIndex = 56;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Exit_btn.FlatAppearance.BorderSize = 0;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_btn.Location = new System.Drawing.Point(13, 508);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(164, 37);
            this.Exit_btn.TabIndex = 71;
            this.Exit_btn.Text = "EXIT";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.btuExit_Click);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.Login_btn);
            this.Login.Controls.Add(this.Clear_btn);
            this.Login.Controls.Add(this.checkBox_Show);
            this.Login.Controls.Add(this.Password_txt);
            this.Login.Controls.Add(this.label1);
            this.Login.Controls.Add(this.userName_txt);
            this.Login.Controls.Add(this.usernm);
            this.Login.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(95, 194);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(595, 302);
            this.Login.TabIndex = 72;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login_btn.Location = new System.Drawing.Point(393, 215);
            this.Login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(164, 37);
            this.Login_btn.TabIndex = 76;
            this.Login_btn.Text = "LOGIN";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.btuLogin_Click_1);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(160)))), ((int)(((byte)(138)))));
            this.Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Clear_btn.FlatAppearance.BorderSize = 0;
            this.Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.Color.White;
            this.Clear_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Clear_btn.Location = new System.Drawing.Point(59, 215);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(164, 37);
            this.Clear_btn.TabIndex = 77;
            this.Clear_btn.Text = "CLEAR";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.btuClear_Click);
            // 
            // checkBox_Show
            // 
            this.checkBox_Show.AutoSize = true;
            this.checkBox_Show.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.checkBox_Show.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBox_Show.Location = new System.Drawing.Point(250, 176);
            this.checkBox_Show.Name = "checkBox_Show";
            this.checkBox_Show.Size = new System.Drawing.Size(135, 23);
            this.checkBox_Show.TabIndex = 75;
            this.checkBox_Show.Text = "Show Password";
            this.checkBox_Show.UseVisualStyleBackColor = true;
            this.checkBox_Show.CheckedChanged += new System.EventHandler(this.checkBox_Show_CheckedChanged_1);
            // 
            // Password_txt
            // 
            this.Password_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.Location = new System.Drawing.Point(250, 137);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(307, 32);
            this.Password_txt.TabIndex = 74;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(53, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
            this.label1.TabIndex = 73;
            this.label1.Text = "Password :";
            // 
            // userName_txt
            // 
            this.userName_txt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_txt.Location = new System.Drawing.Point(250, 55);
            this.userName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(307, 32);
            this.userName_txt.TabIndex = 72;
            // 
            // usernm
            // 
            this.usernm.AutoSize = true;
            this.usernm.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usernm.Location = new System.Drawing.Point(38, 50);
            this.usernm.Name = "usernm";
            this.usernm.Size = new System.Drawing.Size(169, 35);
            this.usernm.TabIndex = 71;
            this.usernm.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 46);
            this.label2.TabIndex = 57;
            this.label2.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Diploma_project.Properties.Resources.icons8_locked_user_48__1_;
            this.pictureBox1.Location = new System.Drawing.Point(313, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Quantify", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(610, 39);
            this.label3.TabIndex = 74;
            this.label3.Text = "SKIILS INTERNATIONAL SCHOOL\r\n\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(50)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(757, 558);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.CheckBox checkBox_Show;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label usernm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

