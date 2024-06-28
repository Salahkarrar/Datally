namespace Datally
{
    partial class Contract_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.T_ContractBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.DatallySet = new Datally.DatallyDataSet();
            this.Grid_Group = new System.Windows.Forms.GroupBox();
            this.User_Grid = new System.Windows.Forms.DataGridView();
            this.T_ContractTabAd = new Datally.DatallyDataSetTableAdapters.T_ContractTableAdapter();
            this.User_Group = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.Net_Txt = new System.Windows.Forms.TextBox();
            this.Amount_Txt = new System.Windows.Forms.TextBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.Discount_Txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_ContractBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            this.Grid_Group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).BeginInit();
            this.User_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Close_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 31);
            this.panel1.TabIndex = 2;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Close_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_Btn.ForeColor = System.Drawing.Color.Black;
            this.Close_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Close_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Close_Btn.Location = new System.Drawing.Point(1247, 0);
            this.Close_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Close_Btn.Name = "Close_Btn";
            this.Close_Btn.Size = new System.Drawing.Size(31, 31);
            this.Close_Btn.TabIndex = 1;
            this.Close_Btn.UseVisualStyleBackColor = false;
            this.Close_Btn.Click += new System.EventHandler(this.Close_Btn_Click);
            // 
            // T_ContractBindSour
            // 
            this.T_ContractBindSour.DataMember = "T_Contract";
            this.T_ContractBindSour.DataSource = this.DatallySet;
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Grid_Group
            // 
            this.Grid_Group.BackColor = System.Drawing.Color.Transparent;
            this.Grid_Group.Controls.Add(this.User_Grid);
            this.Grid_Group.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grid_Group.ForeColor = System.Drawing.Color.White;
            this.Grid_Group.Location = new System.Drawing.Point(0, 201);
            this.Grid_Group.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_Group.Name = "Grid_Group";
            this.Grid_Group.Padding = new System.Windows.Forms.Padding(4);
            this.Grid_Group.Size = new System.Drawing.Size(1275, 549);
            this.Grid_Group.TabIndex = 1;
            this.Grid_Group.TabStop = false;
            this.Grid_Group.Text = "Contract List";
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
            this.nameDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.netPriceDataGridViewTextBoxColumn});
            this.User_Grid.DataSource = this.T_ContractBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.User_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.User_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_Grid.EnableHeadersVisualStyles = false;
            this.User_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.User_Grid.Location = new System.Drawing.Point(4, 23);
            this.User_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.User_Grid.MultiSelect = false;
            this.User_Grid.Name = "User_Grid";
            this.User_Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.User_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.User_Grid.RowHeadersVisible = false;
            this.User_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.User_Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.User_Grid.RowTemplate.DividerHeight = 4;
            this.User_Grid.RowTemplate.Height = 25;
            this.User_Grid.RowTemplate.ReadOnly = true;
            this.User_Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.User_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.User_Grid.ShowCellErrors = false;
            this.User_Grid.ShowCellToolTips = false;
            this.User_Grid.ShowEditingIcon = false;
            this.User_Grid.ShowRowErrors = false;
            this.User_Grid.Size = new System.Drawing.Size(1267, 522);
            this.User_Grid.TabIndex = 0;
            // 
            // T_ContractTabAd
            // 
            this.T_ContractTabAd.ClearBeforeFill = true;
            // 
            // User_Group
            // 
            this.User_Group.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.User_Group.BackColor = System.Drawing.Color.Transparent;
            this.User_Group.Controls.Add(this.label5);
            this.User_Group.Controls.Add(this.Delete_Btn);
            this.User_Group.Controls.Add(this.Net_Txt);
            this.User_Group.Controls.Add(this.Amount_Txt);
            this.User_Group.Controls.Add(this.Name_Txt);
            this.User_Group.Controls.Add(this.Discount_Txt);
            this.User_Group.Controls.Add(this.label2);
            this.User_Group.Controls.Add(this.label4);
            this.User_Group.Controls.Add(this.label1);
            this.User_Group.Controls.Add(this.label3);
            this.User_Group.Controls.Add(this.New_Btn);
            this.User_Group.Controls.Add(this.Edit_Btn);
            this.User_Group.Controls.Add(this.Save_Btn);
            this.User_Group.Controls.Add(this.Cancel_Btn);
            this.User_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_Group.ForeColor = System.Drawing.Color.White;
            this.User_Group.Location = new System.Drawing.Point(300, 35);
            this.User_Group.Margin = new System.Windows.Forms.Padding(4);
            this.User_Group.Name = "User_Group";
            this.User_Group.Padding = new System.Windows.Forms.Padding(4);
            this.User_Group.Size = new System.Drawing.Size(679, 158);
            this.User_Group.TabIndex = 3;
            this.User_Group.TabStop = false;
            this.User_Group.Text = "Contract Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(317, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "%";
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
            this.Delete_Btn.Location = new System.Drawing.Point(551, 114);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(88, 31);
            this.Delete_Btn.TabIndex = 8;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            // 
            // Net_Txt
            // 
            this.Net_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Net_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ContractBindSour, "NetPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.Net_Txt.ForeColor = System.Drawing.Color.White;
            this.Net_Txt.Location = new System.Drawing.Point(458, 70);
            this.Net_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Net_Txt.Name = "Net_Txt";
            this.Net_Txt.ReadOnly = true;
            this.Net_Txt.Size = new System.Drawing.Size(181, 26);
            this.Net_Txt.TabIndex = 4;
            // 
            // Amount_Txt
            // 
            this.Amount_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Amount_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ContractBindSour, "Amount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.Amount_Txt.ForeColor = System.Drawing.Color.White;
            this.Amount_Txt.Location = new System.Drawing.Point(458, 35);
            this.Amount_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Amount_Txt.Name = "Amount_Txt";
            this.Amount_Txt.Size = new System.Drawing.Size(181, 26);
            this.Amount_Txt.TabIndex = 2;
            // 
            // Name_Txt
            // 
            this.Name_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ContractBindSour, "Name", true));
            this.Name_Txt.ForeColor = System.Drawing.Color.White;
            this.Name_Txt.Location = new System.Drawing.Point(124, 35);
            this.Name_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(226, 26);
            this.Name_Txt.TabIndex = 1;
            // 
            // Discount_Txt
            // 
            this.Discount_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Discount_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.T_ContractBindSour, "Discount", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.Discount_Txt.ForeColor = System.Drawing.Color.White;
            this.Discount_Txt.Location = new System.Drawing.Point(124, 69);
            this.Discount_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Discount_Txt.MaxLength = 10;
            this.Discount_Txt.Name = "Discount_Txt";
            this.Discount_Txt.Size = new System.Drawing.Size(226, 26);
            this.Discount_Txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(373, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Net Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Discount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name:";
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
            this.New_Btn.Location = new System.Drawing.Point(103, 114);
            this.New_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(88, 31);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.UseVisualStyleBackColor = true;
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
            this.Edit_Btn.Location = new System.Drawing.Point(313, 114);
            this.Edit_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(88, 31);
            this.Edit_Btn.TabIndex = 6;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.UseVisualStyleBackColor = true;
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
            this.Save_Btn.Location = new System.Drawing.Point(208, 114);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(88, 31);
            this.Save_Btn.TabIndex = 5;
            this.Save_Btn.Text = "Save";
            this.Save_Btn.UseVisualStyleBackColor = true;
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
            this.Cancel_Btn.Location = new System.Drawing.Point(418, 114);
            this.Cancel_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(88, 31);
            this.Cancel_Btn.TabIndex = 7;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Contract Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netPriceDataGridViewTextBoxColumn
            // 
            this.netPriceDataGridViewTextBoxColumn.DataPropertyName = "NetPrice";
            this.netPriceDataGridViewTextBoxColumn.HeaderText = "Net Price";
            this.netPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.netPriceDataGridViewTextBoxColumn.Name = "netPriceDataGridViewTextBoxColumn";
            this.netPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Contract_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1278, 808);
            this.Controls.Add(this.User_Group);
            this.Controls.Add(this.Grid_Group);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1278, 808);
            this.Name = "Contract_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.Contract_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.T_ContractBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            this.Grid_Group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.User_Grid)).EndInit();
            this.User_Group.ResumeLayout(false);
            this.User_Group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Grid_Group;
        private System.Windows.Forms.DataGridView User_Grid;
        private DatallyDataSet DatallySet;
        private System.Windows.Forms.BindingSource T_ContractBindSour;
        private DatallyDataSetTableAdapters.T_ContractTableAdapter T_ContractTabAd;
        private System.Windows.Forms.GroupBox User_Group;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.TextBox Net_Txt;
        private System.Windows.Forms.TextBox Amount_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.TextBox Discount_Txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netPriceDataGridViewTextBoxColumn;
    }
}