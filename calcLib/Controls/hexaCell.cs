#region header
/* User: Erin
 * Date: 3/18/2013
 * Time: 7:03 PM
 */
#endregion
#region using....
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace calcLib.Controls {
	#region meta
	/// <summary>
	/// Description of hexaCell.
	/// </summary>
	#endregion
	public partial class hexaCell : UserControl {
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
		protected bool doStuff = true;
		protected decimal lastVal;
		#endregion
		#region constructors
		public hexaCell() { InitHexaCell(); }
		protected virtual void InitHexaCell() {
			InitializeComponent();

			numericUpDown_Dec.KeyDown += new KeyEventHandler(DecValChanged);
			numericUpDown_Dec.KeyPress += new KeyPressEventHandler(DecValChanged);
			numericUpDown_Dec.ValueChanged += new EventHandler(DecValChanged);

			numericUpDown_Hex.KeyDown += new KeyEventHandler(HexValChanged);
			numericUpDown_Hex.KeyPress += new KeyPressEventHandler(HexValChanged);
			numericUpDown_Hex.ValueChanged += new EventHandler(HexValChanged);
		}
		#endregion
		#region events
		public event EventHandler ValChanged;
		#endregion
		#region properties
		public virtual decimal val {
			get { return numericUpDown_Dec.Value; }
			set { numericUpDown_Dec.Value = value; }
		}
		#endregion
		#region On....
		protected virtual void OnValChanged(EventArgs e) {
			if(ValChanged != null) {
				decimal v = numericUpDown_Dec.Value;
				if(v != lastVal) {
					lastVal = v;
					ValChanged(this, e);
				}
			}
		}
		protected virtual void OnDecValChanged(EventArgs e) {
			if(doStuff) {
				doStuff = false;
				numericUpDown_Hex.Value = numericUpDown_Dec.Value;
				doStuff = true;
				OnValChanged(e);
			}
		}
		protected virtual void OnHexValChanged(EventArgs e) {
			if(doStuff) {
				doStuff = false;
				numericUpDown_Dec.Value = numericUpDown_Hex.Value;
				doStuff = true;
				OnValChanged(e);
			}
		}
		#endregion
		#region eventHandlers
		void DecValChanged(object sender, object e) {
			OnDecValChanged(new EventArgs());
		}
		
		void HexValChanged(object sender, object e) {
			OnHexValChanged(new EventArgs());
		}
		#endregion
	}
}
