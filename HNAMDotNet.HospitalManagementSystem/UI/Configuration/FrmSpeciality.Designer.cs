namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    partial class FrmSpeciality
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            lblSpeciality = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSpeciality = new Guna.UI2.WinForms.Guna2TextBox();
            pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            dgvSpeciality = new Guna.UI2.WinForms.Guna2DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colSpeciality = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSpeciality).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnCancel);
            pnlLeft.Controls.Add(btnSave);
            pnlLeft.Controls.Add(lblSpeciality);
            pnlLeft.Controls.Add(txtSpeciality);
            pnlLeft.CustomizableEdges = customizableEdges7;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnlLeft.Size = new Size(486, 450);
            pnlLeft.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.SeaShell;
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Silver;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(317, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(137, 56);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            btnSave.CustomizableEdges = customizableEdges3;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(141, 262);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(137, 56);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // lblSpeciality
            // 
            lblSpeciality.BackColor = Color.Transparent;
            lblSpeciality.Location = new Point(47, 202);
            lblSpeciality.Name = "lblSpeciality";
            lblSpeciality.Size = new Size(67, 22);
            lblSpeciality.TabIndex = 1;
            lblSpeciality.Text = "Speciality";
            // 
            // txtSpeciality
            // 
            txtSpeciality.CustomizableEdges = customizableEdges5;
            txtSpeciality.DefaultText = "";
            txtSpeciality.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSpeciality.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSpeciality.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSpeciality.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSpeciality.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeciality.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSpeciality.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSpeciality.Location = new Point(141, 185);
            txtSpeciality.Margin = new Padding(3, 4, 3, 4);
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.PasswordChar = '\0';
            txtSpeciality.PlaceholderText = "";
            txtSpeciality.SelectedText = "";
            txtSpeciality.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSpeciality.Size = new Size(313, 60);
            txtSpeciality.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvSpeciality);
            pnlRight.CustomizableEdges = customizableEdges9;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(486, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlRight.Size = new Size(468, 450);
            pnlRight.TabIndex = 1;
            // 
            // dgvSpeciality
            // 
            dgvSpeciality.AllowUserToAddRows = false;
            dgvSpeciality.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSpeciality.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSpeciality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSpeciality.ColumnHeadersHeight = 22;
            dgvSpeciality.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSpeciality.Columns.AddRange(new DataGridViewColumn[] { colNo, colSpeciality, colId, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSpeciality.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSpeciality.Dock = DockStyle.Fill;
            dgvSpeciality.GridColor = Color.FromArgb(231, 229, 255);
            dgvSpeciality.Location = new Point(0, 0);
            dgvSpeciality.Name = "dgvSpeciality";
            dgvSpeciality.ReadOnly = true;
            dgvSpeciality.RowHeadersVisible = false;
            dgvSpeciality.RowHeadersWidth = 51;
            dgvSpeciality.RowTemplate.Height = 29;
            dgvSpeciality.Size = new Size(468, 450);
            dgvSpeciality.TabIndex = 0;
            dgvSpeciality.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSpeciality.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSpeciality.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSpeciality.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSpeciality.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSpeciality.ThemeStyle.BackColor = Color.White;
            dgvSpeciality.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSpeciality.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvSpeciality.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSpeciality.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSpeciality.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSpeciality.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSpeciality.ThemeStyle.HeaderStyle.Height = 22;
            dgvSpeciality.ThemeStyle.ReadOnly = true;
            dgvSpeciality.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSpeciality.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSpeciality.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvSpeciality.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSpeciality.ThemeStyle.RowsStyle.Height = 29;
            dgvSpeciality.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSpeciality.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvSpeciality.CellContentClick += dgvSpeciality_CellContentClick;
            dgvSpeciality.CellDoubleClick += dgvSpeciality_CellDoubleClick;
            // 
            // colNo
            // 
            colNo.DataPropertyName = "RowNumber";
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colSpeciality
            // 
            colSpeciality.DataPropertyName = "Name";
            colSpeciality.HeaderText = "Speciality";
            colSpeciality.MinimumWidth = 6;
            colSpeciality.Name = "colSpeciality";
            colSpeciality.ReadOnly = true;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colDelete
            // 
            colDelete.DataPropertyName = "Delete";
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Delete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // FrmSpeciality
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 450);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Name = "FrmSpeciality";
            Text = "FrmSpeciality";
            Load += FrmSpeciality_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSpeciality).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSpeciality;
        private Guna.UI2.WinForms.Guna2TextBox txtSpeciality;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSpeciality;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colSpeciality;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewButtonColumn colDelete;
    }
}