using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCackeCandles
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] height_temp = Console.ReadLine().Split(' ');
			int[] height = Array.ConvertAll(height_temp, Int32.Parse);
		    var highvalue=	height.OrderByDescending(t=>t).FirstOrDefault();
			Console.WriteLine(height.Count(t => t == highvalue));
			Console.ReadLine();

		}
	}
}
