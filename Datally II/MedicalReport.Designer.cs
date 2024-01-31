namespace Datally
{
    partial class MedicalReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalReport));
            this.Header = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Minimize_Btn = new System.Windows.Forms.Button();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.Patiant_Group1 = new System.Windows.Forms.GroupBox();
            this.Date_Txt = new System.Windows.Forms.DateTimePicker();
            this.MedicalDataBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.datallyDataSet = new Datally.DatallyDataSet();
            this.Report_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_D_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_D_Btn = new System.Windows.Forms.Button();
            this.Cancel_D_Btn = new System.Windows.Forms.Button();
            this.ID_Txt = new System.Windows.Forms.TextBox();
            this.Age_Txt = new System.Windows.Forms.TextBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.MedicalReport_Grid = new System.Windows.Forms.DataGridView();
            this.pNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Footer = new System.Windows.Forms.Panel();
            this.Singout_Btn = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.LinkLabel();
            this.Medical_DataTabAd = new Datally.DatallyDataSetTableAdapters.Medical_DataTableAdapter();
            this.Search_Box = new System.Windows.Forms.GroupBox();
            this.Search_Txt = new System.Windows.Forms.TextBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.Patiant_Group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalDataBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datallyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalReport_Grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Footer.SuspendLayout();
            this.Search_Box.SuspendLayout();
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
            this.Header.TabIndex = 2;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImage = global::Datally.Properties.Resources.DataGo;
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
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(42, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportly";
            // 
            // Minimize_Btn
            // 
            this.Minimize_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Minimize_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Minimize_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize_Btn.FlatAppearance.BorderSize = 0;
            this.Minimize_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Minimize_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Minimize_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Minimize_Btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_Btn.Image = global::Datally.Properties.Resources.ic_remove_white_18dp;
            this.Minimize_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Minimize_Btn.Location = new System.Drawing.Point(1150, 0);
            this.Minimize_Btn.Name = "Minimize_Btn";
            this.Minimize_Btn.Size = new System.Drawing.Size(25, 25);
            this.Minimize_Btn.TabIndex = 2;
            this.Minimize_Btn.TabStop = false;
            this.Minimize_Btn.UseVisualStyleBackColor = false;
            this.Minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // Shutdown_Btn
            // 
            this.Shutdown_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Shutdown_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Shutdown_Btn.FlatAppearance.BorderSize = 0;
            this.Shutdown_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.White;
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(1175, 0);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(25, 25);
            this.Shutdown_Btn.TabIndex = 1;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // Patiant_Group1
            // 
            this.Patiant_Group1.BackColor = System.Drawing.Color.Transparent;
            this.Patiant_Group1.Controls.Add(this.Date_Txt);
            this.Patiant_Group1.Controls.Add(this.Report_Btn);
            this.Patiant_Group1.Controls.Add(this.label4);
            this.Patiant_Group1.Controls.Add(this.label3);
            this.Patiant_Group1.Controls.Add(this.label7);
            this.Patiant_Group1.Controls.Add(this.label2);
            this.Patiant_Group1.Controls.Add(this.New_D_Btn);
            this.Patiant_Group1.Controls.Add(this.Edit_Btn);
            this.Patiant_Group1.Controls.Add(this.Save_D_Btn);
            this.Patiant_Group1.Controls.Add(this.Cancel_D_Btn);
            this.Patiant_Group1.Controls.Add(this.ID_Txt);
            this.Patiant_Group1.Controls.Add(this.Age_Txt);
            this.Patiant_Group1.Controls.Add(this.Name_Txt);
            this.Patiant_Group1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patiant_Group1.ForeColor = System.Drawing.Color.White;
            this.Patiant_Group1.Location = new System.Drawing.Point(252, 41);
            this.Patiant_Group1.Name = "Patiant_Group1";
            this.Patiant_Group1.Size = new System.Drawing.Size(688, 150);
            this.Patiant_Group1.TabIndex = 0;
            this.Patiant_Group1.TabStop = false;
            this.Patiant_Group1.Text = "Patient Data";
            // 
            // Date_Txt
            // 
            this.Date_Txt.CustomFormat = "dd/MM/yyyy";
            this.Date_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MedicalDataBindSour, "P_Date", true));
            this.Date_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Txt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Txt.Location = new System.Drawing.Point(226, 64);
            this.Date_Txt.MaxDate = new System.DateTime(2025, 12, 31, 0, 0, 0, 0);
            this.Date_Txt.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.Date_Txt.Name = "Date_Txt";
            this.Date_Txt.Size = new System.Drawing.Size(98, 22);
            this.Date_Txt.TabIndex = 3;
            this.Date_Txt.Value = new System.DateTime(2021, 9, 26, 0, 0, 0, 0);
            // 
            // MedicalDataBindSour
            // 
            this.MedicalDataBindSour.DataMember = "Medical_Data";
            this.MedicalDataBindSour.DataSource = this.datallyDataSet;
            // 
            // datallyDataSet
            // 
            this.datallyDataSet.DataSetName = "DatallyDataSet";
            this.datallyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Report_Btn
            // 
            this.Report_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Report_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Btn.ForeColor = System.Drawing.Color.White;
            this.Report_Btn.Image = global::Datally.Properties.Resources.ic_folder_white_18dp;
            this.Report_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Report_Btn.Location = new System.Drawing.Point(528, 102);
            this.Report_Btn.Name = "Report_Btn";
            this.Report_Btn.Size = new System.Drawing.Size(146, 30);
            this.Report_Btn.TabIndex = 7;
            this.Report_Btn.Text = "Report";
            this.Report_Btn.UseVisualStyleBackColor = true;
            this.Report_Btn.Click += new System.EventHandler(this.Report_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID";
            // 
            // New_D_Btn
            // 
            this.New_D_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_D_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_D_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_D_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_D_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_D_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_D_Btn.ForeColor = System.Drawing.Color.White;
            this.New_D_Btn.Image = global::Datally.Properties.Resources.ic_add_circle_outline_white_18dp;
            this.New_D_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_D_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.New_D_Btn.Location = new System.Drawing.Point(528, 20);
            this.New_D_Btn.Name = "New_D_Btn";
            this.New_D_Btn.Size = new System.Drawing.Size(70, 25);
            this.New_D_Btn.TabIndex = 0;
            this.New_D_Btn.Text = "New";
            this.New_D_Btn.UseVisualStyleBackColor = true;
            this.New_D_Btn.Click += new System.EventHandler(this.New_D_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Btn.ForeColor = System.Drawing.Color.White;
            this.Edit_Btn.Image = global::Datally.Properties.Resources.ic_edit_white_18dp;
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Btn.Location = new System.Drawing.Point(604, 20);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(70, 25);
            this.Edit_Btn.TabIndex = 5;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Save_D_Btn
            // 
            this.Save_D_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_D_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_D_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_D_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_D_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_D_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_D_Btn.ForeColor = System.Drawing.Color.White;
            this.Save_D_Btn.Image = global::Datally.Properties.Resources.ic_save_white_18dp;
            this.Save_D_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_D_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_D_Btn.Location = new System.Drawing.Point(528, 62);
            this.Save_D_Btn.Name = "Save_D_Btn";
            this.Save_D_Btn.Size = new System.Drawing.Size(70, 25);
            this.Save_D_Btn.TabIndex = 4;
            this.Save_D_Btn.Text = "Save";
            this.Save_D_Btn.UseVisualStyleBackColor = true;
            this.Save_D_Btn.Click += new System.EventHandler(this.Save_D_Btn_Click);
            // 
            // Cancel_D_Btn
            // 
            this.Cancel_D_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_D_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_D_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_D_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_D_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_D_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_D_Btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_D_Btn.Image = global::Datally.Properties.Resources.ic_cancel_white_18dp;
            this.Cancel_D_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_D_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_D_Btn.Location = new System.Drawing.Point(604, 62);
            this.Cancel_D_Btn.Name = "Cancel_D_Btn";
            this.Cancel_D_Btn.Size = new System.Drawing.Size(70, 25);
            this.Cancel_D_Btn.TabIndex = 6;
            this.Cancel_D_Btn.Text = "Cancel";
            this.Cancel_D_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_D_Btn.UseVisualStyleBackColor = true;
            this.Cancel_D_Btn.Click += new System.EventHandler(this.Cancel_D_Btn_Click);
            // 
            // ID_Txt
            // 
            this.ID_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ID_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MedicalDataBindSour, "ID", true));
            this.ID_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Txt.ForeColor = System.Drawing.Color.White;
            this.ID_Txt.Location = new System.Drawing.Point(64, 29);
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.ReadOnly = true;
            this.ID_Txt.Size = new System.Drawing.Size(87, 22);
            this.ID_Txt.TabIndex = 0;
            this.ID_Txt.TabStop = false;
            // 
            // Age_Txt
            // 
            this.Age_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Age_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Age_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Age_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Age_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MedicalDataBindSour, "P_Age", true));
            this.Age_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Age_Txt.ForeColor = System.Drawing.Color.White;
            this.Age_Txt.Location = new System.Drawing.Point(64, 64);
            this.Age_Txt.MaxLength = 3;
            this.Age_Txt.Name = "Age_Txt";
            this.Age_Txt.Size = new System.Drawing.Size(87, 22);
            this.Age_Txt.TabIndex = 2;
            this.Age_Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_Txt_KeyPress);
            // 
            // Name_Txt
            // 
            this.Name_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Name_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MedicalDataBindSour, "P_Name", true));
            this.Name_Txt.ForeColor = System.Drawing.Color.White;
            this.Name_Txt.Location = new System.Drawing.Point(225, 29);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(274, 22);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.Enter += new System.EventHandler(this.Age_Txt_Enter);
            this.Name_Txt.Leave += new System.EventHandler(this.Age_Txt_Enter);
            // 
            // MedicalReport_Grid
            // 
            this.MedicalReport_Grid.AllowUserToAddRows = false;
            this.MedicalReport_Grid.AllowUserToDeleteRows = false;
            this.MedicalReport_Grid.AllowUserToResizeColumns = false;
            this.MedicalReport_Grid.AllowUserToResizeRows = false;
            this.MedicalReport_Grid.AutoGenerateColumns = false;
            this.MedicalReport_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicalReport_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.MedicalReport_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicalReport_Grid.ColumnHeadersVisible = false;
            this.MedicalReport_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNameDataGridViewTextBoxColumn});
            this.MedicalReport_Grid.DataSource = this.MedicalDataBindSour;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicalReport_Grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.MedicalReport_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicalReport_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.MedicalReport_Grid.Location = new System.Drawing.Point(3, 61);
            this.MedicalReport_Grid.MultiSelect = false;
            this.MedicalReport_Grid.Name = "MedicalReport_Grid";
            this.MedicalReport_Grid.ReadOnly = true;
            this.MedicalReport_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.MedicalReport_Grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.MedicalReport_Grid.RowTemplate.DividerHeight = 4;
            this.MedicalReport_Grid.RowTemplate.Height = 25;
            this.MedicalReport_Grid.RowTemplate.ReadOnly = true;
            this.MedicalReport_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MedicalReport_Grid.ShowCellErrors = false;
            this.MedicalReport_Grid.ShowCellToolTips = false;
            this.MedicalReport_Grid.ShowEditingIcon = false;
            this.MedicalReport_Grid.ShowRowErrors = false;
            this.MedicalReport_Grid.Size = new System.Drawing.Size(240, 586);
            this.MedicalReport_Grid.TabIndex = 0;
            // 
            // pNameDataGridViewTextBoxColumn
            // 
            this.pNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name";
            this.pNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pNameDataGridViewTextBoxColumn.Name = "pNameDataGridViewTextBoxColumn";
            this.pNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.MedicalReport_Grid);
            this.groupBox1.Controls.Add(this.Search_Box);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 650);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report List";
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Footer.Controls.Add(this.Singout_Btn);
            this.Footer.Controls.Add(this.About);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 675);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(1200, 25);
            this.Footer.TabIndex = 3;
            // 
            // Singout_Btn
            // 
            this.Singout_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.Singout_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Singout_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Singout_Btn.FlatAppearance.BorderSize = 0;
            this.Singout_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.Singout_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Singout_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Singout_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Singout_Btn.ForeColor = System.Drawing.Color.White;
            this.Singout_Btn.Image = global::Datally.Properties.Resources.ic_input_white_36dp;
            this.Singout_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Singout_Btn.Location = new System.Drawing.Point(1160, 0);
            this.Singout_Btn.Name = "Singout_Btn";
            this.Singout_Btn.Size = new System.Drawing.Size(40, 25);
            this.Singout_Btn.TabIndex = 1;
            this.Singout_Btn.TabStop = false;
            this.Singout_Btn.UseVisualStyleBackColor = false;
            this.Singout_Btn.Click += new System.EventHandler(this.Singout_Btn_Click);
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.BackColor = System.Drawing.Color.Transparent;
            this.About.Font = new System.Drawing.Font("Edwardian Script ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.About.Image = global::Datally.Properties.Resources.Copyright_white_18;
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.About.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.About.LinkColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(12, 1);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(171, 23);
            this.About.TabIndex = 0;
            this.About.TabStop = true;
            this.About.Text = "     Salah Karrar 2021";
            this.About.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.About_LinkClicked);
            // 
            // Medical_DataTabAd
            // 
            this.Medical_DataTabAd.ClearBeforeFill = true;
            // 
            // Search_Box
            // 
            this.Search_Box.Controls.Add(this.Search_Txt);
            this.Search_Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.Search_Box.ForeColor = System.Drawing.Color.White;
            this.Search_Box.Location = new System.Drawing.Point(3, 18);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Search_Box.Size = new System.Drawing.Size(240, 43);
            this.Search_Box.TabIndex = 7;
            this.Search_Box.TabStop = false;
            this.Search_Box.Text = "Serach";
            // 
            // Search_Txt
            // 
            this.Search_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Search_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Txt.ForeColor = System.Drawing.Color.White;
            this.Search_Txt.Location = new System.Drawing.Point(9, 15);
            this.Search_Txt.Name = "Search_Txt";
            this.Search_Txt.Size = new System.Drawing.Size(226, 22);
            this.Search_Txt.TabIndex = 8;
            this.Search_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Txt_KeyDown);
            // 
            // MedicalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.CancelButton = this.Minimize_Btn;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Patiant_Group1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Footer);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(150, 50);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MedicalReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportly";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Datally_FormClosing);
            this.Load += new System.EventHandler(this.MedicalReport_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.Patiant_Group1.ResumeLayout(false);
            this.Patiant_Group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalDataBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datallyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicalReport_Grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.Search_Box.ResumeLayout(false);
            this.Search_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Minimize_Btn;
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.GroupBox Patiant_Group1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button New_D_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_D_Btn;
        private System.Windows.Forms.Button Cancel_D_Btn;
        private System.Windows.Forms.TextBox ID_Txt;
        private System.Windows.Forms.TextBox Age_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.LinkLabel About;
        private System.Windows.Forms.DataGridView MedicalReport_Grid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Button Singout_Btn;
        private System.Windows.Forms.Button Report_Btn;
        private System.Windows.Forms.DateTimePicker Date_Txt;
        private DatallyDataSet datallyDataSet;
        private System.Windows.Forms.BindingSource MedicalDataBindSour;
        private DatallyDataSetTableAdapters.Medical_DataTableAdapter Medical_DataTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Search_Box;
        private System.Windows.Forms.TextBox Search_Txt;
    }
}