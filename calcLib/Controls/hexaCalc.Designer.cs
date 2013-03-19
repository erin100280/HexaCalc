/* User: Erin
 * Date: 3/18/2013
 * Time: 8:22 PM
 */
namespace calcLib.Controls
{
	partial class hexaCalc
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
			this.hexaBox1 = new calcLib.Controls.hexaBox();
			this.groupBox_results = new System.Windows.Forms.GroupBox();
			this.label_result = new System.Windows.Forms.Label();
			this.groupBox_results.SuspendLayout();
			this.SuspendLayout();
			// 
			// hexaBox1
			// 
			this.hexaBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.hexaBox1.Location = new System.Drawing.Point(3, 3);
			this.hexaBox1.Name = "hexaBox1";
			this.hexaBox1.Size = new System.Drawing.Size(386, 161);
			this.hexaBox1.TabIndex = 0;
			this.hexaBox1.val1 = new decimal(new int[] {
									0,
									0,
									0,
									0});
			// 
			// groupBox_results
			// 
			this.groupBox_results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox_results.Controls.Add(this.label_result);
			this.groupBox_results.Location = new System.Drawing.Point(11, 170);
			this.groupBox_results.Name = "groupBox_results";
			this.groupBox_results.Size = new System.Drawing.Size(368, 40);
			this.groupBox_results.TabIndex = 1;
			this.groupBox_results.TabStop = false;
			this.groupBox_results.Text = "Results";
			// 
			// label_result
			// 
			this.label_result.AutoSize = true;
			this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_result.Location = new System.Drawing.Point(15, 16);
			this.label_result.MaximumSize = new System.Drawing.Size(1000, 16);
			this.label_result.MinimumSize = new System.Drawing.Size(2, 16);
			this.label_result.Name = "label_result";
			this.label_result.Size = new System.Drawing.Size(119, 16);
			this.label_result.TabIndex = 0;
			this.label_result.Text = "Dec: 0            Hex: 0";
			this.label_result.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// hexaCalc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox_results);
			this.Controls.Add(this.hexaBox1);
			this.MaximumSize = new System.Drawing.Size(10000, 224);
			this.MinimumSize = new System.Drawing.Size(182, 224);
			this.Name = "hexaCalc";
			this.Size = new System.Drawing.Size(392, 224);
			this.groupBox_results.ResumeLayout(false);
			this.groupBox_results.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_result;
		private System.Windows.Forms.GroupBox groupBox_results;
		private calcLib.Controls.hexaBox hexaBox1;
	}
}
