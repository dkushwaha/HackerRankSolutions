
using System.Linq;
using System;
using System.Collections.Generic;

static class Module1
{
	public static void Main()
	{
		var n = Convert.ToInt32(Console.ReadLine());
		string[] cTemp = Console.ReadLine().Split(' ');
		Int16[] c = new Int16[cTemp.Length + 1];
		for (int i = 0; i <= cTemp.Length - 1; i++) {
			c[i] = Convert.ToInt16(cTemp[i]);
		}
		Int32 sum = 0;
		List<Int16> result = c.Distinct().ToList();
		for (int i = 0; i <= result.Count - 1; i++) {
			var tmp = result[i];
			var res = (from t in c where t.Equals(tmp)select t).Count();
			if (res > 1) {
				if (Math.Floor(Convert.ToDecimal(res / 2)) != Math.Ceiling(Convert.ToDecimal(res / 2)))
				{
					res = res - 1;
				}
				sum += res / 2;
			}
		}
		Console.WriteLine(sum);
		Console.ReadLine();
	}
}

