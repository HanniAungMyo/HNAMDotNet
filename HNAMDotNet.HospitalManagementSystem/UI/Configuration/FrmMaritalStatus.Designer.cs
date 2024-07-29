namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    partial class FrmMaritalStatus
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
            lblMarital = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtMaritalStatus = new Guna.UI2.WinForms.Guna2TextBox();
            pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            dgvMaritalStatus = new Guna.UI2.WinForms.Guna2DataGridView();
            colNo = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colMaritalStatus = new DataGridViewTextBoxColumn();
            colDel = new DataGridViewButtonColumn();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMaritalStatus).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnCancel);
            pnlLeft.Controls.Add(btnSave);
            pnlLeft.Controls.Add(lblMarital);
            pnlLeft.Controls.Add(txtMaritalStatus);
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
            btnCancel.CustomizableEdges = customizableEdges1;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Silver;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(318, 227);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(147, 56);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
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
            btnSave.Location = new Point(134, 227);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(147, 56);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // lblMarital
            // 
            lblMarital.BackColor = Color.Transparent;
            lblMarital.Location = new Point(23, 155);
            lblMarital.Name = "lblMarital";
            lblMarital.Size = new Size(96, 22);
            lblMarital.TabIndex = 1;
            lblMarital.Text = "Marital_Status";
            // 
            // txtMaritalStatus
            // 
            txtMaritalStatus.CustomizableEdges = customizableEdges5;
            txtMaritalStatus.DefaultText = "";
            txtMaritalStatus.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaritalStatus.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaritalStatus.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaritalStatus.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaritalStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaritalStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaritalStatus.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaritalStatus.Location = new Point(134, 138);
            txtMaritalStatus.Margin = new Padding(3, 4, 3, 4);
            txtMaritalStatus.Name = "txtMaritalStatus";
            txtMaritalStatus.PasswordChar = '\0';
            txtMaritalStatus.PlaceholderText = "";
            txtMaritalStatus.SelectedText = "";
            txtMaritalStatus.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtMaritalStatus.Size = new Size(331, 60);
            txtMaritalStatus.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvMaritalStatus);
            pnlRight.CustomizableEdges = customizableEdges9;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(486, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges10;
            pnlRight.Size = new Size(473, 450);
            pnlRight.TabIndex = 1;
            // 
            // dgvMaritalStatus
            // 
            dgvMaritalStatus.AllowUserToAddRows = false;
            dgvMaritalStatus.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvMaritalStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMaritalStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMaritalStatus.ColumnHeadersHeight = 22;
            dgvMaritalStatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMaritalStatus.Columns.AddRange(new DataGridViewColumn[] { colNo, colId, colMaritalStatus, colDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMaritalStatus.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMaritalStatus.GridColor = Color.FromArgb(231, 229, 255);
            dgvMaritalStatus.Location = new Point(0, 0);
            dgvMaritalStatus.Name = "dgvMaritalStatus";
            dgvMaritalStatus.ReadOnly = true;
            dgvMaritalStatus.RowHeadersVisible = false;
            dgvMaritalStatus.RowHeadersWidth = 51;
            dgvMaritalStatus.RowTemplate.Height = 29;
            dgvMaritalStatus.Size = new Size(473, 450);
            dgvMaritalStatus.TabIndex = 0;
            dgvMaritalStatus.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvMaritalStatus.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvMaritalStatus.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvMaritalStatus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvMaritalStatus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvMaritalStatus.ThemeStyle.BackColor = Color.White;
            dgvMaritalStatus.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvMaritalStatus.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvMaritalStatus.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvMaritalStatus.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvMaritalStatus.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvMaritalStatus.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvMaritalStatus.ThemeStyle.HeaderStyle.Height = 22;
            dgvMaritalStatus.ThemeStyle.ReadOnly = true;
            dgvMaritalStatus.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvMaritalStatus.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMaritalStatus.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvMaritalStatus.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvMaritalStatus.ThemeStyle.RowsStyle.Height = 29;
            dgvMaritalStatus.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvMaritalStatus.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvMaritalStatus.CellContentClick += dgvMaritalStatus_CellContentClick;
            dgvMaritalStatus.CellDoubleClick += dgvMaritalStatus_CellDoubleClick;
            // 
            // colNo
            // 
            colNo.DataPropertyName = "RowNumber";
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
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
            // colMaritalStatus
            // 
            colMaritalStatus.DataPropertyName = "Name";
            colMaritalStatus.HeaderText = "Marital_Status";
            colMaritalStatus.MinimumWidth = 6;
            colMaritalStatus.Name = "colMaritalStatus";
            colMaritalStatus.ReadOnly = true;
            // 
            // colDel
            // 
            colDel.DataPropertyName = "Delete";
            colDel.HeaderText = "";
            colDel.MinimumWidth = 6;
            colDel.Name = "colDel";
            colDel.ReadOnly = true;
            colDel.Text = "Delete";
            colDel.UseColumnTextForButtonValue = true;
            // 
            // FrmMaritalStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 450);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Name = "FrmMaritalStatus";
            Text = "FrmMatritalStatus";
            Load += FrmMaritalStatus_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMaritalStatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMarital;
        private Guna.UI2.WinForms.Guna2TextBox txtMaritalStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMaritalStatus;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colMaritalStatus;
        private DataGridViewButtonColumn colDel;
    }
}