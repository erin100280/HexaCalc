/* User: Erin
 * Date: 3/18/2013
 * Time: 7:03 PM
 */
namespace calcLib.Controls
{
	partial class hexaCell
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label_Dec = new System.Windows.Forms.Label();
			this.label_Hex = new System.Windows.Forms.Label();
			this.numericUpDown_Dec = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_Hex = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dec)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hex)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Dec
			// 
			this.label_Dec.AutoSize = true;
			this.label_Dec.Location = new System.Drawing.Point(13, 5);
			this.label_Dec.Name = "label_Dec";
			this.label_Dec.Size = new System.Drawing.Size(30, 13);
			this.label_Dec.TabIndex = 1;
			this.label_Dec.Text = "Dec:";
			// 
			// label_Hex
			// 
			this.label_Hex.AutoSize = true;
			this.label_Hex.Location = new System.Drawing.Point(14, 31);
			this.label_Hex.Name = "label_Hex";
			this.label_Hex.Size = new System.Drawing.Size(29, 13);
			this.label_Hex.TabIndex = 2;
			this.label_Hex.Text = "Hex:";
			// 
			// numericUpDown_Dec
			// 
			this.numericUpDown_Dec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_Dec.Location = new System.Drawing.Point(49, 3);
			this.numericUpDown_Dec.Maximum = new decimal(new int[] {
									100000000,
									0,
									0,
									0});
			this.numericUpDown_Dec.Name = "numericUpDown_Dec";
			this.numericUpDown_Dec.Size = new System.Drawing.Size(257, 20);
			this.numericUpDown_Dec.TabIndex = 3;
			// 
			// numericUpDown_Hex
			// 
			this.numericUpDown_Hex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.numericUpDown_Hex.Hexadecimal = true;
			this.numericUpDown_Hex.Location = new System.Drawing.Point(49, 29);
			this.numericUpDown_Hex.Maximum = new decimal(new int[] {
									100000000,
									0,
									0,
									0});
			this.numericUpDown_Hex.Name = "numericUpDown_Hex";
			this.numericUpDown_Hex.Size = new System.Drawing.Size(257, 20);
			this.numericUpDown_Hex.TabIndex = 4;
			// 
			// hexaCell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDown_Hex);
			this.Controls.Add(this.numericUpDown_Dec);
			this.Controls.Add(this.label_Hex);
			this.Controls.Add(this.label_Dec);
			this.Name = "hexaCell";
			this.Size = new System.Drawing.Size(318, 55);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Dec)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Hex)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.NumericUpDown numericUpDown_Hex;
		private System.Windows.Forms.NumericUpDown numericUpDown_Dec;
		private System.Windows.Forms.Label label_Hex;
		private System.Windows.Forms.Label label_Dec;
	}
}
