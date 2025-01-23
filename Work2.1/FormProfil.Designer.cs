namespace Work2._1
{
	partial class FormProfil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfil));
			this.tabControlProfil = new System.Windows.Forms.TabControl();
			this.tPageSearch = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridViewClient = new System.Windows.Forms.DataGridView();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.tPageProfil = new System.Windows.Forms.TabPage();
			this.tbClientTelNumber = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbClientLast = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tBoxCiientFName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.lbClient = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSelectClient = new System.Windows.Forms.Button();
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.btnAddNewClient = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnSaveClient = new System.Windows.Forms.Button();
			this.cBoxClientManager = new System.Windows.Forms.ComboBox();
			this.tabControlProfil.SuspendLayout();
			this.tPageSearch.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
			this.tPageProfil.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlProfil
			// 
			this.tabControlProfil.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabControlProfil.Controls.Add(this.tPageSearch);
			this.tabControlProfil.Controls.Add(this.tPageProfil);
			this.tabControlProfil.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlProfil.Location = new System.Drawing.Point(0, 0);
			this.tabControlProfil.Multiline = true;
			this.tabControlProfil.Name = "tabControlProfil";
			this.tabControlProfil.SelectedIndex = 0;
			this.tabControlProfil.Size = new System.Drawing.Size(886, 441);
			this.tabControlProfil.TabIndex = 2;
			// 
			// tPageSearch
			// 
			this.tPageSearch.BackColor = System.Drawing.Color.Transparent;
			this.tPageSearch.Controls.Add(this.panel4);
			this.tPageSearch.Location = new System.Drawing.Point(4, 4);
			this.tPageSearch.Name = "tPageSearch";
			this.tPageSearch.Padding = new System.Windows.Forms.Padding(3);
			this.tPageSearch.Size = new System.Drawing.Size(878, 415);
			this.tPageSearch.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridViewClient);
			this.panel4.Controls.Add(this.tbSearch);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(3, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(872, 409);
			this.panel4.TabIndex = 4;
			// 
			// dataGridViewClient
			// 
			this.dataGridViewClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewClient.Location = new System.Drawing.Point(22, 69);
			this.dataGridViewClient.MultiSelect = false;
			this.dataGridViewClient.Name = "dataGridViewClient";
			this.dataGridViewClient.ReadOnly = true;
			this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewClient.Size = new System.Drawing.Size(661, 327);
			this.dataGridViewClient.TabIndex = 2;
			// 
			// tbSearch
			// 
			this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSearch.Location = new System.Drawing.Point(22, 23);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(661, 29);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			// 
			// tPageProfil
			// 
			this.tPageProfil.Controls.Add(this.cBoxClientManager);
			this.tPageProfil.Controls.Add(this.tbClientTelNumber);
			this.tPageProfil.Controls.Add(this.label4);
			this.tPageProfil.Controls.Add(this.label3);
			this.tPageProfil.Controls.Add(this.tbClientLast);
			this.tPageProfil.Controls.Add(this.label2);
			this.tPageProfil.Controls.Add(this.tBoxCiientFName);
			this.tPageProfil.Controls.Add(this.label1);
			this.tPageProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tPageProfil.Location = new System.Drawing.Point(4, 4);
			this.tPageProfil.Name = "tPageProfil";
			this.tPageProfil.Padding = new System.Windows.Forms.Padding(3);
			this.tPageProfil.Size = new System.Drawing.Size(878, 415);
			this.tPageProfil.TabIndex = 1;
			this.tPageProfil.UseVisualStyleBackColor = true;
			// 
			// tbClientTelNumber
			// 
			this.tbClientTelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbClientTelNumber.Location = new System.Drawing.Point(146, 202);
			this.tbClientTelNumber.Name = "tbClientTelNumber";
			this.tbClientTelNumber.ReadOnly = true;
			this.tbClientTelNumber.Size = new System.Drawing.Size(390, 29);
			this.tbClientTelNumber.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 24);
			this.label4.TabIndex = 6;
			this.label4.Text = "Телефон";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 152);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "Менеджер";
			// 
			// tbClientLast
			// 
			this.tbClientLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbClientLast.Location = new System.Drawing.Point(146, 96);
			this.tbClientLast.Name = "tbClientLast";
			this.tbClientLast.ReadOnly = true;
			this.tbClientLast.Size = new System.Drawing.Size(390, 29);
			this.tbClientLast.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "Фамилия";
			// 
			// tBoxCiientFName
			// 
			this.tBoxCiientFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tBoxCiientFName.Location = new System.Drawing.Point(146, 43);
			this.tBoxCiientFName.Name = "tBoxCiientFName";
			this.tBoxCiientFName.ReadOnly = true;
			this.tBoxCiientFName.Size = new System.Drawing.Size(390, 29);
			this.tBoxCiientFName.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Имя";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel2.Controls.Add(this.pBoxClose);
			this.panel2.Controls.Add(this.lbClient);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(886, 55);
			this.panel2.TabIndex = 3;
			// 
			// pBoxClose
			// 
			this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
			this.pBoxClose.Location = new System.Drawing.Point(849, 12);
			this.pBoxClose.Name = "pBoxClose";
			this.pBoxClose.Size = new System.Drawing.Size(25, 25);
			this.pBoxClose.TabIndex = 6;
			this.pBoxClose.TabStop = false;
			this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
			// 
			// lbClient
			// 
			this.lbClient.AutoSize = true;
			this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbClient.ForeColor = System.Drawing.SystemColors.Info;
			this.lbClient.Location = new System.Drawing.Point(16, 12);
			this.lbClient.Name = "lbClient";
			this.lbClient.Size = new System.Drawing.Size(130, 24);
			this.lbClient.TabIndex = 0;
			this.lbClient.Text = "Поиск клента";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tabControlProfil);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 55);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(886, 441);
			this.panel3.TabIndex = 4;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
			this.panel1.Controls.Add(this.btnSaveClient);
			this.panel1.Controls.Add(this.btnSelectClient);
			this.panel1.Controls.Add(this.btnDeleteClient);
			this.panel1.Controls.Add(this.btnEditClient);
			this.panel1.Controls.Add(this.btnAddNewClient);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(731, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 441);
			this.panel1.TabIndex = 5;
			// 
			// btnSelectClient
			// 
			this.btnSelectClient.FlatAppearance.BorderSize = 0;
			this.btnSelectClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnSelectClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnSelectClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSelectClient.ForeColor = System.Drawing.SystemColors.Info;
			this.btnSelectClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectClient.Image")));
			this.btnSelectClient.Location = new System.Drawing.Point(3, 67);
			this.btnSelectClient.Name = "btnSelectClient";
			this.btnSelectClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSelectClient.Size = new System.Drawing.Size(150, 60);
			this.btnSelectClient.TabIndex = 6;
			this.btnSelectClient.Text = "Выбрать";
			this.btnSelectClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSelectClient.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSelectClient.UseVisualStyleBackColor = true;
			this.btnSelectClient.Click += new System.EventHandler(this.btnSelectClient_Click);
			// 
			// btnDeleteClient
			// 
			this.btnDeleteClient.Enabled = false;
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
			this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
			// 
			// btnEditClient
			// 
			this.btnEditClient.Enabled = false;
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
			this.btnSearch.Location = new System.Drawing.Point(2, 8);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnSearch.Size = new System.Drawing.Size(150, 60);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			// cBoxClientManager
			// 
			this.cBoxClientManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cBoxClientManager.FormattingEnabled = true;
			this.cBoxClientManager.Location = new System.Drawing.Point(146, 152);
			this.cBoxClientManager.Name = "cBoxClientManager";
			this.cBoxClientManager.Size = new System.Drawing.Size(390, 32);
			this.cBoxClientManager.TabIndex = 8;
			// 
			// FormProfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(886, 496);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormProfil";
			this.Text = "FormProfil";
			this.tabControlProfil.ResumeLayout(false);
			this.tPageSearch.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
			this.tPageProfil.ResumeLayout(false);
			this.tPageProfil.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage tPageSearch;
		private System.Windows.Forms.TextBox tbSearch;
		private System.Windows.Forms.TabPage tPageProfil;
		private System.Windows.Forms.DataGridView dataGridViewClient;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbClient;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl tabControlProfil;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSelectClient;
		private System.Windows.Forms.Button btnDeleteClient;
		private System.Windows.Forms.Button btnEditClient;
		private System.Windows.Forms.Button btnAddNewClient;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbClientTelNumber;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbClientLast;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tBoxCiientFName;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.Button btnSaveClient;
		private System.Windows.Forms.ComboBox cBoxClientManager;
	}
}