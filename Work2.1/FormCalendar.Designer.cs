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
			this.panel2 = new System.Windows.Forms.Panel();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.lbClient = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSaveClient = new System.Windows.Forms.Button();
			this.btnSelectClient = new System.Windows.Forms.Button();
			this.btnDeleteClient = new System.Windows.Forms.Button();
			this.btnEditClient = new System.Windows.Forms.Button();
			this.btnAddNewClient = new System.Windows.Forms.Button();
			this.btnMoLeft = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tabControlCalend = new System.Windows.Forms.TabControl();
			this.tabPageCalendar = new System.Windows.Forms.TabPage();
			this.tabPageAddNewAppointment = new System.Windows.Forms.TabPage();
			this.daysContener = new System.Windows.Forms.FlowLayoutPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMRight = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabControlCalend.SuspendLayout();
			this.tabPageCalendar.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panel2.Controls.Add(this.pBoxClose);
			this.panel2.Controls.Add(this.lbClient);
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
			// 
			// lbClient
			// 
			this.lbClient.AutoSize = true;
			this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbClient.ForeColor = System.Drawing.SystemColors.Info;
			this.lbClient.Location = new System.Drawing.Point(16, 12);
			this.lbClient.Name = "lbClient";
			this.lbClient.Size = new System.Drawing.Size(108, 24);
			this.lbClient.TabIndex = 0;
			this.lbClient.Text = "Календарь";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(55)))), ((int)(((byte)(95)))));
			this.panel1.Controls.Add(this.btnMRight);
			this.panel1.Controls.Add(this.btnSaveClient);
			this.panel1.Controls.Add(this.btnSelectClient);
			this.panel1.Controls.Add(this.btnDeleteClient);
			this.panel1.Controls.Add(this.btnEditClient);
			this.panel1.Controls.Add(this.btnAddNewClient);
			this.panel1.Controls.Add(this.btnMoLeft);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(795, 55);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 505);
			this.panel1.TabIndex = 6;
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
			// 
			// btnMoLeft
			// 
			this.btnMoLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMoLeft.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMoLeft.Enabled = false;
			this.btnMoLeft.FlatAppearance.BorderSize = 0;
			this.btnMoLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnMoLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnMoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMoLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMoLeft.ForeColor = System.Drawing.SystemColors.Info;
			this.btnMoLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnMoLeft.Image")));
			this.btnMoLeft.Location = new System.Drawing.Point(18, 15);
			this.btnMoLeft.Name = "btnMoLeft";
			this.btnMoLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMoLeft.Size = new System.Drawing.Size(50, 35);
			this.btnMoLeft.TabIndex = 2;
			this.btnMoLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnMoLeft.UseVisualStyleBackColor = true;
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
			// tabPageAddNewAppointment
			// 
			this.tabPageAddNewAppointment.Location = new System.Drawing.Point(4, 4);
			this.tabPageAddNewAppointment.Name = "tabPageAddNewAppointment";
			this.tabPageAddNewAppointment.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageAddNewAppointment.Size = new System.Drawing.Size(723, 415);
			this.tabPageAddNewAppointment.TabIndex = 1;
			this.tabPageAddNewAppointment.UseVisualStyleBackColor = true;
			// 
			// daysContener
			// 
			this.daysContener.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.daysContener.Location = new System.Drawing.Point(3, 34);
			this.daysContener.Name = "daysContener";
			this.daysContener.Size = new System.Drawing.Size(781, 442);
			this.daysContener.TabIndex = 0;
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
			// btnMRight
			// 
			this.btnMRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMRight.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMRight.Enabled = false;
			this.btnMRight.FlatAppearance.BorderSize = 0;
			this.btnMRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
			this.btnMRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
			this.btnMRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMRight.ForeColor = System.Drawing.SystemColors.Info;
			this.btnMRight.Image = ((System.Drawing.Image)(resources.GetObject("btnMRight.Image")));
			this.btnMRight.Location = new System.Drawing.Point(93, 15);
			this.btnMRight.Name = "btnMRight";
			this.btnMRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnMRight.Size = new System.Drawing.Size(50, 35);
			this.btnMRight.TabIndex = 8;
			this.btnMRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMRight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btnMRight.UseVisualStyleBackColor = true;
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
			this.panel3.ResumeLayout(false);
			this.tabControlCalend.ResumeLayout(false);
			this.tabPageCalendar.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.Label lbClient;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnSaveClient;
		private System.Windows.Forms.Button btnSelectClient;
		private System.Windows.Forms.Button btnDeleteClient;
		private System.Windows.Forms.Button btnEditClient;
		private System.Windows.Forms.Button btnAddNewClient;
		private System.Windows.Forms.Button btnMoLeft;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TabControl tabControlCalend;
		private System.Windows.Forms.TabPage tabPageCalendar;
		private System.Windows.Forms.TabPage tabPageAddNewAppointment;
		private System.Windows.Forms.FlowLayoutPanel daysContener;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMRight;
	}
}