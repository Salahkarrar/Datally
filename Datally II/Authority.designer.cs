namespace Datally
{
    partial class Authorities_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MAuthority_Txt = new System.Windows.Forms.ComboBox();
            this.T_RolesBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.DatallySet = new Datally.DatallyDataSet();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.FunRole_Grid = new System.Windows.Forms.DataGridView();
            this.functionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.T_FunBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_FunRoleBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.Fun_Grid = new System.Windows.Forms.DataGridView();
            this.functionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_RolesTabAd = new Datally.DatallyDataSetTableAdapters.T_RolesTableAdapter();
            this.T_FunTabAd = new Datally.DatallyDataSetTableAdapters.T_FunctionTableAdapter();
            this.T_FunRoleTabAd = new Datally.DatallyDataSetTableAdapters.T_FunctionRoleTableAdapter();
            this.FunBindSour2 = new System.Windows.Forms.BindingSource(this.components);
            this.FunTabAd2 = new Datally.DatallyDataSetTableAdapters.T_FunctionTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).BeginInit();
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
            this.panel1.TabIndex = 9;
            // 
            // Close_Btn
            // 
            this.Close_Btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Btn.FlatAppearance.BorderSize = 0;
            this.Close_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Close_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MAuthority_Txt);
            this.panel2.Location = new System.Drawing.Point(865, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 41);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Authority:";
            // 
            // MAuthority_Txt
            // 
            this.MAuthority_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.MAuthority_Txt.DataSource = this.T_RolesBindSour;
            this.MAuthority_Txt.DisplayMember = "RoleName";
            this.MAuthority_Txt.ForeColor = System.Drawing.Color.White;
            this.MAuthority_Txt.FormattingEnabled = true;
            this.MAuthority_Txt.Location = new System.Drawing.Point(94, 6);
            this.MAuthority_Txt.Margin = new System.Windows.Forms.Padding(4);
            this.MAuthority_Txt.Name = "MAuthority_Txt";
            this.MAuthority_Txt.Size = new System.Drawing.Size(205, 27);
            this.MAuthority_Txt.TabIndex = 0;
            this.MAuthority_Txt.ValueMember = "RoleID";
            this.MAuthority_Txt.SelectedIndexChanged += new System.EventHandler(this.MAuthority_Txt_SelectedIndexChanged);
            // 
            // T_RolesBindSour
            // 
            this.T_RolesBindSour.DataMember = "T_Roles";
            this.T_RolesBindSour.DataSource = this.DatallySet;
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Add_Btn
            // 
            this.Add_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add_Btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Btn.Image = global::Datally.Properties.Resources.Light_Arrow_Right_36;
            this.Add_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_Btn.Location = new System.Drawing.Point(658, 352);
            this.Add_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(46, 78);
            this.Add_Btn.TabIndex = 12;
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Remove_Btn
            // 
            this.Remove_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Remove_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Remove_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Remove_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Remove_Btn.ForeColor = System.Drawing.Color.White;
            this.Remove_Btn.Image = global::Datally.Properties.Resources.Light_Arrow_Left_36;
            this.Remove_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Remove_Btn.Location = new System.Drawing.Point(574, 352);
            this.Remove_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(46, 78);
            this.Remove_Btn.TabIndex = 14;
            this.Remove_Btn.UseVisualStyleBackColor = false;
            this.Remove_Btn.Click += new System.EventHandler(this.Remove_Btn_Click);
            // 
            // FunRole_Grid
            // 
            this.FunRole_Grid.AllowUserToAddRows = false;
            this.FunRole_Grid.AllowUserToDeleteRows = false;
            this.FunRole_Grid.AllowUserToResizeColumns = false;
            this.FunRole_Grid.AllowUserToResizeRows = false;
            this.FunRole_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunRole_Grid.AutoGenerateColumns = false;
            this.FunRole_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FunRole_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.FunRole_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FunRole_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FunRole_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FunRole_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionIDDataGridViewTextBoxColumn1});
            this.FunRole_Grid.DataSource = this.T_FunRoleBindSour;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FunRole_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.FunRole_Grid.EnableHeadersVisualStyles = false;
            this.FunRole_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.FunRole_Grid.Location = new System.Drawing.Point(865, 118);
            this.FunRole_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.FunRole_Grid.Name = "FunRole_Grid";
            this.FunRole_Grid.ReadOnly = true;
            this.FunRole_Grid.RowHeadersVisible = false;
            this.FunRole_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.FunRole_Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.FunRole_Grid.RowTemplate.DividerHeight = 4;
            this.FunRole_Grid.RowTemplate.Height = 25;
            this.FunRole_Grid.RowTemplate.ReadOnly = true;
            this.FunRole_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FunRole_Grid.ShowCellErrors = false;
            this.FunRole_Grid.ShowCellToolTips = false;
            this.FunRole_Grid.ShowEditingIcon = false;
            this.FunRole_Grid.ShowRowErrors = false;
            this.FunRole_Grid.Size = new System.Drawing.Size(304, 631);
            this.FunRole_Grid.TabIndex = 13;
            this.FunRole_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FunRole_Grid_CellDoubleClick);
            // 
            // functionIDDataGridViewTextBoxColumn1
            // 
            this.functionIDDataGridViewTextBoxColumn1.DataPropertyName = "FunctionID";
            this.functionIDDataGridViewTextBoxColumn1.DataSource = this.T_FunBindSour;
            this.functionIDDataGridViewTextBoxColumn1.DisplayMember = "FunctionName";
            this.functionIDDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.functionIDDataGridViewTextBoxColumn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.functionIDDataGridViewTextBoxColumn1.HeaderText = "Add Function";
            this.functionIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.functionIDDataGridViewTextBoxColumn1.Name = "functionIDDataGridViewTextBoxColumn1";
            this.functionIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.functionIDDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.functionIDDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.functionIDDataGridViewTextBoxColumn1.ValueMember = "FunctionID";
            // 
            // T_FunBindSour
            // 
            this.T_FunBindSour.DataMember = "T_Function";
            this.T_FunBindSour.DataSource = this.DatallySet;
            // 
            // T_FunRoleBindSour
            // 
            this.T_FunRoleBindSour.DataMember = "T_FunctionRole";
            this.T_FunRoleBindSour.DataSource = this.DatallySet;
            // 
            // Fun_Grid
            // 
            this.Fun_Grid.AllowUserToAddRows = false;
            this.Fun_Grid.AllowUserToDeleteRows = false;
            this.Fun_Grid.AllowUserToResizeColumns = false;
            this.Fun_Grid.AllowUserToResizeRows = false;
            this.Fun_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fun_Grid.AutoGenerateColumns = false;
            this.Fun_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Fun_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Fun_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Fun_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.Fun_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fun_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionNameDataGridViewTextBoxColumn});
            this.Fun_Grid.DataSource = this.T_FunBindSour;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Fun_Grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.Fun_Grid.EnableHeadersVisualStyles = false;
            this.Fun_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Fun_Grid.Location = new System.Drawing.Point(99, 118);
            this.Fun_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Fun_Grid.Name = "Fun_Grid";
            this.Fun_Grid.ReadOnly = true;
            this.Fun_Grid.RowHeadersVisible = false;
            this.Fun_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Fun_Grid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.Fun_Grid.RowTemplate.DividerHeight = 4;
            this.Fun_Grid.RowTemplate.Height = 25;
            this.Fun_Grid.RowTemplate.ReadOnly = true;
            this.Fun_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fun_Grid.ShowCellErrors = false;
            this.Fun_Grid.ShowCellToolTips = false;
            this.Fun_Grid.ShowEditingIcon = false;
            this.Fun_Grid.ShowRowErrors = false;
            this.Fun_Grid.Size = new System.Drawing.Size(304, 631);
            this.Fun_Grid.TabIndex = 11;
            this.Fun_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Fun_Grid_CellDoubleClick);
            // 
            // functionNameDataGridViewTextBoxColumn
            // 
            this.functionNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.HeaderText = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.functionNameDataGridViewTextBoxColumn.Name = "functionNameDataGridViewTextBoxColumn";
            this.functionNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // T_RolesTabAd
            // 
            this.T_RolesTabAd.ClearBeforeFill = true;
            // 
            // T_FunTabAd
            // 
            this.T_FunTabAd.ClearBeforeFill = true;
            // 
            // T_FunRoleTabAd
            // 
            this.T_FunRoleTabAd.ClearBeforeFill = true;
            // 
            // FunBindSour2
            // 
            this.FunBindSour2.DataMember = "T_Function";
            this.FunBindSour2.DataSource = this.DatallySet;
            // 
            // FunTabAd2
            // 
            this.FunTabAd2.ClearBeforeFill = true;
            // 
            // Authorities_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1278, 808);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.FunRole_Grid);
            this.Controls.Add(this.Fun_Grid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1278, 808);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1278, 808);
            this.Name = "Authorities_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Authority";
            this.Load += new System.EventHandler(this.Authority_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Close_Btn;
        protected internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox MAuthority_Txt;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Remove_Btn;
        private System.Windows.Forms.DataGridView FunRole_Grid;
        private System.Windows.Forms.DataGridView Fun_Grid;
        private DatallyDataSet DatallySet;
        private System.Windows.Forms.BindingSource T_RolesBindSour;
        private DatallyDataSetTableAdapters.T_RolesTableAdapter T_RolesTabAd;
        private System.Windows.Forms.BindingSource T_FunBindSour;
        private DatallyDataSetTableAdapters.T_FunctionTableAdapter T_FunTabAd;
        private System.Windows.Forms.BindingSource T_FunRoleBindSour;
        private DatallyDataSetTableAdapters.T_FunctionRoleTableAdapter T_FunRoleTabAd;
        private System.Windows.Forms.BindingSource FunBindSour2;
        private DatallyDataSetTableAdapters.T_FunctionTableAdapter FunTabAd2;
        private System.Windows.Forms.DataGridViewTextBoxColumn functionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn functionIDDataGridViewTextBoxColumn1;
    }
}