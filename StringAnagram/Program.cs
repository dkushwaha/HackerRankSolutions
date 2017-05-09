using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAnagram
{
	class Program
	{
		private static void Main(string[] args)
		{
			string a = Console.ReadLine();
			string b = Console.ReadLine();
			int deletionnumbers = 0;
			var a_arr = a.ToCharArray();
			var b_arr = b.ToCharArray();
			var aarr = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
			for (int i = 0; i <=aarr.Length - 1; i++)
			{
				var count = a_arr.Count(t => t == aarr[i]);
				var count1 = b_arr.Count(t => t == aarr[i]);
				if (count == count1) continue;
				deletionnumbers += count > count1 ? count - count1 : count1 - count;
			}
			Console.WriteLine(deletionnumbers);
		}
	}
}
