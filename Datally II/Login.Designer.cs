namespace Datally
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.About = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.TextBox();
            this.Passwor_label = new System.Windows.Forms.Label();
            this.CheckConn_label = new System.Windows.Forms.Label();
            this.Conn_Status = new System.Windows.Forms.Label();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.RLogin_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.About.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.About.Location = new System.Drawing.Point(90, 469);
            this.About.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(96, 19);
            this.About.TabIndex = 9;
            this.About.TabStop = true;
            this.About.Text = "Salah Karrar";
            this.About.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.About_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Edwardian Script ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(77, 446);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "__________";
            // 
            // PassWord
            // 
            this.PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.PassWord.ForeColor = System.Drawing.Color.White;
            this.PassWord.Location = new System.Drawing.Point(6, 187);
            this.PassWord.Margin = new System.Windows.Forms.Padding(2);
            this.PassWord.Name = "PassWord";
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(188, 22);
            this.PassWord.TabIndex = 1;
            this.PassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwor_label
            // 
            this.Passwor_label.AutoSize = true;
            this.Passwor_label.ForeColor = System.Drawing.Color.White;
            this.Passwor_label.Location = new System.Drawing.Point(71, 168);
            this.Passwor_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwor_label.Name = "Passwor_label";
            this.Passwor_label.Size = new System.Drawing.Size(59, 15);
            this.Passwor_label.TabIndex = 12;
            this.Passwor_label.Text = "Password";
            // 
            // CheckConn_label
            // 
            this.CheckConn_label.AutoSize = true;
            this.CheckConn_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckConn_label.ForeColor = System.Drawing.Color.White;
            this.CheckConn_label.Location = new System.Drawing.Point(6, 77);
            this.CheckConn_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckConn_label.Name = "CheckConn_label";
            this.CheckConn_label.Size = new System.Drawing.Size(112, 15);
            this.CheckConn_label.TabIndex = 12;
            this.CheckConn_label.Text = "Connection status :";
            // 
            // Conn_Status
            // 
            this.Conn_Status.AutoSize = true;
            this.Conn_Status.ForeColor = System.Drawing.Color.White;
            this.Conn_Status.Location = new System.Drawing.Point(122, 77);
            this.Conn_Status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Conn_Status.Name = "Conn_Status";
            this.Conn_Status.Size = new System.Drawing.Size(41, 15);
            this.Conn_Status.TabIndex = 12;
            this.Conn_Status.Text = "Status";
            // 
            // Login_Btn
            // 
            this.Login_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Login_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.ForeColor = System.Drawing.Color.White;
            this.Login_Btn.Image = global::Datally.Properties.Resources.ic_account_circle_white_18dp;
            this.Login_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Login_Btn.Location = new System.Drawing.Point(6, 246);
            this.Login_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(70, 25);
            this.Login_Btn.TabIndex = 2;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Exit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.Color.White;
            this.Exit_Btn.Image = global::Datally.Properties.Resources.ic_exit_to_app_white_18dp;
            this.Exit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_Btn.Location = new System.Drawing.Point(125, 246);
            this.Exit_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Exit_Btn.TabIndex = 3;
            this.Exit_Btn.Text = "Exit";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(85, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(31, 32);
            this.Logo.TabIndex = 10;
            this.Logo.TabStop = false;
            // 
            // RLogin_Btn
            // 
            this.RLogin_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.RLogin_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.RLogin_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.RLogin_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RLogin_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLogin_Btn.ForeColor = System.Drawing.Color.White;
            this.RLogin_Btn.Image = global::Datally.Properties.Resources.ic_account_circle_white_18dp;
            this.RLogin_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RLogin_Btn.Location = new System.Drawing.Point(50, 310);
            this.RLogin_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.RLogin_Btn.Name = "RLogin_Btn";
            this.RLogin_Btn.Size = new System.Drawing.Size(100, 25);
            this.RLogin_Btn.TabIndex = 2;
            this.RLogin_Btn.Text = "  Reportly Login";
            this.RLogin_Btn.UseVisualStyleBackColor = true;
            this.RLogin_Btn.Click += new System.EventHandler(this.RLogin_Btn_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_Btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.Exit_Btn;
            this.ClientSize = new System.Drawing.Size(200, 500);
            this.ControlBox = false;
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.Passwor_label);
            this.Controls.Add(this.Conn_Status);
            this.Controls.Add(this.CheckConn_label);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.About);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Exit_Btn);
            this.Controls.Add(this.RLogin_Btn);
            this.Controls.Add(this.Login_Btn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(500, 170);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel About;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.TextBox PassWord;
        private System.Windows.Forms.Label Passwor_label;
        private System.Windows.Forms.Label CheckConn_label;
        private System.Windows.Forms.Label Conn_Status;
        private System.Windows.Forms.Button RLogin_Btn;
    }
}

