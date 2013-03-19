/* User: Erin
 * Date: 3/18/2013
 * Time: 7:03 PM
 */
namespace calcLib.Controls
{
	partial class hexaBox
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
			this.hexaCell1 = new calcLib.Controls.hexaCell();
			this.hexaCell2 = new calcLib.Controls.hexaCell();
			this.comboBox_op = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// hexaCell1
			// 
			this.hexaCell1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.hexaCell1.Location = new System.Drawing.Point(3, 3);
			this.hexaCell1.Name = "hexaCell1";
			this.hexaCell1.Size = new System.Drawing.Size(380, 54);
			this.hexaCell1.TabIndex = 0;
			this.hexaCell1.val = new decimal(new int[] {
									0,
									0,
									0,
									0});
			// 
			// hexaCell2
			// 
			this.hexaCell2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.hexaCell2.Location = new System.Drawing.Point(3, 104);
			this.hexaCell2.Name = "hexaCell2";
			this.hexaCell2.Size = new System.Drawing.Size(380, 54);
			this.hexaCell2.TabIndex = 2;
			this.hexaCell2.val = new decimal(new int[] {
									0,
									0,
									0,
									0});
			// 
			// comboBox_op
			// 
			this.comboBox_op.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_op.FormattingEnabled = true;
			this.comboBox_op.Items.AddRange(new object[] {
									"  +  ",
									"  -  ",
									"  *  ",
									"  /  "});
			this.comboBox_op.Location = new System.Drawing.Point(138, 63);
			this.comboBox_op.Name = "comboBox_op";
			this.comboBox_op.Size = new System.Drawing.Size(65, 33);
			this.comboBox_op.TabIndex = 1;
			// 
			// hexaBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.comboBox_op);
			this.Controls.Add(this.hexaCell2);
			this.Controls.Add(this.hexaCell1);
			this.Name = "hexaBox";
			this.Size = new System.Drawing.Size(386, 161);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox comboBox_op;
		private calcLib.Controls.hexaCell hexaCell2;
		private calcLib.Controls.hexaCell hexaCell1;
	}
}
