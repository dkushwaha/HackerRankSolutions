using System;

namespace BigSorting
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			var unsorted = new string[n];
			for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
			{
				unsorted[unsorted_i] = Console.ReadLine();
			}
			for (int j = 0; j < unsorted.Length - 1; j++)
			{
				for (int i = 0; i < unsorted.Length-1; i++)
				{
					if (!IsFirstGreaterThenSecond(unsorted[i], unsorted[i + 1])) continue;
					var tmp = unsorted[i];
					unsorted[i] = unsorted[i + 1];
					unsorted[i + 1] = tmp;
				}
			}
			foreach (string t in unsorted)
			{
				Console.WriteLine(t);
			}
		}

		public static bool IsFirstGreaterThenSecond(string s1, string s2)
		{
			if (s1.Length == s2.Length)
			{
				for (int i = 0; i < s1.Length; i++)
				{
					if (s1[i] == s2[i]) continue;
					return s1[i] > s2[i];
				}
			}
			return s1.Length > s2.Length;
		}
	}
}
