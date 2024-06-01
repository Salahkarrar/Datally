namespace Datally
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize_Btn = new System.Windows.Forms.Button();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.Footer = new System.Windows.Forms.Panel();
            this.UserName_Txt = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.Singout_Btn = new System.Windows.Forms.Button();
            this.Main_Pan = new System.Windows.Forms.Panel();
            this.Sub_Pan = new System.Windows.Forms.Panel();
            this.HReception_Btn = new System.Windows.Forms.Button();
            this.HSearch_Btn = new System.Windows.Forms.Button();
            this.HReport_Btn = new System.Windows.Forms.Button();
            this.HRadiology_Btn = new System.Windows.Forms.Button();
            this.HSettings_Btn = new System.Windows.Forms.Button();
            this.HAbout_Btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Per_Btn = new System.Windows.Forms.Button();
            this.AddUser_Txt = new System.Windows.Forms.Button();
            this.AddDoc_Txt = new System.Windows.Forms.Button();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.Side_Panel = new System.Windows.Forms.Panel();
            this.Settings_Btn = new System.Windows.Forms.Button();
            this.Radiology_Btn = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.Report_Btn = new System.Windows.Forms.Button();
            this.Search_Btn = new System.Windows.Forms.Button();
            this.Reception_Btn = new System.Windows.Forms.Button();
            this.Home_Btn = new System.Windows.Forms.Button();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Footer.SuspendLayout();
            this.Main_Pan.SuspendLayout();
            this.Sub_Pan.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Header.Controls.Add(this.Logo);
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.Minimize_Btn);
            this.Header.Controls.Add(this.Shutdown_Btn);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1200, 25);
            this.Header.TabIndex = 4;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Datally.Properties.Resources.datally1;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Logo.Location = new System.Drawing.Point(0, -1);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(25, 25);
            this.Logo.TabIndex = 5;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(31, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datally";
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Minimize_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Minimize_Btn.FlatAppearance.BorderSize = 0;
            this.Minimize_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Minimize_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.Minimize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Minimize_Btn.ForeColor = System.Drawing.Color.Brown;
            this.Minimize_Btn.Image = global::Datally.Properties.Resources.ic_remove_white_18dp;
            this.Minimize_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Minimize_Btn.Location = new System.Drawing.Point(1150, 0);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(25, 25);
            this.Minimize_Btn.TabIndex = 1;
            this.Minimize_Btn.TabStop = false;
            this.Minimize_Btn.UseVisualStyleBackColor = false;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Shutdown_Btn
            // 
            this.Shutdown_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Shutdown_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Shutdown_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.BorderSize = 0;
            this.Shutdown_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.Shutdown_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.Brown;
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.ic_power_settings_new_white_18dp;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(1175, 0);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(25, 25);
            this.Shutdown_Btn.TabIndex = 2;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(55)))));
            this.Footer.Controls.Add(this.UserName_Txt);
            this.Footer.Controls.Add(this.label2);
            this.Footer.Controls.Add(this.Singout_Btn);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Footer.Location = new System.Drawing.Point(175, 675);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1025, 25);
            this.Footer.TabIndex = 13;
            // 
            // UserName_Txt
            // 
            this.UserName_Txt.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.UserName_Txt.AutoSize = true;
            this.UserName_Txt.BackColor = System.Drawing.Color.Transparent;
            this.UserName_Txt.LinkColor = System.Drawing.Color.White;
            this.UserName_Txt.Location = new System.Drawing.Point(102, 5);
            this.UserName_Txt.Name = "UserName_Txt";
            this.UserName_Txt.Size = new System.Drawing.Size(86, 19);
            this.UserName_Txt.TabIndex = 15;
            this.UserName_Txt.TabStop = true;
            this.UserName_Txt.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "User Name:";
            // 
            // Singout_Btn
            // 
            this.Singout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Singout_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Singout_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Singout_Btn.FlatAppearance.BorderSize = 0;
            this.Singout_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Singout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Singout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Singout_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Singout_Btn.ForeColor = System.Drawing.Color.Brown;
            this.Singout_Btn.Image = global::Datally.Properties.Resources.ic_input_white_36dp;
            this.Singout_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Singout_Btn.Location = new System.Drawing.Point(985, 0);
            this.Singout_Btn.Name = "Singout_Btn";
            this.Singout_Btn.Size = new System.Drawing.Size(40, 25);
            this.Singout_Btn.TabIndex = 14;
            this.Singout_Btn.TabStop = false;
            this.Singout_Btn.UseVisualStyleBackColor = false;
            this.Singout_Btn.Click += new System.EventHandler(this.Singout_Btn_Click);
            // 
            // Main_Pan
            // 
            this.Main_Pan.AccessibleName = "";
            this.Main_Pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Main_Pan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Main_Pan.Controls.Add(this.Sub_Pan);
            this.Main_Pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Pan.Location = new System.Drawing.Point(175, 25);
            this.Main_Pan.Name = "Main_Pan";
            this.Main_Pan.Size = new System.Drawing.Size(1025, 650);
            this.Main_Pan.TabIndex = 15;
            // 
            // Sub_Pan
            // 
            this.Sub_Pan.AccessibleName = "";
            this.Sub_Pan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Sub_Pan.Controls.Add(this.HReception_Btn);
            this.Sub_Pan.Controls.Add(this.panel1);
            this.Sub_Pan.Controls.Add(this.HSearch_Btn);
            this.Sub_Pan.Controls.Add(this.HReport_Btn);
            this.Sub_Pan.Controls.Add(this.HRadiology_Btn);
            this.Sub_Pan.Controls.Add(this.HSettings_Btn);
            this.Sub_Pan.Controls.Add(this.HAbout_Btn);
            this.Sub_Pan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sub_Pan.Location = new System.Drawing.Point(0, 0);
            this.Sub_Pan.Name = "Sub_Pan";
            this.Sub_Pan.Size = new System.Drawing.Size(1021, 646);
            this.Sub_Pan.TabIndex = 18;
            // 
            // HReception_Btn
            // 
            this.HReception_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HReception_Btn.Enabled = false;
            this.HReception_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReception_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReception_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReception_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReception_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HReception_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HReception_Btn.ForeColor = System.Drawing.Color.White;
            this.HReception_Btn.Image = ((System.Drawing.Image)(resources.GetObject("HReception_Btn.Image")));
            this.HReception_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HReception_Btn.Location = new System.Drawing.Point(81, 146);
            this.HReception_Btn.Name = "HReception_Btn";
            this.HReception_Btn.Size = new System.Drawing.Size(220, 85);
            this.HReception_Btn.TabIndex = 31;
            this.HReception_Btn.Tag = "Reception";
            this.HReception_Btn.Text = "Reception\r\n   Enter The Data of Patients";
            this.HReception_Btn.UseVisualStyleBackColor = false;
            this.HReception_Btn.Click += new System.EventHandler(this.Reception_Btn_Click);
            this.HReception_Btn.Enter += new System.EventHandler(this.Reception_Btn_Enter);
            this.HReception_Btn.Leave += new System.EventHandler(this.Reception_Btn_Leave);
            // 
            // HSearch_Btn
            // 
            this.HSearch_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HSearch_Btn.Enabled = false;
            this.HSearch_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSearch_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSearch_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSearch_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSearch_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSearch_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSearch_Btn.ForeColor = System.Drawing.Color.White;
            this.HSearch_Btn.Image = ((System.Drawing.Image)(resources.GetObject("HSearch_Btn.Image")));
            this.HSearch_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HSearch_Btn.Location = new System.Drawing.Point(400, 146);
            this.HSearch_Btn.Name = "HSearch_Btn";
            this.HSearch_Btn.Size = new System.Drawing.Size(220, 85);
            this.HSearch_Btn.TabIndex = 32;
            this.HSearch_Btn.Tag = "Search";
            this.HSearch_Btn.Text = "Search\r\n   Search Data of The Patonets";
            this.HSearch_Btn.UseVisualStyleBackColor = false;
            this.HSearch_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            this.HSearch_Btn.Enter += new System.EventHandler(this.Search_Btn_Enter);
            this.HSearch_Btn.Leave += new System.EventHandler(this.Search_Btn_Leave);
            // 
            // HReport_Btn
            // 
            this.HReport_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HReport_Btn.Enabled = false;
            this.HReport_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReport_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReport_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReport_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HReport_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HReport_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HReport_Btn.ForeColor = System.Drawing.Color.White;
            this.HReport_Btn.Image = ((System.Drawing.Image)(resources.GetObject("HReport_Btn.Image")));
            this.HReport_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HReport_Btn.Location = new System.Drawing.Point(81, 392);
            this.HReport_Btn.Name = "HReport_Btn";
            this.HReport_Btn.Size = new System.Drawing.Size(220, 85);
            this.HReport_Btn.TabIndex = 33;
            this.HReport_Btn.Tag = "Report";
            this.HReport_Btn.Text = "Report\r\n   Show and Print a Report \r\n   of Work";
            this.HReport_Btn.UseVisualStyleBackColor = false;
            this.HReport_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            this.HReport_Btn.Enter += new System.EventHandler(this.Report_Btn_Enter);
            this.HReport_Btn.Leave += new System.EventHandler(this.Report_Btn_Leave);
            // 
            // HRadiology_Btn
            // 
            this.HRadiology_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HRadiology_Btn.Enabled = false;
            this.HRadiology_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HRadiology_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HRadiology_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HRadiology_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HRadiology_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRadiology_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HRadiology_Btn.ForeColor = System.Drawing.Color.White;
            this.HRadiology_Btn.Image = ((System.Drawing.Image)(resources.GetObject("HRadiology_Btn.Image")));
            this.HRadiology_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HRadiology_Btn.Location = new System.Drawing.Point(719, 146);
            this.HRadiology_Btn.Name = "HRadiology_Btn";
            this.HRadiology_Btn.Size = new System.Drawing.Size(220, 85);
            this.HRadiology_Btn.TabIndex = 34;
            this.HRadiology_Btn.Text = "Radiology\r\n   Manage The Templete \r\n   of Patient Reports";
            this.HRadiology_Btn.UseVisualStyleBackColor = false;
            this.HRadiology_Btn.Click += new System.EventHandler(this.Radiology_Btn_Click);
            this.HRadiology_Btn.Enter += new System.EventHandler(this.Radiology_Btn_Enter);
            this.HRadiology_Btn.Leave += new System.EventHandler(this.Radiology_Btn_Leave);
            // 
            // HSettings_Btn
            // 
            this.HSettings_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HSettings_Btn.Enabled = false;
            this.HSettings_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSettings_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSettings_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSettings_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HSettings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HSettings_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSettings_Btn.ForeColor = System.Drawing.Color.White;
            this.HSettings_Btn.Image = ((System.Drawing.Image)(resources.GetObject("HSettings_Btn.Image")));
            this.HSettings_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HSettings_Btn.Location = new System.Drawing.Point(400, 392);
            this.HSettings_Btn.Name = "HSettings_Btn";
            this.HSettings_Btn.Size = new System.Drawing.Size(220, 85);
            this.HSettings_Btn.TabIndex = 35;
            this.HSettings_Btn.Tag = "Settings";
            this.HSettings_Btn.Text = "Settings\r\n   Manage Users and Doctor\'s";
            this.HSettings_Btn.UseVisualStyleBackColor = false;
            this.HSettings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            this.HSettings_Btn.Enter += new System.EventHandler(this.Settings_Btn_Enter);
            this.HSettings_Btn.Leave += new System.EventHandler(this.Settings_Btn_Leave);
            // 
            // HAbout_Btn
            // 
            this.HAbout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.HAbout_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HAbout_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HAbout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HAbout_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.HAbout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HAbout_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HAbout_Btn.ForeColor = System.Drawing.Color.White;
            this.HAbout_Btn.Image = global::Datally.Properties.Resources.Light_Info_Outline_36;
            this.HAbout_Btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HAbout_Btn.Location = new System.Drawing.Point(719, 392);
            this.HAbout_Btn.Name = "HAbout_Btn";
            this.HAbout_Btn.Size = new System.Drawing.Size(220, 85);
            this.HAbout_Btn.TabIndex = 30;
            this.HAbout_Btn.TabStop = false;
            this.HAbout_Btn.Text = "About\r\n   More Ditails About The \r\n   Program.";
            this.HAbout_Btn.UseVisualStyleBackColor = false;
            this.HAbout_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            this.HAbout_Btn.Enter += new System.EventHandler(this.About_Btn_Enter);
            this.HAbout_Btn.Leave += new System.EventHandler(this.About_Btn_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.Per_Btn);
            this.panel1.Controls.Add(this.AddUser_Txt);
            this.panel1.Controls.Add(this.AddDoc_Txt);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 356);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // Per_Btn
            // 
            this.Per_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Per_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Per_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Per_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Per_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Per_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Per_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Per_Btn.ForeColor = System.Drawing.Color.White;
            this.Per_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Per_Btn.Image")));
            this.Per_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Per_Btn.Location = new System.Drawing.Point(26, 220);
            this.Per_Btn.Name = "Per_Btn";
            this.Per_Btn.Size = new System.Drawing.Size(150, 40);
            this.Per_Btn.TabIndex = 11;
            this.Per_Btn.Text = "Add Permission";
            this.Per_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Per_Btn.UseVisualStyleBackColor = false;
            this.Per_Btn.Visible = false;
            this.Per_Btn.Click += new System.EventHandler(this.Per_Txt_Click);
            // 
            // AddUser_Txt
            // 
            this.AddUser_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.AddUser_Txt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddUser_Txt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddUser_Txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddUser_Txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddUser_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUser_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUser_Txt.ForeColor = System.Drawing.Color.White;
            this.AddUser_Txt.Image = ((System.Drawing.Image)(resources.GetObject("AddUser_Txt.Image")));
            this.AddUser_Txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUser_Txt.Location = new System.Drawing.Point(26, 158);
            this.AddUser_Txt.Name = "AddUser_Txt";
            this.AddUser_Txt.Size = new System.Drawing.Size(150, 40);
            this.AddUser_Txt.TabIndex = 11;
            this.AddUser_Txt.Text = "Add User";
            this.AddUser_Txt.UseVisualStyleBackColor = false;
            this.AddUser_Txt.Click += new System.EventHandler(this.AddUser_Txt_Click);
            // 
            // AddDoc_Txt
            // 
            this.AddDoc_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.AddDoc_Txt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddDoc_Txt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddDoc_Txt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddDoc_Txt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.AddDoc_Txt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoc_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDoc_Txt.ForeColor = System.Drawing.Color.White;
            this.AddDoc_Txt.Image = ((System.Drawing.Image)(resources.GetObject("AddDoc_Txt.Image")));
            this.AddDoc_Txt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddDoc_Txt.Location = new System.Drawing.Point(26, 96);
            this.AddDoc_Txt.Name = "AddDoc_Txt";
            this.AddDoc_Txt.Size = new System.Drawing.Size(150, 40);
            this.AddDoc_Txt.TabIndex = 12;
            this.AddDoc_Txt.Text = "Add Doctor";
            this.AddDoc_Txt.UseVisualStyleBackColor = false;
            this.AddDoc_Txt.Click += new System.EventHandler(this.AddDoc_Txt_Click);
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Menu_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Menu_Panel.Controls.Add(this.Side_Panel);
            this.Menu_Panel.Controls.Add(this.Settings_Btn);
            this.Menu_Panel.Controls.Add(this.Radiology_Btn);
            this.Menu_Panel.Controls.Add(this.About_Btn);
            this.Menu_Panel.Controls.Add(this.Report_Btn);
            this.Menu_Panel.Controls.Add(this.Search_Btn);
            this.Menu_Panel.Controls.Add(this.Reception_Btn);
            this.Menu_Panel.Controls.Add(this.Home_Btn);
            this.Menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Panel.Location = new System.Drawing.Point(0, 25);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(175, 675);
            this.Menu_Panel.TabIndex = 16;
            // 
            // Side_Panel
            // 
            this.Side_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Side_Panel.Location = new System.Drawing.Point(0, 70);
            this.Side_Panel.Name = "Side_Panel";
            this.Side_Panel.Size = new System.Drawing.Size(10, 46);
            this.Side_Panel.TabIndex = 1;
            // 
            // Settings_Btn
            // 
            this.Settings_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Settings_Btn.Enabled = false;
            this.Settings_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Settings_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Settings_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Settings_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Settings_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Btn.ForeColor = System.Drawing.Color.White;
            this.Settings_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Settings_Btn.Image")));
            this.Settings_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings_Btn.Location = new System.Drawing.Point(10, 380);
            this.Settings_Btn.Name = "Settings_Btn";
            this.Settings_Btn.Size = new System.Drawing.Size(163, 46);
            this.Settings_Btn.TabIndex = 6;
            this.Settings_Btn.Tag = "Settings";
            this.Settings_Btn.Text = "Settings";
            this.Settings_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Settings_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Settings_Btn.UseVisualStyleBackColor = false;
            this.Settings_Btn.Click += new System.EventHandler(this.Settings_Btn_Click);
            this.Settings_Btn.Enter += new System.EventHandler(this.Settings_Btn_Enter);
            this.Settings_Btn.Leave += new System.EventHandler(this.Settings_Btn_Leave);
            // 
            // Radiology_Btn
            // 
            this.Radiology_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Radiology_Btn.Enabled = false;
            this.Radiology_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Radiology_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Radiology_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Radiology_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Radiology_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Radiology_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radiology_Btn.ForeColor = System.Drawing.Color.White;
            this.Radiology_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Radiology_Btn.Image")));
            this.Radiology_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Radiology_Btn.Location = new System.Drawing.Point(10, 318);
            this.Radiology_Btn.Name = "Radiology_Btn";
            this.Radiology_Btn.Size = new System.Drawing.Size(163, 46);
            this.Radiology_Btn.TabIndex = 5;
            this.Radiology_Btn.Text = "Radiology";
            this.Radiology_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Radiology_Btn.UseVisualStyleBackColor = false;
            this.Radiology_Btn.Click += new System.EventHandler(this.Radiology_Btn_Click);
            this.Radiology_Btn.Enter += new System.EventHandler(this.Radiology_Btn_Enter);
            this.Radiology_Btn.Leave += new System.EventHandler(this.Radiology_Btn_Leave);
            // 
            // About_Btn
            // 
            this.About_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.About_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.About_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.About_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.About_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.About_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Btn.ForeColor = System.Drawing.Color.White;
            this.About_Btn.Image = global::Datally.Properties.Resources.Light_Info_Outline_36;
            this.About_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About_Btn.Location = new System.Drawing.Point(10, 548);
            this.About_Btn.Name = "About_Btn";
            this.About_Btn.Size = new System.Drawing.Size(163, 46);
            this.About_Btn.TabIndex = 0;
            this.About_Btn.TabStop = false;
            this.About_Btn.Text = "About";
            this.About_Btn.UseVisualStyleBackColor = false;
            this.About_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            this.About_Btn.Enter += new System.EventHandler(this.About_Btn_Enter);
            this.About_Btn.Leave += new System.EventHandler(this.About_Btn_Leave);
            // 
            // Report_Btn
            // 
            this.Report_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Report_Btn.Enabled = false;
            this.Report_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Btn.ForeColor = System.Drawing.Color.White;
            this.Report_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Report_Btn.Image")));
            this.Report_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report_Btn.Location = new System.Drawing.Point(10, 256);
            this.Report_Btn.Name = "Report_Btn";
            this.Report_Btn.Size = new System.Drawing.Size(163, 46);
            this.Report_Btn.TabIndex = 4;
            this.Report_Btn.Tag = "Report";
            this.Report_Btn.Text = "Report";
            this.Report_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Report_Btn.UseVisualStyleBackColor = false;
            this.Report_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            this.Report_Btn.Enter += new System.EventHandler(this.Report_Btn_Enter);
            this.Report_Btn.Leave += new System.EventHandler(this.Report_Btn_Leave);
            // 
            // Search_Btn
            // 
            this.Search_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Search_Btn.Enabled = false;
            this.Search_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Search_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Search_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Search_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Search_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Btn.ForeColor = System.Drawing.Color.White;
            this.Search_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Search_Btn.Image")));
            this.Search_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Search_Btn.Location = new System.Drawing.Point(10, 194);
            this.Search_Btn.Name = "Search_Btn";
            this.Search_Btn.Size = new System.Drawing.Size(163, 46);
            this.Search_Btn.TabIndex = 3;
            this.Search_Btn.Tag = "Search";
            this.Search_Btn.Text = "Search";
            this.Search_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Search_Btn.UseVisualStyleBackColor = false;
            this.Search_Btn.Click += new System.EventHandler(this.Search_Btn_Click);
            this.Search_Btn.Enter += new System.EventHandler(this.Search_Btn_Enter);
            this.Search_Btn.Leave += new System.EventHandler(this.Search_Btn_Leave);
            // 
            // Reception_Btn
            // 
            this.Reception_Btn.AccessibleName = "Re";
            this.Reception_Btn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Reception_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Reception_Btn.Enabled = false;
            this.Reception_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Reception_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Reception_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Reception_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Reception_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reception_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reception_Btn.ForeColor = System.Drawing.Color.White;
            this.Reception_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Reception_Btn.Image")));
            this.Reception_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reception_Btn.Location = new System.Drawing.Point(10, 132);
            this.Reception_Btn.Name = "Reception_Btn";
            this.Reception_Btn.Size = new System.Drawing.Size(163, 46);
            this.Reception_Btn.TabIndex = 2;
            this.Reception_Btn.Tag = "Reception";
            this.Reception_Btn.Text = "Reception";
            this.Reception_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Reception_Btn.UseVisualStyleBackColor = false;
            this.Reception_Btn.Click += new System.EventHandler(this.Reception_Btn_Click);
            this.Reception_Btn.Enter += new System.EventHandler(this.Reception_Btn_Enter);
            this.Reception_Btn.Leave += new System.EventHandler(this.Reception_Btn_Leave);
            // 
            // Home_Btn
            // 
            this.Home_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Home_Btn.Enabled = false;
            this.Home_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Home_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Home_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Home_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Home_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home_Btn.ForeColor = System.Drawing.Color.White;
            this.Home_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Home_Btn.Image")));
            this.Home_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home_Btn.Location = new System.Drawing.Point(10, 70);
            this.Home_Btn.Name = "Home_Btn";
            this.Home_Btn.Size = new System.Drawing.Size(163, 46);
            this.Home_Btn.TabIndex = 1;
            this.Home_Btn.Text = "Home";
            this.Home_Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home_Btn.UseVisualStyleBackColor = false;
            this.Home_Btn.Click += new System.EventHandler(this.Home_Btn_Click);
            this.Home_Btn.Enter += new System.EventHandler(this.Home_Btn_Enter);
            this.Home_Btn.Leave += new System.EventHandler(this.Home_Btn_Leave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CancelButton = this.Minimize_Btn;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.Main_Pan);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.Header);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datally";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Datally_FormClosing);
            this.Load += new System.EventHandler(this.Datally_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.Main_Pan.ResumeLayout(false);
            this.Sub_Pan.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Menu_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimize_Btn;
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddUser_Txt;
        private System.Windows.Forms.Button AddDoc_Txt;
        public System.Windows.Forms.Panel Main_Pan;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.LinkLabel UserName_Txt;
        public System.Windows.Forms.Button Singout_Btn;
        public System.Windows.Forms.Panel Side_Panel;
        public System.Windows.Forms.Button Settings_Btn;
        public System.Windows.Forms.Button Radiology_Btn;
        public System.Windows.Forms.Button About_Btn;
        public System.Windows.Forms.Button Report_Btn;
        public System.Windows.Forms.Button Search_Btn;
        public System.Windows.Forms.Button Reception_Btn;
        public System.Windows.Forms.Button Home_Btn;
        public System.Windows.Forms.Panel Sub_Pan;
        private System.Windows.Forms.Button HReception_Btn;
        private System.Windows.Forms.Button HSearch_Btn;
        private System.Windows.Forms.Button HReport_Btn;
        private System.Windows.Forms.Button HRadiology_Btn;
        private System.Windows.Forms.Button HSettings_Btn;
        private System.Windows.Forms.Button HAbout_Btn;
        private System.Windows.Forms.Button Per_Btn;
    }
}