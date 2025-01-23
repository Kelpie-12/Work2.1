namespace Work2._1
{
	partial class UserControlDays
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbDays = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDays
			// 
			this.lbDays.AutoSize = true;
			this.lbDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbDays.Location = new System.Drawing.Point(13, 13);
			this.lbDays.Name = "lbDays";
			this.lbDays.Size = new System.Drawing.Size(0, 24);
			this.lbDays.TabIndex = 0;
			// 
			// UserControlDays
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbDays);
			this.Name = "UserControlDays";
			this.Size = new System.Drawing.Size(105, 68);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbDays;
	}
}
