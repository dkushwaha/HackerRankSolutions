using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
	class Program
	{
		private static void Main(string[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int k = Convert.ToInt32(tokens_n[1]);
			string[] a_temp = Console.ReadLine().Split(' ');
			int[] a = Array.ConvertAll(a_temp, Int32.Parse);
			var watch = System.Diagnostics.Stopwatch.StartNew();
			watch.Stop();
			Console.WriteLine("Rotate Left Method :-"+watch.Elapsed.Seconds);
			watch = System.Diagnostics.Stopwatch.StartNew();
			Console.WriteLine(string.Join(" ", RotateLeft(a, k)));
			watch.Stop();
			Console.WriteLine("Printing :-" + watch.Elapsed.Seconds);
			Console.ReadLine();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="arr"></param>
		/// <param name="leftrotation"></param>
		/// <returns></returns>
		public static int[] RotateLeft(int[] arr, int leftrotation)
		{
			int sa = 0;
			int fn = arr[0];
			while (true)
			{
				if (sa == arr.Length - 1)
				{
					arr[arr.Length - 1] = fn;
					sa = 0;
					leftrotation = leftrotation - 1;
					if (leftrotation == 0) break;
					fn = arr[0];
					continue;
				}
				arr[sa] = arr[sa + 1];
				sa++;
			}
			return arr;
		}
	}
}
