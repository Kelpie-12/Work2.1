namespace Work2._1
{
	partial class FormCalendar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendar));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.lbDate = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSelect = new System.Windows.Forms.Button();
			this.pBBack = new System.Windows.Forms.PictureBox();
			this.btnMonNext = new System.Windows.Forms.Button();
			this.btnMonBack = new System.Windows.Forms.Button();
			this.btnSaveApp = new System.Windows.Forms.Button();
			this.btnDeleteApp = new System.Windows.Forms.Button();
			this.btnEditApp = new System.Windows.Forms.Button();
			this.btnAddNewApp = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tabControlCalend = new System.Windows.Forms.TabControl();
			this.tabPageCalendar = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.daysContener = new System.Windows.Forms.FlowLayoutPanel();
			this.tabPageAddNewAppointment = new System.Windows.Forms.TabPage();
			this.btnSelectObj = new System.Windows.Forms.Button();
			this.lbObj = new System.Windows.Forms.Label();
			this.btnSelectClient = new System.Windows.Forms.Button();
			this.lbClient = new System.Windows.Forms.Label();
			this.btnSelectManger = new System.Windows.Forms.Button();
			this.lbMan = new System.Windows.Forms.Label();
			this.dTPTimeApp = new System.Windows.Forms.DateTimePicker();
			this.dTPDateApp = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tabPageSelectManager = new System.Windows.Forms.TabPage();
			this.tbMangerSearch = new System.Windows.Forms.TextBox();
			this.dGVMS = new System.Windows.Forms.DataGridView();
			this.tabPageSelectClient = new System.Windows.Forms.TabPage();
			this.dGVCS = new System.Windows.Forms.DataGridView();
			this.tbClientSearch = new System.Windows.Forms.TextBox();
			this.tabPageSelectObj = new System.Windows.Forms.TabPage();
			this.tbObjSearch = new System.Windows.Forms.TextBox();
			this.dGWOS = new System.Windows.Forms.DataGridView();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBBack)).BeginInit();
			this.panel3.SuspendLayout();
			this.tabControlCalend.SuspendLayout();
			this.tabPageCalendar.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tabPageAddNewAppointment.SuspendLayout();
			this.tabPageSelectManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVMS)).BeginInit();
			this.tabPageSelectClient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVCS)).BeginInit();
			this.tabPageSelectObj.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGWOS)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel2.Controls.Add(this.pBoxClose);
			this.panel2.Controls.Add(this.lbDate);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(950, 55);
			this.panel2.TabIndex = 4;
			// 
			// pBoxClose
			// 
			this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
			this.pBoxClose.Location = new System.Drawing.Point(913, 12);
			this.pBoxClose.Name = "pBoxClose";
			this.pBoxClose.Size = new System.Drawing.Size(25, 25);
			this.pBoxClose.TabIndex = 6;
			this.pBoxClose.TabStop = false;
			this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
			// 
			// lbDate
			// 
			this.lbDate.AutoSize = true;
			this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbDate.ForeColor = System.Drawing.SystemColors.Info;
			this.lbDate.Location = new System.Drawing.Point(16, 12);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(108, 24);
			this.lbDate.TabIndex = 0;
			this.lbDate.Text = "Календарь";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
			this.panel1.Controls.Add(this.btnSelect);
			this.panel1.Controls.Add(this.pBBack);
			this.panel1.Controls.Add(this.btnMonNext);
			this.panel1.Controls.Add(this.btnMonBack);
			this.panel1.Controls.Add(this.btnSaveApp);
			this.panel1.Controls.Add(this.btnDeleteApp);
			this.panel1.Controls.Add(this.btnEditApp);
			this.panel1.Controls.Add(this.btnAddNewApp);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(795, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 505);
			this.panel1.TabIndex = 6;
			// 
			// btnSelect
			// 
			this.btnSelect.FlatAppearance.BorderSize = 0;
			this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelect.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
			this.btnSelect.Location = new System.Drawing.Point(2, 15);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSelect.Size = new System.Drawing.Size(150, 60);
			this.btnSelect.TabIndex = 10;
			this.btnSelect.Text = "Выбрать";
			this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Visible = false;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// pBBack
			// 
			this.pBBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBBack.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBBack.Image = ((System.Drawing.Image)(resources.GetObject("pBBack.Image")));
			this.pBBack.Location = new System.Drawing.Point(58, 424);
			this.pBBack.Name = "pBBack";
			this.pBBack.Size = new System.Drawing.Size(50, 50);
			this.pBBack.TabIndex = 7;
			this.pBBack.TabStop = false;
			this.pBBack.Visible = false;
			this.pBBack.Click += new System.EventHandler(this.pBBack_Click);
			// 
			// btnMonNext
			// 
			this.btnMonNext.FlatAppearance.BorderSize = 0;
			this.btnMonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnMonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnMonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMonNext.ForeColor = System.Drawing.SystemColors.Info;
			this.btnMonNext.Image = ((System.Drawing.Image)(resources.GetObject("btnMonNext.Image")));
			this.btnMonNext.Location = new System.Drawing.Point(0, 15);
			this.btnMonNext.Name = "btnMonNext";
			this.btnMonNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMonNext.Size = new System.Drawing.Size(150, 60);
			this.btnMonNext.TabIndex = 9;
			this.btnMonNext.Text = "Следующий";
			this.btnMonNext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMonNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnMonNext.UseVisualStyleBackColor = true;
			this.btnMonNext.Click += new System.EventHandler(this.btnMonNext_Click);
			// 
			// btnMonBack
			// 
			this.btnMonBack.FlatAppearance.BorderSize = 0;
			this.btnMonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnMonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnMonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMonBack.ForeColor = System.Drawing.SystemColors.Info;
			this.btnMonBack.Image = ((System.Drawing.Image)(resources.GetObject("btnMonBack.Image")));
			this.btnMonBack.Location = new System.Drawing.Point(-1, 81);
			this.btnMonBack.Name = "btnMonBack";
			this.btnMonBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMonBack.Size = new System.Drawing.Size(150, 60);
			this.btnMonBack.TabIndex = 8;
			this.btnMonBack.Text = " Прошлый";
			this.btnMonBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnMonBack.UseVisualStyleBackColor = true;
			this.btnMonBack.Click += new System.EventHandler(this.btnMonBack_Click);
			// 
			// btnSaveApp
			// 
			this.btnSaveApp.Enabled = false;
			this.btnSaveApp.FlatAppearance.BorderSize = 0;
			this.btnSaveApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSaveApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSaveApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveApp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSaveApp.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveApp.Image")));
			this.btnSaveApp.Location = new System.Drawing.Point(2, 213);
			this.btnSaveApp.Name = "btnSaveApp";
			this.btnSaveApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSaveApp.Size = new System.Drawing.Size(150, 60);
			this.btnSaveApp.TabIndex = 7;
			this.btnSaveApp.Text = "Сохранить";
			this.btnSaveApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSaveApp.UseVisualStyleBackColor = true;
			this.btnSaveApp.Click += new System.EventHandler(this.btnSaveApp_Click);
			// 
			// btnDeleteApp
			// 
			this.btnDeleteApp.Enabled = false;
			this.btnDeleteApp.FlatAppearance.BorderSize = 0;
			this.btnDeleteApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnDeleteApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnDeleteApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeleteApp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnDeleteApp.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteApp.Image")));
			this.btnDeleteApp.Location = new System.Drawing.Point(-2, 341);
			this.btnDeleteApp.Name = "btnDeleteApp";
			this.btnDeleteApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDeleteApp.Size = new System.Drawing.Size(150, 60);
			this.btnDeleteApp.TabIndex = 5;
			this.btnDeleteApp.Text = "Удалить";
			this.btnDeleteApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDeleteApp.UseVisualStyleBackColor = true;
			// 
			// btnEditApp
			// 
			this.btnEditApp.Enabled = false;
			this.btnEditApp.FlatAppearance.BorderSize = 0;
			this.btnEditApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnEditApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnEditApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditApp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnEditApp.Image = ((System.Drawing.Image)(resources.GetObject("btnEditApp.Image")));
			this.btnEditApp.Location = new System.Drawing.Point(3, 275);
			this.btnEditApp.Name = "btnEditApp";
			this.btnEditApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnEditApp.Size = new System.Drawing.Size(150, 60);
			this.btnEditApp.TabIndex = 4;
			this.btnEditApp.Text = "Изменить";
			this.btnEditApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditApp.UseVisualStyleBackColor = true;
			// 
			// btnAddNewApp
			// 
			this.btnAddNewApp.FlatAppearance.BorderSize = 0;
			this.btnAddNewApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnAddNewApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnAddNewApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddNewApp.ForeColor = System.Drawing.SystemColors.Info;
			this.btnAddNewApp.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewApp.Image")));
			this.btnAddNewApp.Location = new System.Drawing.Point(3, 147);
			this.btnAddNewApp.Name = "btnAddNewApp";
			this.btnAddNewApp.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAddNewApp.Size = new System.Drawing.Size(150, 60);
			this.btnAddNewApp.TabIndex = 3;
			this.btnAddNewApp.Text = "Добавить";
			this.btnAddNewApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddNewApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNewApp.UseVisualStyleBackColor = true;
			this.btnAddNewApp.Click += new System.EventHandler(this.btnAddNewClient_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tabControlCalend);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 55);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(795, 505);
			this.panel3.TabIndex = 7;
			// 
			// tabControlCalend
			// 
			this.tabControlCalend.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlCalend.Controls.Add(this.tabPageCalendar);
			this.tabControlCalend.Controls.Add(this.tabPageAddNewAppointment);
			this.tabControlCalend.Controls.Add(this.tabPageSelectManager);
			this.tabControlCalend.Controls.Add(this.tabPageSelectClient);
			this.tabControlCalend.Controls.Add(this.tabPageSelectObj);
			this.tabControlCalend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlCalend.Location = new System.Drawing.Point(0, 0);
			this.tabControlCalend.Name = "tabControlCalend";
			this.tabControlCalend.SelectedIndex = 0;
			this.tabControlCalend.Size = new System.Drawing.Size(795, 505);
			this.tabControlCalend.TabIndex = 0;
			// 
			// tabPageCalendar
			// 
			this.tabPageCalendar.Controls.Add(this.panel4);
			this.tabPageCalendar.Controls.Add(this.daysContener);
			this.tabPageCalendar.Location = new System.Drawing.Point(4, 4);
			this.tabPageCalendar.Name = "tabPageCalendar";
			this.tabPageCalendar.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalendar.Size = new System.Drawing.Size(787, 479);
			this.tabPageCalendar.TabIndex = 0;
			this.tabPageCalendar.UseVisualStyleBackColor = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(781, 36);
			this.panel4.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(671, 8);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 20);
			this.label7.TabIndex = 6;
			this.label7.Text = "Воскресенье";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(571, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Суббота";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(458, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 20);
			this.label5.TabIndex = 4;
			this.label5.Text = "Пятница";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(353, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Четверг";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(253, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Среда";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(130, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Вторник";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(1, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Понедельник";
			// 
			// daysContener
			// 
			this.daysContener.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.daysContener.Location = new System.Drawing.Point(3, 34);
			this.daysContener.Name = "daysContener";
			this.daysContener.Size = new System.Drawing.Size(781, 442);
			this.daysContener.TabIndex = 0;
			// 
			// tabPageAddNewAppointment
			// 
			this.tabPageAddNewAppointment.Controls.Add(this.btnSelectObj);
			this.tabPageAddNewAppointment.Controls.Add(this.lbObj);
			this.tabPageAddNewAppointment.Controls.Add(this.btnSelectClient);
			this.tabPageAddNewAppointment.Controls.Add(this.lbClient);
			this.tabPageAddNewAppointment.Controls.Add(this.btnSelectManger);
			this.tabPageAddNewAppointment.Controls.Add(this.lbMan);
			this.tabPageAddNewAppointment.Controls.Add(this.dTPTimeApp);
			this.tabPageAddNewAppointment.Controls.Add(this.dTPDateApp);
			this.tabPageAddNewAppointment.Controls.Add(this.label8);
			this.tabPageAddNewAppointment.Controls.Add(this.label12);
			this.tabPageAddNewAppointment.Controls.Add(this.label9);
			this.tabPageAddNewAppointment.Controls.Add(this.label10);
			this.tabPageAddNewAppointment.Controls.Add(this.label11);
			this.tabPageAddNewAppointment.Location = new System.Drawing.Point(4, 4);
			this.tabPageAddNewAppointment.Name = "tabPageAddNewAppointment";
			this.tabPageAddNewAppointment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAddNewAppointment.Size = new System.Drawing.Size(787, 479);
			this.tabPageAddNewAppointment.TabIndex = 1;
			this.tabPageAddNewAppointment.UseVisualStyleBackColor = true;
			// 
			// btnSelectObj
			// 
			this.btnSelectObj.AutoSize = true;
			this.btnSelectObj.BackColor = System.Drawing.Color.Transparent;
			this.btnSelectObj.FlatAppearance.BorderSize = 0;
			this.btnSelectObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectObj.Location = new System.Drawing.Point(591, 275);
			this.btnSelectObj.Name = "btnSelectObj";
			this.btnSelectObj.Size = new System.Drawing.Size(98, 34);
			this.btnSelectObj.TabIndex = 34;
			this.btnSelectObj.Text = "Выбрать";
			this.btnSelectObj.UseVisualStyleBackColor = false;
			this.btnSelectObj.Click += new System.EventHandler(this.button1_Click);
			// 
			// lbObj
			// 
			this.lbObj.AutoSize = true;
			this.lbObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbObj.Location = new System.Drawing.Point(176, 280);
			this.lbObj.Name = "lbObj";
			this.lbObj.Size = new System.Drawing.Size(410, 24);
			this.lbObj.TabIndex = 33;
			this.lbObj.Text = "________________________________________";
			// 
			// btnSelectClient
			// 
			this.btnSelectClient.AutoSize = true;
			this.btnSelectClient.BackColor = System.Drawing.Color.Transparent;
			this.btnSelectClient.FlatAppearance.BorderSize = 0;
			this.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectClient.Location = new System.Drawing.Point(591, 206);
			this.btnSelectClient.Name = "btnSelectClient";
			this.btnSelectClient.Size = new System.Drawing.Size(98, 34);
			this.btnSelectClient.TabIndex = 32;
			this.btnSelectClient.Text = "Выбрать";
			this.btnSelectClient.UseVisualStyleBackColor = false;
			this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
			// 
			// lbClient
			// 
			this.lbClient.AutoSize = true;
			this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbClient.Location = new System.Drawing.Point(176, 211);
			this.lbClient.Name = "lbClient";
			this.lbClient.Size = new System.Drawing.Size(410, 24);
			this.lbClient.TabIndex = 31;
			this.lbClient.Text = "________________________________________";
			// 
			// btnSelectManger
			// 
			this.btnSelectManger.AutoSize = true;
			this.btnSelectManger.BackColor = System.Drawing.Color.Transparent;
			this.btnSelectManger.FlatAppearance.BorderSize = 0;
			this.btnSelectManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectManger.Location = new System.Drawing.Point(591, 143);
			this.btnSelectManger.Name = "btnSelectManger";
			this.btnSelectManger.Size = new System.Drawing.Size(98, 34);
			this.btnSelectManger.TabIndex = 30;
			this.btnSelectManger.Text = "Выбрать";
			this.btnSelectManger.UseVisualStyleBackColor = false;
			this.btnSelectManger.Click += new System.EventHandler(this.btnSelectManger_Click);
			// 
			// lbMan
			// 
			this.lbMan.AutoSize = true;
			this.lbMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbMan.Location = new System.Drawing.Point(176, 148);
			this.lbMan.Name = "lbMan";
			this.lbMan.Size = new System.Drawing.Size(410, 24);
			this.lbMan.TabIndex = 29;
			this.lbMan.Text = "________________________________________";
			// 
			// dTPTimeApp
			// 
			this.dTPTimeApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dTPTimeApp.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dTPTimeApp.Location = new System.Drawing.Point(168, 67);
			this.dTPTimeApp.Name = "dTPTimeApp";
			this.dTPTimeApp.Size = new System.Drawing.Size(113, 29);
			this.dTPTimeApp.TabIndex = 20;
			// 
			// dTPDateApp
			// 
			this.dTPDateApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dTPDateApp.Location = new System.Drawing.Point(168, 20);
			this.dTPDateApp.Name = "dTPDateApp";
			this.dTPDateApp.Size = new System.Drawing.Size(200, 29);
			this.dTPDateApp.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(34, 280);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 24);
			this.label8.TabIndex = 18;
			this.label8.Text = "Объект";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.Location = new System.Drawing.Point(37, 211);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 24);
			this.label12.TabIndex = 16;
			this.label12.Text = "Клент";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(34, 148);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 24);
			this.label9.TabIndex = 13;
			this.label9.Text = "Менеджер";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.Location = new System.Drawing.Point(34, 72);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(67, 24);
			this.label10.TabIndex = 10;
			this.label10.Text = "Время";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.Location = new System.Drawing.Point(34, 20);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(54, 24);
			this.label11.TabIndex = 8;
			this.label11.Text = "Дата";
			// 
			// tabPageSelectManager
			// 
			this.tabPageSelectManager.Controls.Add(this.tbMangerSearch);
			this.tabPageSelectManager.Controls.Add(this.dGVMS);
			this.tabPageSelectManager.Location = new System.Drawing.Point(4, 4);
			this.tabPageSelectManager.Name = "tabPageSelectManager";
			this.tabPageSelectManager.Size = new System.Drawing.Size(787, 479);
			this.tabPageSelectManager.TabIndex = 2;
			this.tabPageSelectManager.UseVisualStyleBackColor = true;
			// 
			// tbMangerSearch
			// 
			this.tbMangerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbMangerSearch.Location = new System.Drawing.Point(8, 26);
			this.tbMangerSearch.Name = "tbMangerSearch";
			this.tbMangerSearch.Size = new System.Drawing.Size(751, 29);
			this.tbMangerSearch.TabIndex = 30;
			this.tbMangerSearch.TextChanged += new System.EventHandler(this.tbMangerSearch_TextChanged);
			// 
			// dGVMS
			// 
			this.dGVMS.AllowUserToAddRows = false;
			this.dGVMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dGVMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGVMS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dGVMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGVMS.DefaultCellStyle = dataGridViewCellStyle1;
			this.dGVMS.Location = new System.Drawing.Point(8, 77);
			this.dGVMS.MultiSelect = false;
			this.dGVMS.Name = "dGVMS";
			this.dGVMS.ReadOnly = true;
			this.dGVMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGVMS.Size = new System.Drawing.Size(751, 393);
			this.dGVMS.TabIndex = 29;
			// 
			// tabPageSelectClient
			// 
			this.tabPageSelectClient.Controls.Add(this.dGVCS);
			this.tabPageSelectClient.Controls.Add(this.tbClientSearch);
			this.tabPageSelectClient.Location = new System.Drawing.Point(4, 4);
			this.tabPageSelectClient.Name = "tabPageSelectClient";
			this.tabPageSelectClient.Size = new System.Drawing.Size(787, 479);
			this.tabPageSelectClient.TabIndex = 3;
			this.tabPageSelectClient.UseVisualStyleBackColor = true;
			// 
			// dGVCS
			// 
			this.dGVCS.AllowUserToAddRows = false;
			this.dGVCS.AllowUserToDeleteRows = false;
			this.dGVCS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dGVCS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGVCS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dGVCS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGVCS.DefaultCellStyle = dataGridViewCellStyle2;
			this.dGVCS.Location = new System.Drawing.Point(16, 77);
			this.dGVCS.MultiSelect = false;
			this.dGVCS.Name = "dGVCS";
			this.dGVCS.ReadOnly = true;
			this.dGVCS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dGVCS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGVCS.Size = new System.Drawing.Size(744, 393);
			this.dGVCS.TabIndex = 28;
			// 
			// tbClientSearch
			// 
			this.tbClientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbClientSearch.Location = new System.Drawing.Point(16, 28);
			this.tbClientSearch.Name = "tbClientSearch";
			this.tbClientSearch.Size = new System.Drawing.Size(744, 29);
			this.tbClientSearch.TabIndex = 27;
			this.tbClientSearch.TextChanged += new System.EventHandler(this.tbClientSearch_TextChanged);
			// 
			// tabPageSelectObj
			// 
			this.tabPageSelectObj.Controls.Add(this.tbObjSearch);
			this.tabPageSelectObj.Controls.Add(this.dGWOS);
			this.tabPageSelectObj.Location = new System.Drawing.Point(4, 4);
			this.tabPageSelectObj.Name = "tabPageSelectObj";
			this.tabPageSelectObj.Size = new System.Drawing.Size(787, 479);
			this.tabPageSelectObj.TabIndex = 4;
			this.tabPageSelectObj.UseVisualStyleBackColor = true;
			// 
			// tbObjSearch
			// 
			this.tbObjSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbObjSearch.Location = new System.Drawing.Point(16, 26);
			this.tbObjSearch.Name = "tbObjSearch";
			this.tbObjSearch.Size = new System.Drawing.Size(757, 29);
			this.tbObjSearch.TabIndex = 26;
			this.tbObjSearch.TextChanged += new System.EventHandler(this.tbObjSearch_TextChanged);
			// 
			// dGWOS
			// 
			this.dGWOS.AllowUserToAddRows = false;
			this.dGWOS.AllowUserToDeleteRows = false;
			this.dGWOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dGWOS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dGWOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dGWOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGWOS.DefaultCellStyle = dataGridViewCellStyle3;
			this.dGWOS.Location = new System.Drawing.Point(16, 61);
			this.dGWOS.MultiSelect = false;
			this.dGWOS.Name = "dGWOS";
			this.dGWOS.ReadOnly = true;
			this.dGWOS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
			this.dGWOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGWOS.Size = new System.Drawing.Size(757, 409);
			this.dGWOS.TabIndex = 27;
			// 
			// FormCalendar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(950, 560);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormCalendar";
			this.Text = "FormCalendar";
			this.Load += new System.EventHandler(this.FormCalendar_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pBBack)).EndInit();
			this.panel3.ResumeLayout(false);
			this.tabControlCalend.ResumeLayout(false);
			this.tabPageCalendar.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.tabPageAddNewAppointment.ResumeLayout(false);
			this.tabPageAddNewAppointment.PerformLayout();
			this.tabPageSelectManager.ResumeLayout(false);
			this.tabPageSelectManager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVMS)).EndInit();
			this.tabPageSelectClient.ResumeLayout(false);
			this.tabPageSelectClient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVCS)).EndInit();
			this.tabPageSelectObj.ResumeLayout(false);
			this.tabPageSelectObj.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGWOS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveApp;
		private System.Windows.Forms.Button btnDeleteApp;
		private System.Windows.Forms.Button btnEditApp;
		private System.Windows.Forms.Button btnAddNewApp;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnMonNext;
		private System.Windows.Forms.Button btnMonBack;
		private System.Windows.Forms.PictureBox pBBack;
		private System.Windows.Forms.TabControl tabControlCalend;
		private System.Windows.Forms.TabPage tabPageCalendar;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel daysContener;
		private System.Windows.Forms.TabPage tabPageAddNewAppointment;
		private System.Windows.Forms.Button btnSelectObj;
		private System.Windows.Forms.Label lbObj;
		private System.Windows.Forms.Button btnSelectClient;
		private System.Windows.Forms.Label lbClient;
		private System.Windows.Forms.Button btnSelectManger;
		private System.Windows.Forms.Label lbMan;
		private System.Windows.Forms.DateTimePicker dTPTimeApp;
		private System.Windows.Forms.DateTimePicker dTPDateApp;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabPageSelectManager;
		private System.Windows.Forms.TextBox tbMangerSearch;
		private System.Windows.Forms.DataGridView dGVMS;
		private System.Windows.Forms.TabPage tabPageSelectClient;
		private System.Windows.Forms.DataGridView dGVCS;
		private System.Windows.Forms.TextBox tbClientSearch;
		private System.Windows.Forms.TabPage tabPageSelectObj;
		private System.Windows.Forms.TextBox tbObjSearch;
		private System.Windows.Forms.DataGridView dGWOS;
		private System.Windows.Forms.Button btnSelect;
	}
}