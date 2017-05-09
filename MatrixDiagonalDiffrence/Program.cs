using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonalDiffrence
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = Convert.ToInt32(Console.ReadLine());
			int[][] a = new int[n][];
			for (int a_i = 0; a_i < n; a_i++)
			{
				string[] a_temp = Console.ReadLine().Split(' ');
				a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
			}
			int sum = 0,sum1=0;
			for (int r = 0; r < n; r++)
			{
				for (int c = 0; c < n; c++)
				{
					if (r == c)
					{
						sum += a[r][c];
					}
				}
			}
			int tmp = 0;
			for (int r = n-1; r >= 0; r--)
			{
				sum1 += a[r][tmp];
				tmp++;
			}
			
			Console.WriteLine(Math.Abs(sum1-sum));
		}
	}
}
