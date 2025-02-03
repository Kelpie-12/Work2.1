namespace Work2._1
{
	partial class FormObjects
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObjects));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbClient = new System.Windows.Forms.Label();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSaveClient = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.btnAddNewClient = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tcObjects = new System.Windows.Forms.TabControl();
			this.tabPageObjSearch = new System.Windows.Forms.TabPage();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.dataGridViewObject = new System.Windows.Forms.DataGridView();
			this.tabPageObjectSelect = new System.Windows.Forms.TabPage();
			this.lbIDObj = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbFlat = new System.Windows.Forms.TextBox();
			this.tbHome = new System.Windows.Forms.TextBox();
			this.tbStreet = new System.Windows.Forms.TextBox();
			this.tbCiti = new System.Windows.Forms.TextBox();
			this.tbText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSelectPhpto = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSelectManger = new System.Windows.Forms.Button();
			this.lbMan = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.tabPageSelectManager = new System.Windows.Forms.TabPage();
			this.tbMangerSearch = new System.Windows.Forms.TextBox();
			this.dGVMS = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.panel2.SuspendLayout();
			this.tcObjects.SuspendLayout();
			this.tabPageObjSearch.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).BeginInit();
			this.tabPageObjectSelect.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.tabPageSelectManager.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVMS)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel1.Controls.Add(this.lbClient);
			this.panel1.Controls.Add(this.pBoxClose);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(886, 54);
			this.panel1.TabIndex = 0;
			// 
			// lbClient
			// 
			this.lbClient.AutoSize = true;
			this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbClient.ForeColor = System.Drawing.SystemColors.Info;
			this.lbClient.Location = new System.Drawing.Point(12, 14);
			this.lbClient.Name = "lbClient";
			this.lbClient.Size = new System.Drawing.Size(90, 24);
			this.lbClient.TabIndex = 8;
			this.lbClient.Text = "Объекты";
			// 
			// pBoxClose
			// 
			this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
			this.pBoxClose.Location = new System.Drawing.Point(849, 13);
			this.pBoxClose.Name = "pBoxClose";
			this.pBoxClose.Size = new System.Drawing.Size(25, 25);
			this.pBoxClose.TabIndex = 7;
			this.pBoxClose.TabStop = false;
			this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.btnSaveClient);
			this.panel2.Controls.Add(this.btnSelect);
			this.panel2.Controls.Add(this.btnDeleteClient);
			this.panel2.Controls.Add(this.btnEditClient);
			this.panel2.Controls.Add(this.btnAddNewClient);
			this.panel2.Controls.Add(this.btnSearch);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(731, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(155, 442);
			this.panel2.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(-126, 282);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(0, 24);
			this.label5.TabIndex = 56;
			// 
			// btnSaveClient
			// 
			this.btnSaveClient.Enabled = false;
			this.btnSaveClient.FlatAppearance.BorderSize = 0;
			this.btnSaveClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSaveClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSaveClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveClient.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSaveClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.Image")));
			this.btnSaveClient.Location = new System.Drawing.Point(2, 190);
			this.btnSaveClient.Name = "btnSaveClient";
			this.btnSaveClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSaveClient.Size = new System.Drawing.Size(150, 60);
			this.btnSaveClient.TabIndex = 7;
			this.btnSaveClient.Text = "Сохранить";
			this.btnSaveClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSaveClient.UseVisualStyleBackColor = true;
			this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
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
			this.btnSelect.Location = new System.Drawing.Point(3, 67);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSelect.Size = new System.Drawing.Size(150, 60);
			this.btnSelect.TabIndex = 6;
			this.btnSelect.Text = "Выбрать";
			this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelectClient_Click);
			// 
			// btnDeleteClient
			// 
			this.btnDeleteClient.FlatAppearance.BorderSize = 0;
			this.btnDeleteClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnDeleteClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnDeleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeleteClient.ForeColor = System.Drawing.SystemColors.Info;
			this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
			this.btnDeleteClient.Location = new System.Drawing.Point(-2, 318);
			this.btnDeleteClient.Name = "btnDeleteClient";
			this.btnDeleteClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnDeleteClient.Size = new System.Drawing.Size(150, 60);
			this.btnDeleteClient.TabIndex = 5;
			this.btnDeleteClient.Text = "Удалить";
			this.btnDeleteClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDeleteClient.UseVisualStyleBackColor = true;
			// 
			// btnEditClient
			// 
			this.btnEditClient.FlatAppearance.BorderSize = 0;
			this.btnEditClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEditClient.ForeColor = System.Drawing.SystemColors.Info;
			this.btnEditClient.Image = ((System.Drawing.Image)(resources.GetObject("btnEditClient.Image")));
			this.btnEditClient.Location = new System.Drawing.Point(3, 252);
			this.btnEditClient.Name = "btnEditClient";
			this.btnEditClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnEditClient.Size = new System.Drawing.Size(150, 60);
			this.btnEditClient.TabIndex = 4;
			this.btnEditClient.Text = "Изменить";
			this.btnEditClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditClient.UseVisualStyleBackColor = true;
			this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
			// 
			// btnAddNewClient
			// 
			this.btnAddNewClient.FlatAppearance.BorderSize = 0;
			this.btnAddNewClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnAddNewClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnAddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddNewClient.ForeColor = System.Drawing.SystemColors.Info;
			this.btnAddNewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewClient.Image")));
			this.btnAddNewClient.Location = new System.Drawing.Point(3, 124);
			this.btnAddNewClient.Name = "btnAddNewClient";
			this.btnAddNewClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAddNewClient.Size = new System.Drawing.Size(150, 60);
			this.btnAddNewClient.TabIndex = 3;
			this.btnAddNewClient.Text = "Добавить";
			this.btnAddNewClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddNewClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddNewClient.UseVisualStyleBackColor = true;
			this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Enabled = false;
			this.btnSearch.FlatAppearance.BorderSize = 0;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.Location = new System.Drawing.Point(0, 7);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSearch.Size = new System.Drawing.Size(155, 60);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tcObjects
			// 
			this.tcObjects.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tcObjects.Controls.Add(this.tabPageObjSearch);
			this.tcObjects.Controls.Add(this.tabPageObjectSelect);
			this.tcObjects.Controls.Add(this.tabPageSelectManager);
			this.tcObjects.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcObjects.Location = new System.Drawing.Point(0, 54);
			this.tcObjects.Name = "tcObjects";
			this.tcObjects.SelectedIndex = 0;
			this.tcObjects.Size = new System.Drawing.Size(731, 442);
			this.tcObjects.TabIndex = 7;
			// 
			// tabPageObjSearch
			// 
			this.tabPageObjSearch.Controls.Add(this.tbSearch);
			this.tabPageObjSearch.Controls.Add(this.dataGridViewObject);
			this.tabPageObjSearch.Location = new System.Drawing.Point(4, 4);
			this.tabPageObjSearch.Name = "tabPageObjSearch";
			this.tabPageObjSearch.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageObjSearch.Size = new System.Drawing.Size(723, 416);
			this.tabPageObjSearch.TabIndex = 0;
			this.tabPageObjSearch.UseVisualStyleBackColor = true;
			// 
			// tbSearch
			// 
			this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSearch.Location = new System.Drawing.Point(38, 18);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(661, 29);
			this.tbSearch.TabIndex = 4;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// dataGridViewObject
			// 
			this.dataGridViewObject.AllowUserToAddRows = false;
			this.dataGridViewObject.AllowUserToDeleteRows = false;
			this.dataGridViewObject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewObject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewObject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
			this.dataGridViewObject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewObject.DefaultCellStyle = dataGridViewCellStyle17;
			this.dataGridViewObject.Location = new System.Drawing.Point(38, 83);
			this.dataGridViewObject.MultiSelect = false;
			this.dataGridViewObject.Name = "dataGridViewObject";
			this.dataGridViewObject.ReadOnly = true;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewObject.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
			dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataGridViewObject.RowsDefaultCellStyle = dataGridViewCellStyle19;
			this.dataGridViewObject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewObject.Size = new System.Drawing.Size(661, 327);
			this.dataGridViewObject.TabIndex = 3;
			// 
			// tabPageObjectSelect
			// 
			this.tabPageObjectSelect.Controls.Add(this.lbIDObj);
			this.tabPageObjectSelect.Controls.Add(this.label1);
			this.tabPageObjectSelect.Controls.Add(this.tbFlat);
			this.tabPageObjectSelect.Controls.Add(this.tbHome);
			this.tabPageObjectSelect.Controls.Add(this.tbStreet);
			this.tabPageObjectSelect.Controls.Add(this.tbCiti);
			this.tabPageObjectSelect.Controls.Add(this.tbText);
			this.tabPageObjectSelect.Controls.Add(this.label3);
			this.tabPageObjectSelect.Controls.Add(this.btnSelectPhpto);
			this.tabPageObjectSelect.Controls.Add(this.label7);
			this.tabPageObjectSelect.Controls.Add(this.label6);
			this.tabPageObjectSelect.Controls.Add(this.label4);
			this.tabPageObjectSelect.Controls.Add(this.label2);
			this.tabPageObjectSelect.Controls.Add(this.btnSelectManger);
			this.tabPageObjectSelect.Controls.Add(this.lbMan);
			this.tabPageObjectSelect.Controls.Add(this.label9);
			this.tabPageObjectSelect.Controls.Add(this.pictureBoxPhoto);
			this.tabPageObjectSelect.Location = new System.Drawing.Point(4, 4);
			this.tabPageObjectSelect.Name = "tabPageObjectSelect";
			this.tabPageObjectSelect.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageObjectSelect.Size = new System.Drawing.Size(723, 416);
			this.tabPageObjectSelect.TabIndex = 1;
			this.tabPageObjectSelect.UseVisualStyleBackColor = true;
			// 
			// lbIDObj
			// 
			this.lbIDObj.AutoSize = true;
			this.lbIDObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbIDObj.Location = new System.Drawing.Point(657, 284);
			this.lbIDObj.Name = "lbIDObj";
			this.lbIDObj.Size = new System.Drawing.Size(40, 24);
			this.lbIDObj.TabIndex = 56;
			this.lbIDObj.Text = "___";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(550, 231);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(147, 24);
			this.label1.TabIndex = 55;
			this.label1.Text = "Номер объекта";
			// 
			// tbFlat
			// 
			this.tbFlat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.tbFlat.Location = new System.Drawing.Point(460, 278);
			this.tbFlat.Name = "tbFlat";
			this.tbFlat.Size = new System.Drawing.Size(66, 29);
			this.tbFlat.TabIndex = 54;
			this.tbFlat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFlat_KeyPress);
			// 
			// tbHome
			// 
			this.tbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.tbHome.Location = new System.Drawing.Point(460, 228);
			this.tbHome.Name = "tbHome";
			this.tbHome.Size = new System.Drawing.Size(66, 29);
			this.tbHome.TabIndex = 53;
			// 
			// tbStreet
			// 
			this.tbStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.tbStreet.Location = new System.Drawing.Point(460, 175);
			this.tbStreet.Name = "tbStreet";
			this.tbStreet.Size = new System.Drawing.Size(237, 29);
			this.tbStreet.TabIndex = 52;
			// 
			// tbCiti
			// 
			this.tbCiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.tbCiti.Location = new System.Drawing.Point(460, 111);
			this.tbCiti.Name = "tbCiti";
			this.tbCiti.Size = new System.Drawing.Size(237, 29);
			this.tbCiti.TabIndex = 51;
			// 
			// tbText
			// 
			this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.tbText.Location = new System.Drawing.Point(460, 18);
			this.tbText.Name = "tbText";
			this.tbText.Size = new System.Drawing.Size(237, 29);
			this.tbText.TabIndex = 50;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(338, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 24);
			this.label3.TabIndex = 48;
			this.label3.Text = "Квартира";
			// 
			// btnSelectPhpto
			// 
			this.btnSelectPhpto.AutoSize = true;
			this.btnSelectPhpto.BackColor = System.Drawing.Color.Transparent;
			this.btnSelectPhpto.FlatAppearance.BorderSize = 0;
			this.btnSelectPhpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectPhpto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectPhpto.Location = new System.Drawing.Point(84, 274);
			this.btnSelectPhpto.Name = "btnSelectPhpto";
			this.btnSelectPhpto.Size = new System.Drawing.Size(98, 34);
			this.btnSelectPhpto.TabIndex = 47;
			this.btnSelectPhpto.Text = "Выбрать";
			this.btnSelectPhpto.UseVisualStyleBackColor = false;
			this.btnSelectPhpto.Click += new System.EventHandler(this.btnSelectPhpto_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(338, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 24);
			this.label7.TabIndex = 43;
			this.label7.Text = "Дом";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(338, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 24);
			this.label6.TabIndex = 40;
			this.label6.Text = "Улица";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(336, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 24);
			this.label4.TabIndex = 37;
			this.label4.Text = "Город";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(336, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 24);
			this.label2.TabIndex = 34;
			this.label2.Text = "Описание";
			// 
			// btnSelectManger
			// 
			this.btnSelectManger.AutoSize = true;
			this.btnSelectManger.BackColor = System.Drawing.Color.Transparent;
			this.btnSelectManger.Enabled = false;
			this.btnSelectManger.FlatAppearance.BorderSize = 0;
			this.btnSelectManger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectManger.Location = new System.Drawing.Point(619, 357);
			this.btnSelectManger.Name = "btnSelectManger";
			this.btnSelectManger.Size = new System.Drawing.Size(98, 34);
			this.btnSelectManger.TabIndex = 33;
			this.btnSelectManger.Text = "Выбрать";
			this.btnSelectManger.UseVisualStyleBackColor = false;
			this.btnSelectManger.Click += new System.EventHandler(this.btnSelectManger_Click);
			// 
			// lbMan
			// 
			this.lbMan.AutoSize = true;
			this.lbMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbMan.Location = new System.Drawing.Point(169, 362);
			this.lbMan.Name = "lbMan";
			this.lbMan.Size = new System.Drawing.Size(410, 24);
			this.lbMan.TabIndex = 32;
			this.lbMan.Text = "________________________________________";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label9.Location = new System.Drawing.Point(19, 362);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(107, 24);
			this.label9.TabIndex = 31;
			this.label9.Text = "Менеджер";
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.Location = new System.Drawing.Point(12, 19);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(284, 247);
			this.pictureBoxPhoto.TabIndex = 0;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tabPageSelectManager
			// 
			this.tabPageSelectManager.Controls.Add(this.tbMangerSearch);
			this.tabPageSelectManager.Controls.Add(this.dGVMS);
			this.tabPageSelectManager.Location = new System.Drawing.Point(4, 4);
			this.tabPageSelectManager.Name = "tabPageSelectManager";
			this.tabPageSelectManager.Size = new System.Drawing.Size(723, 416);
			this.tabPageSelectManager.TabIndex = 2;
			this.tabPageSelectManager.UseVisualStyleBackColor = true;
			// 
			// tbMangerSearch
			// 
			this.tbMangerSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.tbMangerSearch.Location = new System.Drawing.Point(7, 16);
			this.tbMangerSearch.Name = "tbMangerSearch";
			this.tbMangerSearch.Size = new System.Drawing.Size(696, 29);
			this.tbMangerSearch.TabIndex = 32;
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
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dGVMS.DefaultCellStyle = dataGridViewCellStyle20;
			this.dGVMS.Location = new System.Drawing.Point(8, 51);
			this.dGVMS.MultiSelect = false;
			this.dGVMS.Name = "dGVMS";
			this.dGVMS.ReadOnly = true;
			this.dGVMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dGVMS.Size = new System.Drawing.Size(696, 362);
			this.dGVMS.TabIndex = 31;
			// 
			// FormObjects
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 496);
			this.Controls.Add(this.tcObjects);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormObjects";
			this.Text = "FormObjects";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tcObjects.ResumeLayout(false);
			this.tabPageObjSearch.ResumeLayout(false);
			this.tabPageObjSearch.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewObject)).EndInit();
			this.tabPageObjectSelect.ResumeLayout(false);
			this.tabPageObjectSelect.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.tabPageSelectManager.ResumeLayout(false);
			this.tabPageSelectManager.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dGVMS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSaveClient;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnDeleteClient;
		private System.Windows.Forms.Button btnEditClient;
		private System.Windows.Forms.Button btnAddNewClient;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lbClient;
		private System.Windows.Forms.TabControl tcObjects;
		private System.Windows.Forms.TabPage tabPageObjSearch;
		private System.Windows.Forms.TabPage tabPageObjectSelect;
		private System.Windows.Forms.DataGridView dataGridViewObject;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pictureBoxPhoto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelectManger;
		private System.Windows.Forms.Label lbMan;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnSelectPhpto;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbFlat;
		private System.Windows.Forms.TextBox tbHome;
		private System.Windows.Forms.TextBox tbStreet;
		private System.Windows.Forms.TextBox tbCiti;
		private System.Windows.Forms.TextBox tbText;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbIDObj;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPageSelectManager;
		private System.Windows.Forms.TextBox tbMangerSearch;
		private System.Windows.Forms.DataGridView dGVMS;
	}
}