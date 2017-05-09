using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryBigSum
{
	class Program
	{
		private static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			string[] arr_temp = Console.ReadLine().Split(' ');
			long[] arr = Array.ConvertAll(arr_temp, long.Parse);
			long lng = arr.Sum();
			Console.WriteLine(lng);
		}
	}
}
