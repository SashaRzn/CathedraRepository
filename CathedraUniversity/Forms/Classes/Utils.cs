using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CathedraUniversity.Forms.Classes
{
	public class Utils
	{
		public static decimal SafeDecimal(decimal AValue)
		{
			return AValue;
		}

		public static decimal SafeDecimal(decimal? AValue)
		{
			return AValue == null ? 0 : (decimal)AValue;
		}

		public static int SafeInt(int? AValue)
		{
			return AValue == null ? 0 : (int)AValue;
		}
	}
}
