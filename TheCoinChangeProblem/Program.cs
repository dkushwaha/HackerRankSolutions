using System;
using System.Collections;
using System.Linq;

namespace TheCoinChangeProblem
{
	class Program
	{
		private static long sum = 0;

		private static long getWays(long n, long[] c)
		{
			Array.Sort(c);
			var hashtable = new Hashtable();
			long tmp = n;
			string series = null;
			for (int j = 0; j < c.Length; j++)
			{
				if (n%c[j] == 0)
				{
					for (int i = 0; i < n/c[j]; i++)
					{
						series += c[j];
					}
					sum++;
					hashtable.Add(sum,series);
					series = null;
				}
				
			}
			for (int i = 0; i < c.Length; i++)
			{
				tmp = n;
				while (true)
				{
					bool brk = false;
					for (int j = 0; j < c.Length; j++)
					{
						if (j == 0&&tmp==n)
						{
							if (c[i] <= tmp)
							{
								tmp -= c[i];
								series += c[i];
							}
						}
						else
						{
							if (c[j] <= tmp)
							{
								tmp -= c[j];
								series += c[j];
							}	
						}
						
						if (tmp == 0)
						{
							if (!hashtable.ContainsValue(series))
							{
								sum++;
								hashtable.Add(sum, series);
							}
							series = null;
							tmp = n;
							brk = true;
							break;
						}
					}
					if (brk||c.Min()>tmp)
					{
						break;
					}
						

				}
			}
			return sum;
		}

		private static void Main(String[] args)
		{
			string[] tokens_n = Console.ReadLine().Split(' ');
			long n = long.Parse(tokens_n[0]);
			long m = long.Parse(tokens_n[1]);
			string[] c_temp = Console.ReadLine().Split(' ');
			long[] c = Array.ConvertAll(c_temp, long.Parse);
			long ways = getWays(n,c);
			Console.WriteLine(ways);
		}
	}
}
