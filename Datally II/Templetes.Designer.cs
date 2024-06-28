namespace Datally
{
    partial class Templetes_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Templetes_Frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.Services_Label = new System.Windows.Forms.Label();
            this.Tittle_Txt = new System.Windows.Forms.TextBox();
            this.DatallySet = new Datally.DatallyDataSet();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Templete_Btn = new System.Windows.Forms.Button();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Templete_Grid = new System.Windows.Forms.DataGridView();
            this.CTBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.USBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Category_Grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Report_Txt = new System.Windows.Forms.RichTextBox();
            this.MriBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.MriTableAdapter = new Datally.DatallyDataSetTableAdapters.MRITableAdapter();
            this.CtTableAdapter = new Datally.DatallyDataSetTableAdapters.CTTableAdapter();
            this.XrayBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.x_RAYTableAdapter = new Datally.DatallyDataSetTableAdapters.X_RAYTableAdapter();
            this.USTableAdapter = new Datally.DatallyDataSetTableAdapters.USTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Templete_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MriBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XrayBindSour)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(1245, 0);
            this.Shutdown_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(31, 31);
            this.Shutdown_Btn.TabIndex = 0;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // Services_Label
            // 
            this.Services_Label.AutoSize = true;
            this.Services_Label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services_Label.ForeColor = System.Drawing.Color.White;
            this.Services_Label.Location = new System.Drawing.Point(158, 184);
            this.Services_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Services_Label.Name = "Services_Label";
            this.Services_Label.Size = new System.Drawing.Size(77, 19);
            this.Services_Label.TabIndex = 10;
            this.Services_Label.Text = "Category";
            // 
            // Tittle_Txt
            // 
            this.Tittle_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Tittle_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle_Txt.ForeColor = System.Drawing.Color.White;
            this.Tittle_Txt.Location = new System.Drawing.Point(622, 94);
            this.Tittle_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Tittle_Txt.Name = "Tittle_Txt";
            this.Tittle_Txt.Size = new System.Drawing.Size(464, 26);
            this.Tittle_Txt.TabIndex = 2;
            this.Tittle_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tittle_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tittle_Txt_KeyDown);
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Name_Txt
            // 
            this.Name_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Name_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Txt.ForeColor = System.Drawing.Color.White;
            this.Name_Txt.Location = new System.Drawing.Point(622, 55);
            this.Name_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(464, 26);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tittle_Txt_KeyDown);
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Enabled = false;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Delete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Btn.Image = global::Datally.Properties.Resources.Dark_Delete_18;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.Location = new System.Drawing.Point(990, 765);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(88, 31);
            this.Delete_Btn.TabIndex = 7;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Save_Btn
            // 
            this.Save_Btn.Enabled = false;
            this.Save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_Btn.ForeColor = System.Drawing.Color.White;
            this.Save_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Save_Btn.Image")));
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.Location = new System.Drawing.Point(559, 765);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(88, 31);
            this.Save_Btn.TabIndex = 4;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Enabled = false;
            this.Cancel_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Cancel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Cancel_Btn.Image")));
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.Location = new System.Drawing.Point(774, 765);
            this.Cancel_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(88, 31);
            this.Cancel_Btn.TabIndex = 6;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Edit_Btn
            // 
            this.Edit_Btn.Enabled = false;
            this.Edit_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Edit_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_Btn.ForeColor = System.Drawing.Color.White;
            this.Edit_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Btn.Image")));
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.Location = new System.Drawing.Point(666, 765);
            this.Edit_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(88, 31);
            this.Edit_Btn.TabIndex = 5;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
            // 
            // Templete_Btn
            // 
            this.Templete_Btn.Enabled = false;
            this.Templete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Templete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Templete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Templete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Templete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Templete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Templete_Btn.ForeColor = System.Drawing.Color.White;
            this.Templete_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Templete_Btn.Image")));
            this.Templete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Templete_Btn.Location = new System.Drawing.Point(131, 765);
            this.Templete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Templete_Btn.Name = "Templete_Btn";
            this.Templete_Btn.Size = new System.Drawing.Size(112, 31);
            this.Templete_Btn.TabIndex = 8;
            this.Templete_Btn.Text = "Template";
            this.Templete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Templete_Btn.UseVisualStyleBackColor = true;
            this.Templete_Btn.Click += new System.EventHandler(this.Templete_Click);
            // 
            // New_Btn
            // 
            this.New_Btn.Enabled = false;
            this.New_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.New_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_Btn.ForeColor = System.Drawing.Color.White;
            this.New_Btn.Image = ((System.Drawing.Image)(resources.GetObject("New_Btn.Image")));
            this.New_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Btn.Location = new System.Drawing.Point(451, 765);
            this.New_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(88, 31);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
            // 
            // Templete_Grid
            // 
            this.Templete_Grid.AllowUserToAddRows = false;
            this.Templete_Grid.AllowUserToDeleteRows = false;
            this.Templete_Grid.AllowUserToResizeColumns = false;
            this.Templete_Grid.AllowUserToResizeRows = false;
            this.Templete_Grid.AutoGenerateColumns = false;
            this.Templete_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Templete_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Templete_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Templete_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Templete_Grid.ColumnHeadersVisible = false;
            this.Templete_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tittle});
            this.Templete_Grid.DataSource = this.CTBindSour;
            this.Templete_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Templete_Grid.Location = new System.Drawing.Point(12, 206);
            this.Templete_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Templete_Grid.MultiSelect = false;
            this.Templete_Grid.Name = "Templete_Grid";
            this.Templete_Grid.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Templete_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Templete_Grid.RowHeadersVisible = false;
            this.Templete_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Templete_Grid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Templete_Grid.RowTemplate.DividerHeight = 4;
            this.Templete_Grid.ShowCellToolTips = false;
            this.Templete_Grid.Size = new System.Drawing.Size(394, 548);
            this.Templete_Grid.TabIndex = 11;
            this.Templete_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Templete_Grid_CellDoubleClick);
            this.Templete_Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Templete_Grid_KeyDown);
            // 
            // CTBindSour
            // 
            this.CTBindSour.DataMember = "CT";
            this.CTBindSour.DataSource = this.DatallySet;
            // 
            // USBindSour
            // 
            this.USBindSour.DataMember = "US";
            this.USBindSour.DataSource = this.DatallySet;
            // 
            // Category_Grid
            // 
            this.Category_Grid.AllowUserToAddRows = false;
            this.Category_Grid.AllowUserToDeleteRows = false;
            this.Category_Grid.AllowUserToResizeColumns = false;
            this.Category_Grid.AllowUserToResizeRows = false;
            this.Category_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Category_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Category_Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Category_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Category_Grid.ColumnHeadersVisible = false;
            this.Category_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Category_Grid.Location = new System.Drawing.Point(12, 36);
            this.Category_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Category_Grid.MultiSelect = false;
            this.Category_Grid.Name = "Category_Grid";
            this.Category_Grid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Category_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Category_Grid.RowHeadersVisible = false;
            this.Category_Grid.RowHeadersWidth = 51;
            this.Category_Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Category_Grid.RowTemplate.DividerHeight = 4;
            this.Category_Grid.ShowCellToolTips = false;
            this.Category_Grid.Size = new System.Drawing.Size(394, 144);
            this.Category_Grid.TabIndex = 9;
            this.Category_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Category_Grid_CellClick);
            this.Category_Grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Category_Grid_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(558, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tittle :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name :";
            // 
            // Report_Txt
            // 
            this.Report_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.Report_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Report_Txt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report_Txt.Location = new System.Drawing.Point(450, 152);
            this.Report_Txt.Margin = new System.Windows.Forms.Padding(5);
            this.Report_Txt.Name = "Report_Txt";
            this.Report_Txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Report_Txt.Size = new System.Drawing.Size(810, 599);
            this.Report_Txt.TabIndex = 3;
            this.Report_Txt.Text = "";
            // 
            // MriBindSour
            // 
            this.MriBindSour.DataMember = "MRI";
            this.MriBindSour.DataSource = this.DatallySet;
            // 
            // MriTableAdapter
            // 
            this.MriTableAdapter.ClearBeforeFill = true;
            // 
            // CtTableAdapter
            // 
            this.CtTableAdapter.ClearBeforeFill = true;
            // 
            // XrayBindSour
            // 
            this.XrayBindSour.DataMember = "X_RAY";
            this.XrayBindSour.DataSource = this.DatallySet;
            // 
            // x_RAYTableAdapter
            // 
            this.x_RAYTableAdapter.ClearBeforeFill = true;
            // 
            // USTableAdapter
            // 
            this.USTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 31);
            this.panel1.TabIndex = 12;
            // 
            // Tittle
            // 
            this.Tittle.DataPropertyName = "Tittle";
            this.Tittle.HeaderText = "Tittle";
            this.Tittle.MinimumWidth = 6;
            this.Tittle.Name = "Tittle";
            this.Tittle.ReadOnly = true;
            this.Tittle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Templetes_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1276, 808);
            this.Controls.Add(this.Services_Label);
            this.Controls.Add(this.Tittle_Txt);
            this.Controls.Add(this.Name_Txt);
            this.Controls.Add(this.Delete_Btn);
            this.Controls.Add(this.Save_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.Edit_Btn);
            this.Controls.Add(this.Templete_Btn);
            this.Controls.Add(this.New_Btn);
            this.Controls.Add(this.Templete_Grid);
            this.Controls.Add(this.Category_Grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Report_Txt);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1276, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1276, 808);
            this.Name = "Templetes_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Templete";
            this.Load += new System.EventHandler(this.Templates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Templete_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Category_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MriBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XrayBindSour)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.Label Services_Label;
        private System.Windows.Forms.TextBox Tittle_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Templete_Btn;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.DataGridView Templete_Grid;
        private System.Windows.Forms.DataGridView Category_Grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Report_Txt;
        private Datally.DatallyDataSet DatallySet;
        private System.Windows.Forms.BindingSource MriBindSour;
        private Datally.DatallyDataSetTableAdapters.MRITableAdapter MriTableAdapter;
        private System.Windows.Forms.BindingSource CTBindSour;
        private Datally.DatallyDataSetTableAdapters.CTTableAdapter CtTableAdapter;
        private System.Windows.Forms.BindingSource XrayBindSour;
        private Datally.DatallyDataSetTableAdapters.X_RAYTableAdapter x_RAYTableAdapter;
        private System.Windows.Forms.BindingSource USBindSour;
        private Datally.DatallyDataSetTableAdapters.USTableAdapter USTableAdapter;
        public System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tittle;
    }
}