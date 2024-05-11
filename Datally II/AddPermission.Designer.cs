namespace Datally
{
    partial class AddPermission
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MAuthority_Txt = new System.Windows.Forms.ComboBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Remove_Btn = new System.Windows.Forms.Button();
            this.FunRole_Grid = new System.Windows.Forms.DataGridView();
            this.Fun_Grid = new System.Windows.Forms.DataGridView();
            this.DatallySet = new Datally.DatallyDataSet();
            this.T_RolesBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_RolesTabAd = new Datally.DatallyDataSetTableAdapters.T_RolesTableAdapter();
            this.T_FunBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_FunTabAd = new Datally.DatallyDataSetTableAdapters.T_FunctionTableAdapter();
            this.functionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T_FunRoleBindSour = new System.Windows.Forms.BindingSource(this.components);
            this.T_FunRoleTabAd = new Datally.DatallyDataSetTableAdapters.T_FunctionRoleTableAdapter();
            this.functionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FunBindSour2 = new System.Windows.Forms.BindingSource(this.components);
            this.T_FunTabAd2 = new Datally.DatallyDataSetTableAdapters.T_FunctionTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).BeginInit();
            this.SuspendLayout();
            // 
            // Shutdown_Btn
            // 
            this.Shutdown_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Shutdown_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Shutdown_Btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Shutdown_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Shutdown_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shutdown_Btn.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.Shutdown_Btn.ForeColor = System.Drawing.Color.White;
            this.Shutdown_Btn.Image = global::Datally.Properties.Resources.Close_white_18;
            this.Shutdown_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Shutdown_Btn.Location = new System.Drawing.Point(996, 3);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(23, 23);
            this.Shutdown_Btn.TabIndex = 2;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MAuthority_Txt);
            this.panel2.Location = new System.Drawing.Point(570, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 33);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
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
            this.MAuthority_Txt.Location = new System.Drawing.Point(75, 5);
            this.MAuthority_Txt.Name = "MAuthority_Txt";
            this.MAuthority_Txt.Size = new System.Drawing.Size(165, 23);
            this.MAuthority_Txt.TabIndex = 0;
            this.MAuthority_Txt.ValueMember = "RoleID";
            this.MAuthority_Txt.SelectedIndexChanged += new System.EventHandler(this.MAuthority_Txt_SelectedIndexChanged);
            // 
            // Add_Btn
            // 
            this.Add_Btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Add_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Add_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            this.Add_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.Add_Btn.ForeColor = System.Drawing.Color.Black;
            this.Add_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_Btn.Location = new System.Drawing.Point(526, 261);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(37, 62);
            this.Add_Btn.TabIndex = 17;
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
            this.Remove_Btn.ForeColor = System.Drawing.Color.Black;
            this.Remove_Btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Remove_Btn.Location = new System.Drawing.Point(459, 261);
            this.Remove_Btn.Name = "Remove_Btn";
            this.Remove_Btn.Size = new System.Drawing.Size(37, 62);
            this.Remove_Btn.TabIndex = 19;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FunRole_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.FunRole_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FunRole_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionIDDataGridViewTextBoxColumn});
            this.FunRole_Grid.DataSource = this.T_FunRoleBindSour;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FunRole_Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.FunRole_Grid.EnableHeadersVisualStyles = false;
            this.FunRole_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.FunRole_Grid.Location = new System.Drawing.Point(570, 73);
            this.FunRole_Grid.Name = "FunRole_Grid";
            this.FunRole_Grid.ReadOnly = true;
            this.FunRole_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.FunRole_Grid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.FunRole_Grid.RowTemplate.DividerHeight = 4;
            this.FunRole_Grid.RowTemplate.Height = 25;
            this.FunRole_Grid.RowTemplate.ReadOnly = true;
            this.FunRole_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FunRole_Grid.ShowCellErrors = false;
            this.FunRole_Grid.ShowCellToolTips = false;
            this.FunRole_Grid.ShowEditingIcon = false;
            this.FunRole_Grid.ShowRowErrors = false;
            this.FunRole_Grid.Size = new System.Drawing.Size(243, 505);
            this.FunRole_Grid.TabIndex = 18;
            this.FunRole_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FunRole_Grid_CellDoubleClick);
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(115)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Fun_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Fun_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fun_Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.functionNameDataGridViewTextBoxColumn});
            this.Fun_Grid.DataSource = this.T_FunBindSour;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Fun_Grid.DefaultCellStyle = dataGridViewCellStyle11;
            this.Fun_Grid.EnableHeadersVisualStyles = false;
            this.Fun_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(202)))), ((int)(((byte)(233)))));
            this.Fun_Grid.Location = new System.Drawing.Point(210, 73);
            this.Fun_Grid.Name = "Fun_Grid";
            this.Fun_Grid.ReadOnly = true;
            this.Fun_Grid.RowHeadersVisible = false;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.Fun_Grid.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Fun_Grid.RowTemplate.DividerHeight = 4;
            this.Fun_Grid.RowTemplate.Height = 25;
            this.Fun_Grid.RowTemplate.ReadOnly = true;
            this.Fun_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Fun_Grid.ShowCellErrors = false;
            this.Fun_Grid.ShowCellToolTips = false;
            this.Fun_Grid.ShowEditingIcon = false;
            this.Fun_Grid.ShowRowErrors = false;
            this.Fun_Grid.Size = new System.Drawing.Size(243, 505);
            this.Fun_Grid.TabIndex = 16;
            this.Fun_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Fun_Grid_CellDoubleClick);
            // 
            // DatallySet
            // 
            this.DatallySet.DataSetName = "DatallyDataSet";
            this.DatallySet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // T_RolesBindSour
            // 
            this.T_RolesBindSour.DataMember = "Roles";
            this.T_RolesBindSour.DataSource = this.DatallySet;
            // 
            // T_RolesTabAd
            // 
            this.T_RolesTabAd.ClearBeforeFill = true;
            // 
            // T_FunBindSour
            // 
            this.T_FunBindSour.DataMember = "Functions";
            this.T_FunBindSour.DataSource = this.DatallySet;
            // 
            // T_FunTabAd
            // 
            this.T_FunTabAd.ClearBeforeFill = true;
            // 
            // functionNameDataGridViewTextBoxColumn
            // 
            this.functionNameDataGridViewTextBoxColumn.DataPropertyName = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.HeaderText = "FunctionName";
            this.functionNameDataGridViewTextBoxColumn.Name = "functionNameDataGridViewTextBoxColumn";
            this.functionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // T_FunRoleBindSour
            // 
            this.T_FunRoleBindSour.DataMember = "FunnctionRole";
            this.T_FunRoleBindSour.DataSource = this.DatallySet;
            // 
            // T_FunRoleTabAd
            // 
            this.T_FunRoleTabAd.ClearBeforeFill = true;
            // 
            // functionIDDataGridViewTextBoxColumn
            // 
            this.functionIDDataGridViewTextBoxColumn.DataPropertyName = "FunctionID";
            this.functionIDDataGridViewTextBoxColumn.DataSource = this.T_FunBindSour;
            this.functionIDDataGridViewTextBoxColumn.DisplayMember = "FunctionName";
            this.functionIDDataGridViewTextBoxColumn.HeaderText = "FunctionID";
            this.functionIDDataGridViewTextBoxColumn.Name = "functionIDDataGridViewTextBoxColumn";
            this.functionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.functionIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.functionIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.functionIDDataGridViewTextBoxColumn.ValueMember = "FunctionID";
            // 
            // FunBindSour2
            // 
            this.FunBindSour2.DataMember = "T_Function";
            // 
            // T_FunTabAd2
            // 
            this.T_FunTabAd2.ClearBeforeFill = true;
            // 
            // AddPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1022, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Add_Btn);
            this.Controls.Add(this.Remove_Btn);
            this.Controls.Add(this.FunRole_Grid);
            this.Controls.Add(this.Fun_Grid);
            this.Controls.Add(this.Shutdown_Btn);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1022, 600);
            this.Name = "AddPermission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Datally";
            this.Load += new System.EventHandler(this.AddPermission_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FunRole_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fun_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatallySet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.T_RolesBindSour)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.T_FunBindSour)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.T_FunRoleBindSour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FunBindSour2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Shutdown_Btn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn functionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource T_FunRoleBindSour;
        private DatallyDataSetTableAdapters.T_FunctionRoleTableAdapter T_FunRoleTabAd;
        private System.Windows.Forms.DataGridViewComboBoxColumn functionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource FunBindSour2;
        private DatallyDataSetTableAdapters.T_FunctionTableAdapter T_FunTabAd2;
    }
}