namespace Datally
{
    partial class Users_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RolesBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.DatallySet = new Datally.DatallyDataSet();
            this.UserBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.User_Grid = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Patiant_Group1 = new System.Windows.Forms.GroupBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Auth_Txt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Pass_Txt = new System.Windows.Forms.TextBox();
            this.Phone_Txt = new System.Windows.Forms.TextBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.T_UsersTabAd = new Datally.DatallyDataSetTableAdapters.T_UsersTableAdapter();
            this.T_RolesTabAd = new Datally.DatallyDataSetTableAdapters.T_RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.RolesBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindSour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            this.Patiant_Group1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RolesBindSour
            // 
            this.RolesBindSour.DataMember = "T_Roles";
            this.RolesBindSour.DataSource = this.DatallySet;
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserBindSour
            // 
            this.UserBindSour.DataMember = "T_Users";
            this.UserBindSour.DataSource = this.DatallySet;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.User_Grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1278, 596);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users List";
            // 
            // User_Grid
            // 
            this.User_Grid.AllowUserToAddRows = false;
            this.User_Grid.AllowUserToDeleteRows = false;
            this.User_Grid.AllowUserToResizeColumns = false;
            this.User_Grid.AllowUserToResizeRows = false;
            this.User_Grid.AutoGenerateColumns = false;
            this.User_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.User_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.User_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.User_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.User_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.PWord,
            this.phoneDataGridViewTextBoxColumn,
            this.RoleID});
            this.User_Grid.DataSource = this.UserBindSour;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_Grid.DefaultCellStyle = dataGridViewCellStyle3;
            this.User_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Grid.EnableHeadersVisualStyles = false;
            this.User_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.User_Grid.Location = new System.Drawing.Point(3, 22);
            this.User_Grid.MultiSelect = false;
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.ReadOnly = true;
            this.User_Grid.RowHeadersVisible = false;
            this.User_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.User_Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.User_Grid.RowTemplate.DividerHeight = 4;
            this.User_Grid.RowTemplate.Height = 25;
            this.User_Grid.RowTemplate.ReadOnly = true;
            this.User_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_Grid.ShowCellErrors = false;
            this.User_Grid.ShowCellToolTips = false;
            this.User_Grid.ShowEditingIcon = false;
            this.User_Grid.ShowRowErrors = false;
            this.User_Grid.Size = new System.Drawing.Size(1272, 571);
            this.User_Grid.TabIndex = 0;
            this.User_Grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.User_Grid_CellFormatting);
            this.User_Grid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.User_Grid_DataBindingComplete);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 120;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PWord
            // 
            this.PWord.DataPropertyName = "PWord";
            this.PWord.HeaderText = "Password";
            this.PWord.MinimumWidth = 6;
            this.PWord.Name = "PWord";
            this.PWord.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 200;
            // 
            // RoleID
            // 
            this.RoleID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RoleID.DataPropertyName = "RoleID";
            this.RoleID.DataSource = this.RolesBindSour;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.RoleID.DefaultCellStyle = dataGridViewCellStyle2;
            this.RoleID.DisplayMember = "RoleName";
            this.RoleID.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.RoleID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RoleID.HeaderText = "Authority";
            this.RoleID.MinimumWidth = 6;
            this.RoleID.Name = "RoleID";
            this.RoleID.ReadOnly = true;
            this.RoleID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoleID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RoleID.ValueMember = "RoleID";
            this.RoleID.Width = 200;
            // 
            // Patiant_Group1
            // 
            this.Patiant_Group1.BackColor = System.Drawing.Color.Transparent;
            this.Patiant_Group1.Controls.Add(this.Delete_Btn);
            this.Patiant_Group1.Controls.Add(this.Auth_Txt);
            this.Patiant_Group1.Controls.Add(this.label4);
            this.Patiant_Group1.Controls.Add(this.label5);
            this.Patiant_Group1.Controls.Add(this.label1);
            this.Patiant_Group1.Controls.Add(this.label3);
            this.Patiant_Group1.Controls.Add(this.New_Btn);
            this.Patiant_Group1.Controls.Add(this.Edit_Btn);
            this.Patiant_Group1.Controls.Add(this.Save_Btn);
            this.Patiant_Group1.Controls.Add(this.Cancel_Btn);
            this.Patiant_Group1.Controls.Add(this.Pass_Txt);
            this.Patiant_Group1.Controls.Add(this.Phone_Txt);
            this.Patiant_Group1.Controls.Add(this.Name_Txt);
            this.Patiant_Group1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patiant_Group1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patiant_Group1.ForeColor = System.Drawing.Color.White;
            this.Patiant_Group1.Location = new System.Drawing.Point(299, 31);
            this.Patiant_Group1.Name = "Patiant_Group1";
            this.Patiant_Group1.Size = new System.Drawing.Size(681, 175);
            this.Patiant_Group1.TabIndex = 0;
            this.Patiant_Group1.TabStop = false;
            this.Patiant_Group1.Text = "Users Data";
            // 
            // Delete_Btn
            // 
            this.Delete_Btn.Enabled = false;
            this.Delete_Btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Delete_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Delete_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Delete_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Delete_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Btn.ForeColor = System.Drawing.Color.White;
            this.Delete_Btn.Image = global::Datally.Properties.Resources.Dark_Delete_18;
            this.Delete_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_Btn.Location = new System.Drawing.Point(521, 118);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(88, 31);
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // Auth_Txt
            // 
            this.Auth_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Auth_Txt.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.UserBindSour, "RoleID", true));
            this.Auth_Txt.DataSource = this.RolesBindSour;
            this.Auth_Txt.DisplayMember = "RoleName";
            this.Auth_Txt.ForeColor = System.Drawing.Color.White;
            this.Auth_Txt.FormattingEnabled = true;
            this.Auth_Txt.Location = new System.Drawing.Point(470, 65);
            this.Auth_Txt.Name = "Auth_Txt";
            this.Auth_Txt.Size = new System.Drawing.Size(179, 27);
            this.Auth_Txt.TabIndex = 4;
            this.Auth_Txt.ValueMember = "RoleID";
            this.Auth_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Authority :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name :";
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
            this.New_Btn.Image = global::Datally.Properties.Resources.ic_add_circle_outline_white_18dp;
            this.New_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.New_Btn.Location = new System.Drawing.Point(71, 118);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(88, 31);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_D_Btn_Click);
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
            this.Edit_Btn.Image = global::Datally.Properties.Resources.ic_edit_white_18dp;
            this.Edit_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Edit_Btn.Location = new System.Drawing.Point(281, 118);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(88, 31);
            this.Edit_Btn.TabIndex = 6;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
            this.Edit_Btn.Click += new System.EventHandler(this.Edit_Btn_Click);
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
            this.Save_Btn.Image = global::Datally.Properties.Resources.ic_save_white_18dp;
            this.Save_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Save_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Save_Btn.Location = new System.Drawing.Point(176, 118);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(88, 31);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
            this.Save_Btn.Click += new System.EventHandler(this.Save_D_Btn_Click);
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
            this.Cancel_Btn.Image = global::Datally.Properties.Resources.ic_cancel_white_18dp;
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_Btn.Location = new System.Drawing.Point(386, 118);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(88, 31);
            this.Cancel_Btn.TabIndex = 7;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_D_Btn_Click);
            // 
            // Pass_Txt
            // 
            this.Pass_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Pass_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pass_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindSour, "PWord", true));
            this.Pass_Txt.ForeColor = System.Drawing.Color.White;
            this.Pass_Txt.Location = new System.Drawing.Point(119, 67);
            this.Pass_Txt.Name = "Pass_Txt";
            this.Pass_Txt.Size = new System.Drawing.Size(239, 26);
            this.Pass_Txt.TabIndex = 3;
            this.Pass_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // Phone_Txt
            // 
            this.Phone_Txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Phone_Txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Phone_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Phone_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindSour, "Phone", true));
            this.Phone_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_Txt.ForeColor = System.Drawing.Color.White;
            this.Phone_Txt.Location = new System.Drawing.Point(470, 25);
            this.Phone_Txt.MaxLength = 10;
            this.Phone_Txt.Name = "Phone_Txt";
            this.Phone_Txt.Size = new System.Drawing.Size(179, 26);
            this.Phone_Txt.TabIndex = 2;
            this.Phone_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // Name_Txt
            // 
            this.Name_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Name_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.UserBindSour, "UserName", true));
            this.Name_Txt.ForeColor = System.Drawing.Color.White;
            this.Name_Txt.Location = new System.Drawing.Point(119, 25);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(239, 26);
            this.Name_Txt.TabIndex = 1;
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 25);
            this.panel1.TabIndex = 2;
            // 
            // Shutdown_Btn
            // 
            this.Shutdown_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Shutdown_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Shutdown_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Shutdown_Btn.FlatAppearance.BorderSize = 0;
            this.Shutdown_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Brown;
            this.Shutdown_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.Brown;
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(1253, 0);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(25, 25);
            this.Shutdown_Btn.TabIndex = 0;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // T_UsersTabAd
            // 
            this.T_UsersTabAd.ClearBeforeFill = true;
            // 
            // T_RolesTabAd
            // 
            this.T_RolesTabAd.ClearBeforeFill = true;
            // 
            // Users_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1278, 808);
            this.Controls.Add(this.Patiant_Group1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1278, 808);
            this.Name = "Users_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Users_Frm";
            this.Load += new System.EventHandler(this.Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RolesBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBindSour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            this.Patiant_Group1.ResumeLayout(false);
            this.Patiant_Group1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Patiant_Group1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.TextBox Phone_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.ComboBox Auth_Txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Pass_Txt;
        private Datally.DatallyDataSet DatallySet;

        private System.Windows.Forms.BindingSource UserBindSour;
        private System.Windows.Forms.BindingSource RolesBindSour;
        private System.Windows.Forms.DataGridView User_Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Shutdown_Btn;
        private DatallyDataSetTableAdapters.T_UsersTableAdapter T_UsersTabAd;
        private DatallyDataSetTableAdapters.T_RolesTableAdapter T_RolesTabAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RoleID;
        private System.Windows.Forms.Button Delete_Btn;
    }
}