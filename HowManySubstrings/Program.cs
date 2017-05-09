using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HowManySubstrings
{
	class Program
	{
		private static void Main(string[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]);
			int q = Convert.ToInt32(tokens_n[1]);
			//string s = File.ReadAllText(@"C:\Users\dkushwaha\Desktop\testinput.txt");  //Console.ReadLine();
			var s = Console.ReadLine();
			if(string.IsNullOrEmpty(s))return;
			for (int a0 = 0; a0 < q; a0++)
			{
				string[] tokens_left = Console.ReadLine().Split(' ');
				int left = Convert.ToInt32(tokens_left[0]);
				int right = Convert.ToInt32(tokens_left[1]);
				var arr = s.ToCharArray();
				var sb = new StringBuilder();
				for (int i = left; i <= right; i++)
				{
					sb.Append(arr[i]);
				}
				var substring = sb.ToString();
				var data = GetPermutation(substring);
				Console.WriteLine(data);

			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int GetPermutation(string s)
		{
			var table = new List<string>();
			for (int k = 0; k < s.Length; k++)
			{
				for (int i = 1; i <= s.Length - k; i++)
				{
					var key = s.Substring(k, i);
					if (!table.Contains(key))
					{
						table.Add(key);
					}
				}
			}
			return table.Count;
		}
	}
}
