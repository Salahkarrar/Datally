namespace Datally
{
    partial class RefDoc_Frm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefDoc_Grid = new System.Windows.Forms.DataGridView();
            this.RefDocBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.DatallySet = new Datally.DatallyDataSet();
            this.Patiant_Group1 = new System.Windows.Forms.GroupBox();
            this.Delete_Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Btn = new System.Windows.Forms.Button();
            this.Edit_Btn = new System.Windows.Forms.Button();
            this.Save_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.ID_Txt = new System.Windows.Forms.TextBox();
            this.Name_Txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.RefDocTabAd = new Datally.DatallyDataSetTableAdapters.RefDoctorTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RefDoc_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefDocBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            this.Patiant_Group1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.RefDoc_Grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1278, 606);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ref. Doctors List";
            // 
            // RefDoc_Grid
            // 
            this.RefDoc_Grid.AllowUserToAddRows = false;
            this.RefDoc_Grid.AllowUserToDeleteRows = false;
            this.RefDoc_Grid.AllowUserToResizeColumns = false;
            this.RefDoc_Grid.AllowUserToResizeRows = false;
            this.RefDoc_Grid.AutoGenerateColumns = false;
            this.RefDoc_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RefDoc_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.RefDoc_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RefDoc_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RefDoc_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RefDoc_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.RefName});
            this.RefDoc_Grid.DataSource = this.RefDocBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RefDoc_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RefDoc_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefDoc_Grid.EnableHeadersVisualStyles = false;
            this.RefDoc_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.RefDoc_Grid.Location = new System.Drawing.Point(4, 23);
            this.RefDoc_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.RefDoc_Grid.MultiSelect = false;
            this.RefDoc_Grid.Name = "RefDoc_Grid";
            this.RefDoc_Grid.ReadOnly = true;
            this.RefDoc_Grid.RowHeadersVisible = false;
            this.RefDoc_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.RefDoc_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.RefDoc_Grid.RowTemplate.DividerHeight = 4;
            this.RefDoc_Grid.RowTemplate.Height = 25;
            this.RefDoc_Grid.RowTemplate.ReadOnly = true;
            this.RefDoc_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RefDoc_Grid.ShowCellErrors = false;
            this.RefDoc_Grid.ShowCellToolTips = false;
            this.RefDoc_Grid.ShowEditingIcon = false;
            this.RefDoc_Grid.ShowRowErrors = false;
            this.RefDoc_Grid.Size = new System.Drawing.Size(1270, 579);
            this.RefDoc_Grid.TabIndex = 0;
            // 
            // RefDocBindSour
            // 
            this.RefDocBindSour.DataMember = "RefDoctor";
            this.RefDocBindSour.DataSource = this.DatallySet;
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Patiant_Group1
            // 
            this.Patiant_Group1.BackColor = System.Drawing.Color.Transparent;
            this.Patiant_Group1.Controls.Add(this.Delete_Btn);
            this.Patiant_Group1.Controls.Add(this.label3);
            this.Patiant_Group1.Controls.Add(this.label2);
            this.Patiant_Group1.Controls.Add(this.New_Btn);
            this.Patiant_Group1.Controls.Add(this.Edit_Btn);
            this.Patiant_Group1.Controls.Add(this.Save_Btn);
            this.Patiant_Group1.Controls.Add(this.Cancel_Btn);
            this.Patiant_Group1.Controls.Add(this.ID_Txt);
            this.Patiant_Group1.Controls.Add(this.Name_Txt);
            this.Patiant_Group1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patiant_Group1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patiant_Group1.ForeColor = System.Drawing.Color.White;
            this.Patiant_Group1.Location = new System.Drawing.Point(343, 36);
            this.Patiant_Group1.Margin = new System.Windows.Forms.Padding(4);
            this.Patiant_Group1.Name = "Patiant_Group1";
            this.Patiant_Group1.Padding = new System.Windows.Forms.Padding(4);
            this.Patiant_Group1.Size = new System.Drawing.Size(593, 158);
            this.Patiant_Group1.TabIndex = 0;
            this.Patiant_Group1.TabStop = false;
            this.Patiant_Group1.Text = "Ref. Doctors Data";
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
            this.Delete_Btn.Location = new System.Drawing.Point(480, 108);
            this.Delete_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_Btn.Name = "Delete_Btn";
            this.Delete_Btn.Size = new System.Drawing.Size(88, 31);
            this.Delete_Btn.TabIndex = 6;
            this.Delete_Btn.Text = "Delete";
            this.Delete_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Delete_Btn.UseVisualStyleBackColor = true;
            this.Delete_Btn.Click += new System.EventHandler(this.Delete_Btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID :";
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
            this.New_Btn.Location = new System.Drawing.Point(25, 108);
            this.New_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.New_Btn.Name = "New_Btn";
            this.New_Btn.Size = new System.Drawing.Size(88, 31);
            this.New_Btn.TabIndex = 0;
            this.New_Btn.Text = "New";
            this.New_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.New_Btn.UseVisualStyleBackColor = true;
            this.New_Btn.Click += new System.EventHandler(this.New_Btn_Click);
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
            this.Edit_Btn.Location = new System.Drawing.Point(243, 108);
            this.Edit_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Edit_Btn.Name = "Edit_Btn";
            this.Edit_Btn.Size = new System.Drawing.Size(88, 31);
            this.Edit_Btn.TabIndex = 4;
            this.Edit_Btn.Text = "Edit";
            this.Edit_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.Save_Btn.Location = new System.Drawing.Point(134, 108);
            this.Save_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Save_Btn.Name = "Save_Btn";
            this.Save_Btn.Size = new System.Drawing.Size(88, 31);
            this.Save_Btn.TabIndex = 3;
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
            this.Cancel_Btn.Image = global::Datally.Properties.Resources.ic_cancel_white_18dp;
            this.Cancel_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Cancel_Btn.Location = new System.Drawing.Point(352, 108);
            this.Cancel_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(88, 31);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // ID_Txt
            // 
            this.ID_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ID_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RefDocBindSour, "ID", true));
            this.ID_Txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Txt.ForeColor = System.Drawing.Color.White;
            this.ID_Txt.Location = new System.Drawing.Point(92, 27);
            this.ID_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.ID_Txt.Name = "ID_Txt";
            this.ID_Txt.ReadOnly = true;
            this.ID_Txt.Size = new System.Drawing.Size(108, 27);
            this.ID_Txt.TabIndex = 1;
            this.ID_Txt.TabStop = false;
            // 
            // Name_Txt
            // 
            this.Name_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Name_Txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Name_Txt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RefDocBindSour, "RefName", true));
            this.Name_Txt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Txt.ForeColor = System.Drawing.Color.White;
            this.Name_Txt.Location = new System.Drawing.Point(92, 63);
            this.Name_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.Name_Txt.Name = "Name_Txt";
            this.Name_Txt.Size = new System.Drawing.Size(412, 27);
            this.Name_Txt.TabIndex = 2;
            this.Name_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 31);
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
            this.Shutdown_Btn.Location = new System.Drawing.Point(1247, 0);
            this.Shutdown_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(31, 31);
            this.Shutdown_Btn.TabIndex = 0;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // RefDocTabAd
            // 
            this.RefDocTabAd.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 250;
            // 
            // RefName
            // 
            this.RefName.DataPropertyName = "RefName";
            this.RefName.HeaderText = "References Doctor";
            this.RefName.MinimumWidth = 6;
            this.RefName.Name = "RefName";
            this.RefName.ReadOnly = true;
            // 
            // RefDoc_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1278, 808);
            this.Controls.Add(this.Patiant_Group1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 875);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1276, 808);
            this.Name = "RefDoc_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "RefDoctor_Frm";
            this.Load += new System.EventHandler(this.RefDoctor_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RefDoc_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefDocBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            this.Patiant_Group1.ResumeLayout(false);
            this.Patiant_Group1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Patiant_Group1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button New_Btn;
        private System.Windows.Forms.Button Edit_Btn;
        private System.Windows.Forms.Button Save_Btn;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.TextBox ID_Txt;
        private System.Windows.Forms.TextBox Name_Txt;
        private System.Windows.Forms.DataGridView RefDoc_Grid;
        private Datally.DatallyDataSet DatallySet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource RefDocBindSour;
        private DatallyDataSetTableAdapters.RefDoctorTableAdapter RefDocTabAd;
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.Button Delete_Btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RefName;
    }
}