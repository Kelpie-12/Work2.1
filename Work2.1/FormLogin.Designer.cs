namespace Work2._1
{
	partial class FormLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tBoxUserName = new System.Windows.Forms.TextBox();
			this.tBoxPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLogIn = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pBMinimazed = new System.Windows.Forms.PictureBox();
			this.pBClose = new System.Windows.Forms.PictureBox();
			this.lbErroMessage = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pBMinimazed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pBClose)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(250, 330);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkGray;
			this.label1.Location = new System.Drawing.Point(276, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(460, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "_____________________________________________";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.DarkGray;
			this.label2.Location = new System.Drawing.Point(276, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(460, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "_____________________________________________";
			// 
			// tBoxUserName
			// 
			this.tBoxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.tBoxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tBoxUserName.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.tBoxUserName.Location = new System.Drawing.Point(280, 64);
			this.tBoxUserName.Name = "tBoxUserName";
			this.tBoxUserName.Size = new System.Drawing.Size(456, 22);
			this.tBoxUserName.TabIndex = 0;
			this.tBoxUserName.Text = "Username";
			this.tBoxUserName.Enter += new System.EventHandler(this.tBoxUserName_Enter);
			this.tBoxUserName.Leave += new System.EventHandler(this.tBoxUserName_Leave);
			// 
			// tBoxPassword
			// 
			this.tBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.tBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tBoxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.tBoxPassword.Location = new System.Drawing.Point(280, 137);
			this.tBoxPassword.Name = "tBoxPassword";
			this.tBoxPassword.Size = new System.Drawing.Size(456, 22);
			this.tBoxPassword.TabIndex = 1;
			this.tBoxPassword.Text = "Password";
			this.tBoxPassword.Enter += new System.EventHandler(this.tBoxPassword_Enter);
			this.tBoxPassword.Leave += new System.EventHandler(this.tBoxPassword_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label3.Location = new System.Drawing.Point(526, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 26);
			this.label3.TabIndex = 5;
			this.label3.Text = "LOGIN";
			// 
			// btnLogIn
			// 
			this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.btnLogIn.FlatAppearance.BorderSize = 0;
			this.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnLogIn.ForeColor = System.Drawing.Color.Gainsboro;
			this.btnLogIn.Location = new System.Drawing.Point(280, 235);
			this.btnLogIn.Name = "btnLogIn";
			this.btnLogIn.Size = new System.Drawing.Size(456, 40);
			this.btnLogIn.TabIndex = 3;
			this.btnLogIn.Text = "LOG IN";
			this.btnLogIn.UseVisualStyleBackColor = false;
			this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
			this.linkLabel1.Location = new System.Drawing.Point(446, 291);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(132, 20);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Fogot password?";
			// 
			// pBMinimazed
			// 
			this.pBMinimazed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pBMinimazed.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBMinimazed.Image = ((System.Drawing.Image)(resources.GetObject("pBMinimazed.Image")));
			this.pBMinimazed.Location = new System.Drawing.Point(720, 6);
			this.pBMinimazed.Name = "pBMinimazed";
			this.pBMinimazed.Size = new System.Drawing.Size(25, 25);
			this.pBMinimazed.TabIndex = 9;
			this.pBMinimazed.TabStop = false;
			this.pBMinimazed.Click += new System.EventHandler(this.pBMinimazed_Click);
			// 
			// pBClose
			// 
			this.pBClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pBClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pBClose.Image = ((System.Drawing.Image)(resources.GetObject("pBClose.Image")));
			this.pBClose.Location = new System.Drawing.Point(751, 6);
			this.pBClose.Name = "pBClose";
			this.pBClose.Size = new System.Drawing.Size(25, 25);
			this.pBClose.TabIndex = 8;
			this.pBClose.TabStop = false;
			this.pBClose.Click += new System.EventHandler(this.pBClose_Click);
			// 
			// lbErroMessage
			// 
			this.lbErroMessage.AutoSize = true;
			this.lbErroMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbErroMessage.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lbErroMessage.Location = new System.Drawing.Point(277, 195);
			this.lbErroMessage.Name = "lbErroMessage";
			this.lbErroMessage.Size = new System.Drawing.Size(101, 17);
			this.lbErroMessage.TabIndex = 10;
			this.lbErroMessage.Text = "Error message";
			this.lbErroMessage.Visible = false;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
			this.ClientSize = new System.Drawing.Size(780, 330);
			this.Controls.Add(this.lbErroMessage);
			this.Controls.Add(this.pBMinimazed);
			this.Controls.Add(this.pBClose);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnLogIn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tBoxPassword);
			this.Controls.Add(this.tBoxUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormLogin";
			this.Opacity = 0.9D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.pBMinimazed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pBClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tBoxUserName;
		private System.Windows.Forms.TextBox tBoxPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLogIn;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.PictureBox pBClose;
		private System.Windows.Forms.PictureBox pBMinimazed;
		private System.Windows.Forms.Label lbErroMessage;
	}
}

