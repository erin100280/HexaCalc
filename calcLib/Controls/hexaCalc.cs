#region header
/* User: Erin
 * Date: 3/18/2013
 * Time: 8:22 PM
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
	/// Description of hexaCalc.
	/// </summary>
	#endregion
	public partial class hexaCalc : UserControl {
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
		#endregion
		#region constructors
		public hexaCalc() { InithexaCalc(); }
		protected virtual void InithexaCalc() {
			InitializeComponent();
			hexaBox1.ValChanged += new EventHandler(hexaBox1_ValChanged);
		}
		#endregion
		#region events
		#endregion
		#region properties
		#endregion
		#region On....
		#endregion
		#region functions
		#endregion
		#region function: blah
		#endregion
		protected virtual void hexaBox1_ValChanged(object sender, EventArgs e) {
			label_result.Text = (
				"Dec: " + hexaBox1.val
			+	"            "
			+	"Hex: " + ((uint)hexaBox1.val).ToString("X")
			);
		}
	}
}
