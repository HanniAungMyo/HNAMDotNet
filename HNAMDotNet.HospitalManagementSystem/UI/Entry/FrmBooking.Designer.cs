namespace HNAMDotNet.HospitalManagementSystem.UI.Configuration
{
    partial class FrmBooking
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlLeft = new Guna.UI2.WinForms.Guna2Panel();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            lblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpBookingDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            lblDoctor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cboDoctor = new Guna.UI2.WinForms.Guna2ComboBox();
            lblRegistration = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cboRegistration = new Guna.UI2.WinForms.Guna2ComboBox();
            pnlRight = new Guna.UI2.WinForms.Guna2Panel();
            dgvBooking = new Guna.UI2.WinForms.Guna2DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            colNo = new DataGridViewTextBoxColumn();
            colRegistrationName = new DataGridViewTextBoxColumn();
            colRegistrationId = new DataGridViewTextBoxColumn();
            colDoctorId = new DataGridViewTextBoxColumn();
            colDocName = new DataGridViewTextBoxColumn();
            colId = new DataGridViewTextBoxColumn();
            colDateTime = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewButtonColumn();
            colDel = new DataGridViewButtonColumn();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooking).BeginInit();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.Controls.Add(btnCancel);
            pnlLeft.Controls.Add(btnSave);
            pnlLeft.Controls.Add(lblDate);
            pnlLeft.Controls.Add(dtpBookingDate);
            pnlLeft.Controls.Add(lblDoctor);
            pnlLeft.Controls.Add(cboDoctor);
            pnlLeft.Controls.Add(lblRegistration);
            pnlLeft.Controls.Add(cboRegistration);
            pnlLeft.CustomizableEdges = customizableEdges11;
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.ShadowDecoration.CustomizableEdges = customizableEdges12;
            pnlLeft.Size = new Size(488, 450);
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
            btnCancel.Location = new Point(320, 302);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnCancel.Size = new Size(115, 47);
            btnCancel.TabIndex = 7;
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
            btnSave.Location = new Point(161, 302);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSave.Size = new Size(115, 47);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += BtnSave_Click;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Location = new Point(38, 223);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(35, 22);
            lblDate.TabIndex = 5;
            lblDate.Text = "Date";
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Checked = true;
            dtpBookingDate.CustomFormat = "dd/MM/yyyy hh:mm tt";
            dtpBookingDate.CustomizableEdges = customizableEdges5;
            dtpBookingDate.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBookingDate.Format = DateTimePickerFormat.Custom;
            dtpBookingDate.Location = new Point(161, 209);
            dtpBookingDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpBookingDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpBookingDate.Size = new Size(274, 45);
            dtpBookingDate.TabIndex = 4;
            dtpBookingDate.Value = new DateTime(2024, 7, 22, 23, 2, 1, 961);
            // 
            // lblDoctor
            // 
            lblDoctor.BackColor = Color.Transparent;
            lblDoctor.Location = new Point(38, 147);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(95, 22);
            lblDoctor.TabIndex = 3;
            lblDoctor.Text = "Doctor_Name";
            // 
            // cboDoctor
            // 
            cboDoctor.BackColor = Color.Transparent;
            cboDoctor.CustomizableEdges = customizableEdges7;
            cboDoctor.DrawMode = DrawMode.OwnerDrawFixed;
            cboDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDoctor.FocusedColor = Color.FromArgb(94, 148, 255);
            cboDoctor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboDoctor.ForeColor = Color.FromArgb(68, 88, 112);
            cboDoctor.ItemHeight = 50;
            cboDoctor.Location = new Point(161, 131);
            cboDoctor.Name = "cboDoctor";
            cboDoctor.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cboDoctor.Size = new Size(274, 56);
            cboDoctor.TabIndex = 2;
            // 
            // lblRegistration
            // 
            lblRegistration.BackColor = Color.Transparent;
            lblRegistration.Location = new Point(38, 70);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(95, 22);
            lblRegistration.TabIndex = 1;
            lblRegistration.Text = "Patient_Name";
            // 
            // cboRegistration
            // 
            cboRegistration.BackColor = Color.Transparent;
            cboRegistration.CustomizableEdges = customizableEdges9;
            cboRegistration.DrawMode = DrawMode.OwnerDrawFixed;
            cboRegistration.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRegistration.FocusedColor = Color.FromArgb(94, 148, 255);
            cboRegistration.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboRegistration.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cboRegistration.ForeColor = Color.FromArgb(68, 88, 112);
            cboRegistration.ItemHeight = 50;
            cboRegistration.Location = new Point(161, 53);
            cboRegistration.Name = "cboRegistration";
            cboRegistration.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cboRegistration.Size = new Size(274, 56);
            cboRegistration.TabIndex = 0;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(dgvBooking);
            pnlRight.CustomizableEdges = customizableEdges13;
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(488, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.ShadowDecoration.CustomizableEdges = customizableEdges14;
            pnlRight.Size = new Size(595, 450);
            pnlRight.TabIndex = 0;
            // 
            // dgvBooking
            // 
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvBooking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooking.ColumnHeadersHeight = 22;
            dgvBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBooking.Columns.AddRange(new DataGridViewColumn[] { colNo, colRegistrationName, colRegistrationId, colDoctorId, colDocName, colId, colDateTime, colStatus, colDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBooking.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBooking.GridColor = Color.FromArgb(231, 229, 255);
            dgvBooking.Location = new Point(0, 0);
            dgvBooking.Name = "dgvBooking";
            dgvBooking.ReadOnly = true;
            dgvBooking.RowHeadersVisible = false;
            dgvBooking.RowHeadersWidth = 51;
            dgvBooking.RowTemplate.Height = 29;
            dgvBooking.Size = new Size(595, 450);
            dgvBooking.TabIndex = 0;
            dgvBooking.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvBooking.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvBooking.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvBooking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvBooking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvBooking.ThemeStyle.BackColor = Color.White;
            dgvBooking.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvBooking.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvBooking.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvBooking.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBooking.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvBooking.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvBooking.ThemeStyle.HeaderStyle.Height = 22;
            dgvBooking.ThemeStyle.ReadOnly = true;
            dgvBooking.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvBooking.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBooking.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dgvBooking.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvBooking.ThemeStyle.RowsStyle.Height = 29;
            dgvBooking.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvBooking.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvBooking.CellContentClick += dgvBooking_CellContentClick;
            dgvBooking.CellDoubleClick += dgvBooking_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // colNo
            // 
            colNo.DataPropertyName = "RowNumber";
            colNo.HeaderText = "No";
            colNo.MinimumWidth = 6;
            colNo.Name = "colNo";
            colNo.ReadOnly = true;
            // 
            // colRegistrationName
            // 
            colRegistrationName.DataPropertyName = "RegistrationName";
            colRegistrationName.HeaderText = "Patient_Name";
            colRegistrationName.MinimumWidth = 6;
            colRegistrationName.Name = "colRegistrationName";
            colRegistrationName.ReadOnly = true;
            // 
            // colRegistrationId
            // 
            colRegistrationId.DataPropertyName = "RegistrationId";
            colRegistrationId.HeaderText = "RegistrationId";
            colRegistrationId.MinimumWidth = 6;
            colRegistrationId.Name = "colRegistrationId";
            colRegistrationId.ReadOnly = true;
            colRegistrationId.Visible = false;
            // 
            // colDoctorId
            // 
            colDoctorId.DataPropertyName = "DoctorId";
            colDoctorId.HeaderText = "DoctorId";
            colDoctorId.MinimumWidth = 6;
            colDoctorId.Name = "colDoctorId";
            colDoctorId.ReadOnly = true;
            colDoctorId.Visible = false;
            // 
            // colDocName
            // 
            colDocName.DataPropertyName = "DoctorName";
            colDocName.HeaderText = "Doctor_Name";
            colDocName.MinimumWidth = 6;
            colDocName.Name = "colDocName";
            colDocName.ReadOnly = true;
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
            // colDateTime
            // 
            colDateTime.DataPropertyName = "BookingDate";
            colDateTime.HeaderText = "Date";
            colDateTime.MinimumWidth = 6;
            colDateTime.Name = "colDateTime";
            colDateTime.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colDel
            // 
            colDel.DataPropertyName = "Delete";
            colDel.HeaderText = "";
            colDel.MinimumWidth = 6;
            colDel.Name = "colDel";
            colDel.ReadOnly = true;
            colDel.Resizable = DataGridViewTriState.True;
            colDel.SortMode = DataGridViewColumnSortMode.Automatic;
            colDel.Text = "Delete";
            colDel.UseColumnTextForButtonValue = true;
            // 
            // FrmBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 450);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            Name = "FrmBooking";
            Text = "FrmBooking";
            Load += FrmBooking_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLeft;
        private Guna.UI2.WinForms.Guna2Panel pnlRight;
        private Guna.UI2.WinForms.Guna2ComboBox cboRegistration;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblRegistration;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDoctor;
        private Guna.UI2.WinForms.Guna2ComboBox cboDoctor;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBookingDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBooking;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colRegistrationName;
        private DataGridViewTextBoxColumn colRegistrationId;
        private DataGridViewTextBoxColumn colDoctorId;
        private DataGridViewTextBoxColumn colDocName;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewButtonColumn colStatus;
        private DataGridViewButtonColumn colDel;
    }
}