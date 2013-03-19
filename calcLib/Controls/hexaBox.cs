#region header
/* User: Erin
 * Date: 3/18/2013
 * Time: 7:03 PM
 */
#endregion
#region using....
using calcLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace calcLib.Controls {
	#region meta
	/// <summary>
	/// Description of hexa.
	/// </summary>
	#endregion
	public partial class hexaBox : UserControl {
		#region static
		#region static vars
		#endregion
		#region static events
		#endregion
		#region static properties
		#endregion
		#region static On....
		#endregion
		#region static functions
		#endregion
		#region static function: blah
		#endregion
		#endregion
		#region vars
		decimal _val = 0;
		#endregion
		#region constructors
		public hexaBox() { InitHexaBox(); }
		protected virtual void InitHexaBox() {
			InitializeComponent();
			comboBox_op.SelectedIndex = 0;
			hexaCell1.ValChanged += new EventHandler(HexaCell_ValueChanged);
			hexaCell2.ValChanged += new EventHandler(HexaCell_ValueChanged);
			comboBox_op.SelectedIndexChanged
							+= new EventHandler(HexaCell_ValueChanged);
		}
		#endregion
		#region events
		public event EventHandler ValChanged;
		#endregion
		#region properties
		public virtual decimal val {
			get { return _val; }
		}
		public virtual decimal val1 {
			get { return hexaCell1.val; }
			set { hexaCell1.val = value; }
		}
		public virtual decimal val2 {
			get { return hexaCell2.val; }
			set { hexaCell2.val = value; }
		}
		#endregion
		#region On....
		protected override void OnResize(EventArgs e) {
			base.OnResize(e);
			comboBox_op.Location = new Point(
				(ClientSize.Width / 2) - (comboBox_op.Width / 2)
			,	(ClientSize.Height / 2) - (comboBox_op.Height / 2)
			);
		}
		protected virtual void OnValChanged(EventArgs e) {
			if(ValChanged != null) ValChanged(this, e);
		}
		#endregion
		#region event handlers
		protected virtual void hexaBox_Resize(object sender, EventArgs e) {
			comboBox_op.Location = new Point(
				(ClientSize.Width / 2) - (comboBox_op.Width / 2)
			,	(ClientSize.Height / 2) - (comboBox_op.Height / 2)
			);
		}
		protected virtual void HexaCell_ValueChanged(object sender, EventArgs e) {
			Calculate();
		}
		#endregion
		public virtual void Calculate() {
			//MessageBox.Show("Calculate()");
			decimal dec1 = hexaCell1.val;
			decimal dec2 = hexaCell2.val;
			decimal v = math.DoMath(dec1, dec2, (opType)comboBox_op.SelectedIndex);
			if(v != _val) {
				_val = v;
				ValChanged(this, new EventArgs());
			}
		}
	}
}
