namespace Work2._1
{
	partial class FormViewPhoro
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewPhoro));
			this.panelTop = new System.Windows.Forms.Panel();
			this.lbClient = new System.Windows.Forms.Label();
			this.pBoxClose = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanelPhoto = new System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
			this.flowLayoutPanelPhoto.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panelTop
			// 
			this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
			this.panelTop.Controls.Add(this.lbClient);
			this.panelTop.Controls.Add(this.pBoxClose);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 0);
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(816, 54);
			this.panelTop.TabIndex = 1;
			this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
			// 
			// lbClient
			// 
			this.lbClient.AutoSize = true;
			this.lbClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbClient.ForeColor = System.Drawing.SystemColors.Info;
			this.lbClient.Location = new System.Drawing.Point(12, 14);
			this.lbClient.Name = "lbClient";
			this.lbClient.Size = new System.Drawing.Size(161, 24);
			this.lbClient.TabIndex = 8;
			this.lbClient.Text = "Фото объекта №";
			// 
			// pBoxClose
			// 
			this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
			this.pBoxClose.Location = new System.Drawing.Point(779, 13);
			this.pBoxClose.Name = "pBoxClose";
			this.pBoxClose.Size = new System.Drawing.Size(25, 25);
			this.pBoxClose.TabIndex = 7;
			this.pBoxClose.TabStop = false;
			this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
			// 
			// flowLayoutPanelPhoto
			// 
			this.flowLayoutPanelPhoto.Controls.Add(this.pictureBox1);
			this.flowLayoutPanelPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanelPhoto.Location = new System.Drawing.Point(0, 54);
			this.flowLayoutPanelPhoto.Name = "flowLayoutPanelPhoto";
			this.flowLayoutPanelPhoto.Size = new System.Drawing.Size(816, 450);
			this.flowLayoutPanelPhoto.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(262, 206);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// FormViewPhoro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(816, 504);
			this.Controls.Add(this.flowLayoutPanelPhoto);
			this.Controls.Add(this.panelTop);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormViewPhoro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormViewPhoro";
			this.panelTop.ResumeLayout(false);
			this.panelTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
			this.flowLayoutPanelPhoto.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.Label lbClient;
		private System.Windows.Forms.PictureBox pBoxClose;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPhoto;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}