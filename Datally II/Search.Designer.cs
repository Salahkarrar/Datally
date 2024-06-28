namespace Datally
{
    partial class Search_Frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Shutdown_Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Search_Txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Search_Grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).BeginInit();
            this.SuspendLayout();
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
            this.Shutdown_Btn.Location = new System.Drawing.Point(997, 0);
            this.Shutdown_Btn.Name = "Shutdown_Btn";
            this.Shutdown_Btn.Size = new System.Drawing.Size(25, 25);
            this.Shutdown_Btn.TabIndex = 4;
            this.Shutdown_Btn.TabStop = false;
            this.Shutdown_Btn.UseVisualStyleBackColor = false;
            this.Shutdown_Btn.Click += new System.EventHandler(this.Shutdown_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(351, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search:";
            // 
            // Search_Txt
            // 
            this.Search_Txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Search_Txt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_Txt.ForeColor = System.Drawing.Color.White;
            this.Search_Txt.Location = new System.Drawing.Point(403, 50);
            this.Search_Txt.Name = "Search_Txt";
            this.Search_Txt.Size = new System.Drawing.Size(268, 26);
            this.Search_Txt.TabIndex = 6;
            this.Search_Txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Txt_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Shutdown_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 25);
            this.panel1.TabIndex = 7;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Radiologist";
            this.doctorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorDataGridViewTextBoxColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Search_Grid);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 555);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patients List";
            // 
            // Search_Grid
            // 
            this.Search_Grid.AllowUserToAddRows = false;
            this.Search_Grid.AllowUserToDeleteRows = false;
            this.Search_Grid.AllowUserToResizeColumns = false;
            this.Search_Grid.AllowUserToResizeRows = false;
            this.Search_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Search_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Search_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Search_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Search_Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Search_Grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Search_Grid.EnableHeadersVisualStyles = false;
            this.Search_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.Search_Grid.Location = new System.Drawing.Point(3, 26);
            this.Search_Grid.Margin = new System.Windows.Forms.Padding(4);
            this.Search_Grid.MultiSelect = false;
            this.Search_Grid.Name = "Search_Grid";
            this.Search_Grid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PowderBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Search_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Search_Grid.RowHeadersVisible = false;
            this.Search_Grid.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.Search_Grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Search_Grid.RowTemplate.DividerHeight = 4;
            this.Search_Grid.RowTemplate.Height = 25;
            this.Search_Grid.RowTemplate.ReadOnly = true;
            this.Search_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Search_Grid.ShowCellErrors = false;
            this.Search_Grid.ShowCellToolTips = false;
            this.Search_Grid.ShowEditingIcon = false;
            this.Search_Grid.ShowRowErrors = false;
            this.Search_Grid.Size = new System.Drawing.Size(1016, 526);
            this.Search_Grid.TabIndex = 1;
            this.Search_Grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Search_Grid_CellDoubleClick);
            // 
            // Search_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1022, 646);
            this.Controls.Add(this.Search_Txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1022, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1021, 646);
            this.Name = "Search_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datally";
            this.Load += new System.EventHandler(this.Search_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Search_Txt_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Search_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Shutdown_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Search_Txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Search_Grid;
    }
}