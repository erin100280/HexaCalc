/* User: Erin
 * Date: 3/18/2013
 * Time: 7:00 PM
 */
using System;
using System.Collections.Generic;

namespace calcLib {
	public enum opType {
		addition = 0
	,	subtraction = 1
	,	multiplication = 2
	,	division = 3
	}
	public static class math {
		#region function DoMath....
		public static decimal DoMath(decimal val1, decimal val2, opType type) {
			decimal rv = 0;
			switch(type) {
				case opType.addition:
					rv = DoMath_Addition(val1, val2);
					break;
				case opType.subtraction:
					rv = DoMath_Subtraction(val1, val2);
					break;
				case opType.multiplication:
					rv = DoMath_Multiplication(val1, val2);
					break;
				case opType.division:
					rv = DoMath_Division(val1, val2);
					break;
			}
			return rv;
		}
		public static decimal DoMath_Addition(decimal val1, decimal val2) {
			return (decimal)(val1 + val2);
		}
		public static decimal DoMath_Subtraction(decimal val1, decimal val2) {
			return (decimal)(val1 - val2);
		}
		public static decimal DoMath_Multiplication(decimal val1, decimal val2) {
			return (decimal)(val1 * val2);
		}
		public static decimal DoMath_Division(decimal val1, decimal val2) {
			return (decimal)(val1 / val2);
		}
		#endregion
	}
}