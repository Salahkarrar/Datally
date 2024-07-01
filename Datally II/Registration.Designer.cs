namespace Datally
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Confirm_Btn = new System.Windows.Forms.Button();
            this.Passwor_label = new System.Windows.Forms.Label();
            this.Registration_Txt = new System.Windows.Forms.TextBox();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Main_Lab = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Confirm_Btn);
            this.groupBox1.Controls.Add(this.Passwor_label);
            this.groupBox1.Controls.Add(this.Registration_Txt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(179, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // Confirm_Btn
            // 
            this.Confirm_Btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Confirm_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Confirm_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Confirm_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Confirm_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Confirm_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm_Btn.ForeColor = System.Drawing.Color.White;
            this.Confirm_Btn.Image = global::Datally.Properties.Resources.ic_save_white_18dp;
            this.Confirm_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Confirm_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Confirm_Btn.Location = new System.Drawing.Point(163, 117);
            this.Confirm_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_Btn.Name = "Confirm_Btn";
            this.Confirm_Btn.Size = new System.Drawing.Size(100, 40);
            this.Confirm_Btn.TabIndex = 1;
            this.Confirm_Btn.Text = "Confirm";
            this.Confirm_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Confirm_Btn.UseVisualStyleBackColor = true;
            this.Confirm_Btn.Click += new System.EventHandler(this.Confirm_Btn_Click);
            // 
            // Passwor_label
            // 
            this.Passwor_label.AutoSize = true;
            this.Passwor_label.ForeColor = System.Drawing.Color.White;
            this.Passwor_label.Location = new System.Drawing.Point(100, 27);
            this.Passwor_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Passwor_label.Name = "Passwor_label";
            this.Passwor_label.Size = new System.Drawing.Size(250, 19);
            this.Passwor_label.TabIndex = 14;
            this.Passwor_label.Text = "Please Enter Your Registration Key";
            // 
            // Registration_Txt
            // 
            this.Registration_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Registration_Txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Registration_Txt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_Txt.ForeColor = System.Drawing.Color.White;
            this.Registration_Txt.Location = new System.Drawing.Point(25, 56);
            this.Registration_Txt.Margin = new System.Windows.Forms.Padding(2);
            this.Registration_Txt.Name = "Registration_Txt";
            this.Registration_Txt.Size = new System.Drawing.Size(376, 30);
            this.Registration_Txt.TabIndex = 0;
            this.Registration_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Registration_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProID_Txt_KeyDown);
            // 
            // Shutdown_Btn
            // 
            this.Shutdown_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Shutdown_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Shutdown_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Shutdown_Btn.FlatAppearance.BorderSize = 0;
            this.Shutdown_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.Brown;
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(760, 0);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(25, 25);
            this.Shutdown_Btn.TabIndex = 0;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 25);
            this.panel1.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Datally.Properties.Resources.Radiologix;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(2, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(95, 98);
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // Main_Lab
            // 
            this.Main_Lab.AutoSize = true;
            this.Main_Lab.BackColor = System.Drawing.Color.Transparent;
            this.Main_Lab.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_Lab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Main_Lab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Main_Lab.Location = new System.Drawing.Point(102, 28);
            this.Main_Lab.Name = "Main_Lab";
            this.Main_Lab.Size = new System.Drawing.Size(116, 25);
            this.Main_Lab.TabIndex = 12;
            this.Main_Lab.Text = "Radiologix";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(785, 355);
            this.Controls.Add(this.Main_Lab);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 700);
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regisrtation";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Passwor_label;
        private System.Windows.Forms.TextBox Registration_Txt;
        private System.Windows.Forms.Button Confirm_Btn;
        private System.Windows.Forms.PictureBox Logo;
        protected internal System.Windows.Forms.Label Main_Lab;
    }
}