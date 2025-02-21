namespace Work2._1
{
	partial class FormPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
			this.panelConnector = new System.Windows.Forms.Panel();
			this.panelForm = new System.Windows.Forms.Panel();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btnObjects = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelLogin = new System.Windows.Forms.Label();
			this.labelPosition = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnChart = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.btnCalendar = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.btnProfil = new System.Windows.Forms.Button();
			this.panelBarTool = new System.Windows.Forms.Panel();
			this.labelMenu = new System.Windows.Forms.Label();
			this.pBoxCollapse = new System.Windows.Forms.PictureBox();
			this.pBoxMinimazed = new System.Windows.Forms.PictureBox();
			this.pBoxMaximazed = new System.Windows.Forms.PictureBox();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.panelConnector.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panelBarTool.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxCollapse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxMinimazed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxMaximazed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panelConnector
			// 
			this.panelConnector.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panelConnector.Controls.Add(this.panelForm);
			this.panelConnector.Controls.Add(this.panelMenu);
			this.panelConnector.Controls.Add(this.panelBarTool);
			this.panelConnector.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelConnector.Location = new System.Drawing.Point(0, 0);
			this.panelConnector.Name = "panelConnector";
			this.panelConnector.Size = new System.Drawing.Size(1500, 700);
			this.panelConnector.TabIndex = 0;
			// 
			// panelForm
			// 
			this.panelForm.BackColor = System.Drawing.SystemColors.Control;
			this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelForm.Location = new System.Drawing.Point(250, 40);
			this.panelForm.Name = "panelForm";
			this.panelForm.Size = new System.Drawing.Size(1250, 660);
			this.panelForm.TabIndex = 2;
			this.panelForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelForm_MouseDown);
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
			this.panelMenu.Controls.Add(this.btnObjects);
			this.panelMenu.Controls.Add(this.panel1);
			this.panelMenu.Controls.Add(this.btnLogout);
			this.panelMenu.Controls.Add(this.btnChart);
			this.panelMenu.Controls.Add(this.btnSetting);
			this.panelMenu.Controls.Add(this.btnCalendar);
			this.panelMenu.Controls.Add(this.btnHistory);
			this.panelMenu.Controls.Add(this.btnProfil);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 40);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(250, 660);
			this.panelMenu.TabIndex = 1;
			this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
			// 
			// btnObjects
			// 
			this.btnObjects.FlatAppearance.BorderSize = 0;
			this.btnObjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnObjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnObjects.ForeColor = System.Drawing.SystemColors.Info;
			this.btnObjects.Image = ((System.Drawing.Image)(resources.GetObject("btnObjects.Image")));
			this.btnObjects.Location = new System.Drawing.Point(0, 186);
			this.btnObjects.Name = "btnObjects";
			this.btnObjects.Size = new System.Drawing.Size(260, 50);
			this.btnObjects.TabIndex = 6;
			this.btnObjects.Text = "Объекты";
			this.btnObjects.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnObjects.UseVisualStyleBackColor = true;
			this.btnObjects.Click += new System.EventHandler(this.btnObjects_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel1.Controls.Add(this.labelEmail);
			this.panel1.Controls.Add(this.labelLogin);
			this.panel1.Controls.Add(this.labelPosition);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 124);
			this.panel1.TabIndex = 0;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelEmail.ForeColor = System.Drawing.SystemColors.Info;
			this.labelEmail.Location = new System.Drawing.Point(92, 79);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(67, 24);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Емаил";
			// 
			// labelLogin
			// 
			this.labelLogin.AutoSize = true;
			this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelLogin.ForeColor = System.Drawing.SystemColors.Info;
			this.labelLogin.Location = new System.Drawing.Point(92, 47);
			this.labelLogin.Name = "labelLogin";
			this.labelLogin.Size = new System.Drawing.Size(64, 24);
			this.labelLogin.TabIndex = 1;
			this.labelLogin.Text = "Логин";
			// 
			// labelPosition
			// 
			this.labelPosition.AutoSize = true;
			this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelPosition.ForeColor = System.Drawing.SystemColors.Info;
			this.labelPosition.Location = new System.Drawing.Point(93, 14);
			this.labelPosition.Name = "labelPosition";
			this.labelPosition.Size = new System.Drawing.Size(112, 24);
			this.labelPosition.TabIndex = 0;
			this.labelPosition.Text = "Должность";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnLogout
			// 
			this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnLogout.FlatAppearance.BorderSize = 0;
			this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogout.ForeColor = System.Drawing.SystemColors.Info;
			this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
			this.btnLogout.Location = new System.Drawing.Point(-5, 597);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(260, 51);
			this.btnLogout.TabIndex = 5;
			this.btnLogout.Text = "Выйти из профиля";
			this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnChart
			// 
			this.btnChart.FlatAppearance.BorderSize = 0;
			this.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnChart.ForeColor = System.Drawing.SystemColors.Info;
			this.btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
			this.btnChart.Location = new System.Drawing.Point(0, 410);
			this.btnChart.Name = "btnChart";
			this.btnChart.Size = new System.Drawing.Size(260, 50);
			this.btnChart.TabIndex = 4;
			this.btnChart.Text = "Статистика";
			this.btnChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnChart.UseVisualStyleBackColor = true;
			// 
			// btnSetting
			// 
			this.btnSetting.FlatAppearance.BorderSize = 0;
			this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSetting.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
			this.btnSetting.Location = new System.Drawing.Point(0, 354);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(260, 50);
			this.btnSetting.TabIndex = 3;
			this.btnSetting.Text = "Настройки";
			this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSetting.UseVisualStyleBackColor = true;
			// 
			// btnCalendar
			// 
			this.btnCalendar.FlatAppearance.BorderSize = 0;
			this.btnCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalendar.ForeColor = System.Drawing.SystemColors.Info;
			this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
			this.btnCalendar.Location = new System.Drawing.Point(0, 242);
			this.btnCalendar.Name = "btnCalendar";
			this.btnCalendar.Size = new System.Drawing.Size(260, 50);
			this.btnCalendar.TabIndex = 2;
			this.btnCalendar.Text = "Календарь";
			this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCalendar.UseVisualStyleBackColor = true;
			this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
			// 
			// btnHistory
			// 
			this.btnHistory.FlatAppearance.BorderSize = 0;
			this.btnHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHistory.ForeColor = System.Drawing.SystemColors.Info;
			this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
			this.btnHistory.Location = new System.Drawing.Point(-5, 298);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnHistory.Size = new System.Drawing.Size(260, 50);
			this.btnHistory.TabIndex = 1;
			this.btnHistory.Text = "История";
			this.btnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnHistory.UseVisualStyleBackColor = true;
			this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
			// 
			// btnProfil
			// 
			this.btnProfil.FlatAppearance.BorderSize = 0;
			this.btnProfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnProfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnProfil.ForeColor = System.Drawing.SystemColors.Info;
			this.btnProfil.Image = ((System.Drawing.Image)(resources.GetObject("btnProfil.Image")));
			this.btnProfil.Location = new System.Drawing.Point(0, 130);
			this.btnProfil.Name = "btnProfil";
			this.btnProfil.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnProfil.Size = new System.Drawing.Size(260, 50);
			this.btnProfil.TabIndex = 0;
			this.btnProfil.Text = "Клиенты";
			this.btnProfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnProfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnProfil.UseVisualStyleBackColor = true;
			this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
			// 
			// panelBarTool
			// 
			this.panelBarTool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
			this.panelBarTool.Controls.Add(this.labelMenu);
			this.panelBarTool.Controls.Add(this.pBoxCollapse);
			this.panelBarTool.Controls.Add(this.pBoxMinimazed);
			this.panelBarTool.Controls.Add(this.pBoxMaximazed);
			this.panelBarTool.Controls.Add(this.pBoxClose);
			this.panelBarTool.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBarTool.Location = new System.Drawing.Point(0, 0);
			this.panelBarTool.Name = "panelBarTool";
			this.panelBarTool.Size = new System.Drawing.Size(1500, 40);
			this.panelBarTool.TabIndex = 0;
			this.panelBarTool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarTool_MouseDown);
			// 
			// labelMenu
			// 
			this.labelMenu.AutoSize = true;
			this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMenu.ForeColor = System.Drawing.SystemColors.Info;
			this.labelMenu.Location = new System.Drawing.Point(8, 7);
			this.labelMenu.Name = "labelMenu";
			this.labelMenu.Size = new System.Drawing.Size(59, 24);
			this.labelMenu.TabIndex = 3;
			this.labelMenu.Text = "Menu";
			// 
			// pBoxCollapse
			// 
			this.pBoxCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxCollapse.Image = ((System.Drawing.Image)(resources.GetObject("pBoxCollapse.Image")));
			this.pBoxCollapse.Location = new System.Drawing.Point(1438, 6);
			this.pBoxCollapse.Name = "pBoxCollapse";
			this.pBoxCollapse.Size = new System.Drawing.Size(25, 25);
			this.pBoxCollapse.TabIndex = 3;
			this.pBoxCollapse.TabStop = false;
			this.pBoxCollapse.Visible = false;
			this.pBoxCollapse.Click += new System.EventHandler(this.pBoxCollapse_Click);
			// 
			// pBoxMinimazed
			// 
			this.pBoxMinimazed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxMinimazed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxMinimazed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxMinimazed.Image = ((System.Drawing.Image)(resources.GetObject("pBoxMinimazed.Image")));
			this.pBoxMinimazed.Location = new System.Drawing.Point(1407, 6);
			this.pBoxMinimazed.Name = "pBoxMinimazed";
			this.pBoxMinimazed.Size = new System.Drawing.Size(25, 25);
			this.pBoxMinimazed.TabIndex = 2;
			this.pBoxMinimazed.TabStop = false;
			this.pBoxMinimazed.Click += new System.EventHandler(this.pBoxMinimazed_Click);
			// 
			// pBoxMaximazed
			// 
			this.pBoxMaximazed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxMaximazed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxMaximazed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxMaximazed.Image = ((System.Drawing.Image)(resources.GetObject("pBoxMaximazed.Image")));
			this.pBoxMaximazed.Location = new System.Drawing.Point(1438, 6);
			this.pBoxMaximazed.Name = "pBoxMaximazed";
			this.pBoxMaximazed.Size = new System.Drawing.Size(25, 25);
			this.pBoxMaximazed.TabIndex = 1;
			this.pBoxMaximazed.TabStop = false;
			this.pBoxMaximazed.Click += new System.EventHandler(this.pBoxMaximazed_Click);
			// 
			// pBoxClose
			// 
			this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
			this.pBoxClose.Location = new System.Drawing.Point(1469, 6);
			this.pBoxClose.Name = "pBoxClose";
			this.pBoxClose.Size = new System.Drawing.Size(25, 25);
			this.pBoxClose.TabIndex = 0;
			this.pBoxClose.TabStop = false;
			this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1500, 700);
			this.Controls.Add(this.panelConnector);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "FormPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.FormPrincipal_Load);
			this.panelConnector.ResumeLayout(false);
			this.panelMenu.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panelBarTool.ResumeLayout(false);
			this.panelBarTool.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxCollapse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxMinimazed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxMaximazed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelConnector;
		private System.Windows.Forms.Panel panelForm;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelBarTool;
		private System.Windows.Forms.PictureBox pBoxMinimazed;
		private System.Windows.Forms.PictureBox pBoxMaximazed;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.PictureBox pBoxCollapse;
		private System.Windows.Forms.Button btnCalendar;
		private System.Windows.Forms.Button btnHistory;
		private System.Windows.Forms.Button btnProfil;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnChart;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelLogin;
		private System.Windows.Forms.Label labelPosition;
		private System.Windows.Forms.Label labelMenu;
		private System.Windows.Forms.Button btnObjects;
	}
}

