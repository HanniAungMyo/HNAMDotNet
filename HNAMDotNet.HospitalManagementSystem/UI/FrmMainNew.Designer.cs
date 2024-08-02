namespace HNAMDotNet.HospitalManagementSystem.UI
{
    partial class FrmMainNew
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainNew));
            sideBar = new FlowLayoutPanel();
            pnlSoftwareInfo = new Panel();
            btnMenuIcon = new Button();
            lblSoftwareName = new Label();
            pnlNameType = new Panel();
            btnNameType = new Button();
            panel1 = new Panel();
            btnMaritalStatus = new Button();
            panel2 = new Panel();
            btnSpeciality = new Button();
            panel3 = new Panel();
            btnDoctor = new Button();
            panel4 = new Panel();
            btnUser = new Button();
            panel5 = new Panel();
            btnRegistration = new Button();
            btn = new Panel();
            btnBooking = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            sideBar.SuspendLayout();
            pnlSoftwareInfo.SuspendLayout();
            pnlNameType.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            btn.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(3, 83, 164);
            sideBar.Controls.Add(pnlSoftwareInfo);
            sideBar.Controls.Add(pnlNameType);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(btn);
            sideBar.Cursor = Cursors.Hand;
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.MaximumSize = new Size(312, 843);
            sideBar.MinimumSize = new Size(87, 843);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(312, 843);
            sideBar.TabIndex = 0;
            // 
            // pnlSoftwareInfo
            // 
            pnlSoftwareInfo.Controls.Add(btnMenuIcon);
            pnlSoftwareInfo.Controls.Add(lblSoftwareName);
            pnlSoftwareInfo.Cursor = Cursors.Hand;
            pnlSoftwareInfo.Enabled = false;
            pnlSoftwareInfo.Location = new Point(3, 3);
            pnlSoftwareInfo.Name = "pnlSoftwareInfo";
            pnlSoftwareInfo.Size = new Size(305, 127);
            pnlSoftwareInfo.TabIndex = 0;
            // 
            // btnMenuIcon
            // 
            btnMenuIcon.BackColor = Color.Transparent;
            btnMenuIcon.FlatStyle = FlatStyle.Flat;
            btnMenuIcon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuIcon.ForeColor = Color.White;
            btnMenuIcon.Image = Properties.Resources.menu3;
            btnMenuIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuIcon.Location = new Point(11, 39);
            btnMenuIcon.Margin = new Padding(5);
            btnMenuIcon.Name = "btnMenuIcon";
            btnMenuIcon.Padding = new Padding(10, 0, 0, 0);
            btnMenuIcon.Size = new Size(60, 52);
            btnMenuIcon.TabIndex = 3;
            btnMenuIcon.Text = "           ";
            btnMenuIcon.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuIcon.UseVisualStyleBackColor = false;
            btnMenuIcon.Click += btnMenuIcon_Click;
            // 
            // lblSoftwareName
            // 
            lblSoftwareName.AutoSize = true;
            lblSoftwareName.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lblSoftwareName.ForeColor = Color.White;
            lblSoftwareName.Location = new Point(91, 45);
            lblSoftwareName.Name = "lblSoftwareName";
            lblSoftwareName.Size = new Size(98, 46);
            lblSoftwareName.TabIndex = 1;
            lblSoftwareName.Text = "HMS";
            // 
            // pnlNameType
            // 
            pnlNameType.BackColor = Color.White;
            pnlNameType.Controls.Add(btnNameType);
            pnlNameType.Location = new Point(3, 136);
            pnlNameType.Name = "pnlNameType";
            pnlNameType.Size = new Size(305, 67);
            pnlNameType.TabIndex = 1;
            // 
            // btnNameType
            // 
            btnNameType.BackColor = Color.Silver;
            btnNameType.FlatStyle = FlatStyle.Flat;
            btnNameType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNameType.ForeColor = Color.White;
            btnNameType.Image = Properties.Resources.name_type3;
            btnNameType.ImageAlign = ContentAlignment.MiddleLeft;
            btnNameType.Location = new Point(-7, -9);
            btnNameType.Margin = new Padding(5);
            btnNameType.Name = "btnNameType";
            btnNameType.Padding = new Padding(30, 0, 0, 0);
            btnNameType.Size = new Size(320, 88);
            btnNameType.TabIndex = 0;
            btnNameType.Text = "           Name Type";
            btnNameType.TextAlign = ContentAlignment.MiddleLeft;
            btnNameType.UseVisualStyleBackColor = false;
            btnNameType.Click += btnNameType_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnMaritalStatus);
            panel1.Location = new Point(3, 209);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 67);
            panel1.TabIndex = 2;
            // 
            // btnMaritalStatus
            // 
            btnMaritalStatus.BackColor = Color.Silver;
            btnMaritalStatus.FlatStyle = FlatStyle.Flat;
            btnMaritalStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMaritalStatus.ForeColor = Color.White;
            btnMaritalStatus.Image = (Image)resources.GetObject("btnMaritalStatus.Image");
            btnMaritalStatus.ImageAlign = ContentAlignment.MiddleLeft;
            btnMaritalStatus.Location = new Point(-7, -9);
            btnMaritalStatus.Name = "btnMaritalStatus";
            btnMaritalStatus.Padding = new Padding(30, 0, 0, 0);
            btnMaritalStatus.Size = new Size(320, 88);
            btnMaritalStatus.TabIndex = 0;
            btnMaritalStatus.Text = "           Marital Status";
            btnMaritalStatus.TextAlign = ContentAlignment.MiddleLeft;
            btnMaritalStatus.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSpeciality);
            panel2.Location = new Point(3, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 67);
            panel2.TabIndex = 3;
            // 
            // btnSpeciality
            // 
            btnSpeciality.BackColor = Color.Silver;
            btnSpeciality.FlatStyle = FlatStyle.Flat;
            btnSpeciality.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSpeciality.ForeColor = Color.White;
            btnSpeciality.Image = (Image)resources.GetObject("btnSpeciality.Image");
            btnSpeciality.ImageAlign = ContentAlignment.MiddleLeft;
            btnSpeciality.Location = new Point(-7, -9);
            btnSpeciality.Name = "btnSpeciality";
            btnSpeciality.Padding = new Padding(30, 0, 0, 0);
            btnSpeciality.Size = new Size(320, 88);
            btnSpeciality.TabIndex = 0;
            btnSpeciality.Text = "           Speciality";
            btnSpeciality.TextAlign = ContentAlignment.MiddleLeft;
            btnSpeciality.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnDoctor);
            panel3.Location = new Point(3, 355);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 67);
            panel3.TabIndex = 4;
            // 
            // btnDoctor
            // 
            btnDoctor.BackColor = Color.Silver;
            btnDoctor.FlatStyle = FlatStyle.Flat;
            btnDoctor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDoctor.ForeColor = Color.White;
            btnDoctor.Image = (Image)resources.GetObject("btnDoctor.Image");
            btnDoctor.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctor.Location = new Point(-7, -9);
            btnDoctor.Name = "btnDoctor";
            btnDoctor.Padding = new Padding(30, 0, 0, 0);
            btnDoctor.Size = new Size(320, 88);
            btnDoctor.TabIndex = 0;
            btnDoctor.Text = "           Doctor";
            btnDoctor.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctor.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnUser);
            panel4.Location = new Point(3, 428);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 67);
            panel4.TabIndex = 5;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Silver;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUser.ForeColor = Color.White;
            btnUser.Image = (Image)resources.GetObject("btnUser.Image");
            btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnUser.Location = new Point(-7, -9);
            btnUser.Name = "btnUser";
            btnUser.Padding = new Padding(30, 0, 0, 0);
            btnUser.Size = new Size(320, 88);
            btnUser.TabIndex = 0;
            btnUser.Text = "           User";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(btnRegistration);
            panel5.Location = new Point(3, 501);
            panel5.Name = "panel5";
            panel5.Size = new Size(305, 67);
            panel5.TabIndex = 6;
            // 
            // btnRegistration
            // 
            btnRegistration.BackColor = Color.Silver;
            btnRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistration.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegistration.ForeColor = Color.White;
            btnRegistration.Image = (Image)resources.GetObject("btnRegistration.Image");
            btnRegistration.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistration.Location = new Point(-7, -9);
            btnRegistration.Name = "btnRegistration";
            btnRegistration.Padding = new Padding(30, 0, 0, 0);
            btnRegistration.Size = new Size(320, 88);
            btnRegistration.TabIndex = 0;
            btnRegistration.Text = "          Registration";
            btnRegistration.TextAlign = ContentAlignment.MiddleLeft;
            btnRegistration.UseVisualStyleBackColor = false;
            // 
            // btn
            // 
            btn.BackColor = Color.White;
            btn.Controls.Add(btnBooking);
            btn.Location = new Point(3, 574);
            btn.Name = "btn";
            btn.Size = new Size(305, 67);
            btn.TabIndex = 7;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.Silver;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBooking.ForeColor = Color.White;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(-7, -9);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(30, 0, 0, 0);
            btnBooking.Size = new Size(320, 88);
            btnBooking.TabIndex = 0;
            btnBooking.Text = "          Booking";
            btnBooking.TextAlign = ContentAlignment.MiddleLeft;
            btnBooking.UseVisualStyleBackColor = false;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // FrmMainNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 843);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMainNew";
            Text = "FrmMainNew";
            sideBar.ResumeLayout(false);
            pnlSoftwareInfo.ResumeLayout(false);
            pnlSoftwareInfo.PerformLayout();
            pnlNameType.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            btn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sideBar;
        private Panel pnlNameType;
        private Button btnNameType;
        private Panel panel1;
        private Button btnMaritalStatus;
        private Panel panel2;
        private Button btnSpeciality;
        private Panel panel3;
        private Button btnDoctor;
        private Panel panel4;
        private Button btnUser;
        private Panel panel5;
        private Button btnRegistration;
        private Panel btn;
        private Button btnBooking;
        private Label lblSoftwareName;
        private System.Windows.Forms.Timer sideBarTimer;
        private Button btnMenuIcon;
        private Panel pnlSoftwareInfo;
    }
}