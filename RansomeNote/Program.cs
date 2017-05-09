using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomeNote
{
	class Program
	{
		private static void Main(string[] args)
		{
			//string[] tokens_m = Console.ReadLine().Split(' ');
			int m = 6; //Convert.ToInt32(tokens_m[0]);
			int n = 4; // Convert.ToInt32(tokens_m[1]);
			string[] magazine = "give me one grand today night".Split(' '); //Console.ReadLine().Split(' ');
			string[] ransom = "give me one today give".Split(' '); //Console.ReadLine().Split(' ');
			var magmap= CreateHashTable(magazine);
			var ranmap = CreateHashTable(ransom);
			Console.WriteLine(Solve(magmap, ranmap) ? "Yes" : "No");

		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public static Hashtable CreateHashTable(string[] arr)
		{
			if (arr == null) return null;
			var table = new Hashtable();
			foreach (var s in arr)
			{
				if (!table.ContainsKey(s))
				{
					table.Add(s,1);
				}
				else
				{
					var count = (int) table[s];
					count++;
					table[s] = count;
				}
			}
			return table;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="magmap"></param>
		/// <param name="ranmap"></param>
		/// <returns></returns>
		public static bool Solve(Hashtable magmap, Hashtable ranmap)
		{
			foreach (var tb in ranmap.Keys)
			{
				if (!magmap.ContainsKey(tb)) return false;
				int mgwordcount = (int) magmap[tb];
				int ranwordcount = (int) ranmap[tb];
				if (mgwordcount < ranwordcount) return false;
			}
			return true;
		}
	}
}
