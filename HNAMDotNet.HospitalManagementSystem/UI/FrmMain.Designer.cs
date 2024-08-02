namespace HNAMDotNet.HospitalManagementSystem.UI
{
    partial class FrmMain
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pnlData = new Guna.UI2.WinForms.Guna2Panel();
            sideBar = new Panel();
            btnLoginOut = new Button();
            btnNameType = new Button();
            btnMenuIcon = new Button();
            sideBarTimer = new System.Windows.Forms.Timer(components);
            guna2Panel1.SuspendLayout();
            pnlData.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pnlData);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(914, 816);
            guna2Panel1.TabIndex = 0;
            // 
            // pnlData
            // 
            pnlData.Controls.Add(sideBar);
            pnlData.CustomizableEdges = customizableEdges5;
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 0);
            pnlData.Name = "pnlData";
            pnlData.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pnlData.Size = new Size(914, 816);
            pnlData.TabIndex = 1;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.FromArgb(3, 83, 164);
            sideBar.Controls.Add(btnLoginOut);
            sideBar.Controls.Add(btnNameType);
            sideBar.Controls.Add(btnMenuIcon);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(331, 816);
            sideBar.TabIndex = 0;
            // 
            // btnLoginOut
            // 
            btnLoginOut.BackColor = Color.FromArgb(4, 102, 200);
            btnLoginOut.Dock = DockStyle.Bottom;
            btnLoginOut.FlatStyle = FlatStyle.Flat;
            btnLoginOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoginOut.ForeColor = Color.White;
            btnLoginOut.Image = (Image)resources.GetObject("btnLoginOut.Image");
            btnLoginOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoginOut.Location = new Point(0, 743);
            btnLoginOut.Name = "btnLoginOut";
            btnLoginOut.Padding = new Padding(30, 0, 0, 0);
            btnLoginOut.Size = new Size(331, 73);
            btnLoginOut.TabIndex = 15;
            btnLoginOut.Text = "         Login";
            btnLoginOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLoginOut.UseVisualStyleBackColor = false;
            // 
            // btnNameType
            // 
            btnNameType.BackColor = Color.FromArgb(4, 102, 200);
            btnNameType.Dock = DockStyle.Top;
            btnNameType.FlatStyle = FlatStyle.Flat;
            btnNameType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNameType.ForeColor = Color.White;
            btnNameType.Image = Properties.Resources.name_type3;
            btnNameType.ImageAlign = ContentAlignment.MiddleLeft;
            btnNameType.Location = new Point(0, 91);
            btnNameType.Margin = new Padding(5);
            btnNameType.Name = "btnNameType";
            btnNameType.Padding = new Padding(30, 0, 0, 0);
            btnNameType.Size = new Size(331, 69);
            btnNameType.TabIndex = 8;
            btnNameType.Text = "           Name Type";
            btnNameType.TextAlign = ContentAlignment.MiddleLeft;
            btnNameType.UseVisualStyleBackColor = false;
            // 
            // btnMenuIcon
            // 
            btnMenuIcon.BackColor = Color.FromArgb(3, 83, 164);
            btnMenuIcon.Dock = DockStyle.Top;
            btnMenuIcon.FlatStyle = FlatStyle.Flat;
            btnMenuIcon.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuIcon.ForeColor = Color.White;
            btnMenuIcon.Image = Properties.Resources.menu3;
            btnMenuIcon.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuIcon.Location = new Point(0, 0);
            btnMenuIcon.Margin = new Padding(5);
            btnMenuIcon.Name = "btnMenuIcon";
            btnMenuIcon.Padding = new Padding(30, 0, 0, 0);
            btnMenuIcon.Size = new Size(331, 91);
            btnMenuIcon.TabIndex = 2;
            btnMenuIcon.Text = "           HMS";
            btnMenuIcon.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuIcon.UseVisualStyleBackColor = false;
            btnMenuIcon.Click += btnMenuIcon_Click;
            // 
            // sideBarTimer
            // 
            sideBarTimer.Interval = 10;
            sideBarTimer.Tick += sideBarTimer_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 816);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMain";
            Text = "FrmMain";
            Load += FrmMain_Load;
            guna2Panel1.ResumeLayout(false);
            pnlData.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlData;
        private System.Windows.Forms.Timer sideBarTimer;
        private Panel sideBar;
        private Button btnNameType;
        private Button btnMenuIcon;
        private Button btnLoginOut;
    }
}