namespace ASV
{
	partial class ArrayViewer
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
			this.SuspendLayout();
			// 
			// ArrayViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Name = "ArrayViewer";
			this.Size = new System.Drawing.Size(273, 155);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ArrayViewer_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ArrayViewer_MouseMove);
			this.MouseCaptureChanged += new System.EventHandler(this.ArrayViewer_MouseCaptureChanged);
			this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ArrayViewer_MouseDoubleClick);
			this.Resize += new System.EventHandler(this.ArrayViewer_Resize);
			base.Paint += new System.Windows.Forms.PaintEventHandler(this.ArrayViewer_Paint);
			this.MouseLeave += new System.EventHandler(this.ArrayViewer_MouseLeave);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ArrayViewer_MouseUp);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArrayViewer_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
