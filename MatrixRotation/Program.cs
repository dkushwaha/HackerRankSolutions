using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixRotation
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			int m = 4;
			int n = 4;
			var readLine = Console.ReadLine();
			if (readLine == null) return;
			var tokens = readLine.Split(' ');
			if (tokens.Length < 3) return;
			m = Convert.ToInt32(tokens[0]);
			n = Convert.ToInt32(tokens[1]);
			var r = Convert.ToInt32(tokens[2]);
			var matrix = new int[m, n];
			for (var i = 0; i < m; i++)
			{
				var line = Console.ReadLine();
				if (line == null) continue;
				var data = line.Split(' ');
				for (var j = 0; j < n; j++)
				{
					matrix[i, j] = Convert.ToInt32(data[j]);
				}
			}
			for (int i = 0; i < r; i++)
			{
				matrix = RotateMatrix(matrix, m, n);
			}

			for (int i = 0; i < m; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
		/// <summary>
		/// Rotate the Matrix AntiClockise
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="input"></param>
		/// <param name="height"></param>
		/// <param name="width"></param>
		/// <returns></returns>
		private static T[,] Make2DArray<T>(T[] input, int height, int width)
		{
			T[,] output = new T[height, width];
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					output[i, j] = input[i * width + j];
				}
			}
			return output;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="matrix"></param>
		/// <param name="m"></param>
		/// <param name="n"></param>
		public static int[,] RotateMatrix(int[,] matrix, int m, int n)
		{
			var layers = n / 2;
			var mtx = new int[m, n];

			for (var lyr = 0; lyr < layers; lyr++)
			{
				var r1 = lyr;
				var r2 = m - lyr;
				var c1 = lyr;
				var c2 = n - lyr;
				var tmp = -1;
				for (var row = r1; row < r2; row++)
				{
					if (tmp > 0)
					{
						mtx[row, c1] = tmp;
					}
					if (row >= r1 && row <= r2)
					{
						for (var col = c1; col < c2; col++)
						{
							if (mtx[row, col] == tmp) continue;
							if (col >= c1 && col < c2 && row < r2 - 1)
							{
								var sourcecolumn = col == c2 - 1 ? col : col + 1;
								var sourcerow = col == c2 - 1 ? row + 1 : row;
								mtx[row, col] = matrix[sourcerow, sourcecolumn];
							}
							else
							{
								if (col >= c1 && col < c2 && row == r2 - 1)
								{
									var sourcecolumn = col - 1;
									mtx[row, col] = matrix[row, sourcecolumn];
								}
							}

						}
					}
					tmp = matrix[row, c1];
				}
			}
			return mtx;
		}
	}
}
