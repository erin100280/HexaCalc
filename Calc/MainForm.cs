/* User: Erin
 * Date: 3/18/2013
 * Time: 6:59 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calc {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}
		void AboutToolStripMenuItemClick(object sender, EventArgs e) {
			MessageBox.Show(
				"HexaCalc 1.0"
			+	"\n"
			+	"By: Erin Bradford <erinbradford100280&gmail.com>"
			);
		}
		void ExitToolStripMenuItemClick(object sender, EventArgs e) {
			Application.Exit();
		}
	}
}
