﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortPart1
{
	class Program
	{
		static void insertionSort(int[] ar)
		{
			var e = ar[ar.Length-1];
			for (int i = ar.Length-2; i >=0; i--)
			{
				
				if (ar[i] > e)
				{
					ar[i + 1] = ar[i];
				}
				else
				{
					ar[i+1] = e;
					foreach (var i1 in ar)
					{
						Console.Write(i1 + " ");
					}
					break;
				}
				foreach (var i1 in ar)
				{
					Console.Write(i1+" ");
				}
				Console.WriteLine();
				if (i == 0 && ar[i] > e)
				{
					ar[0] = e;
					foreach (var i1 in ar)
					{
						Console.Write(i1 + " ");
					}
					break;
				}
				
			}
		}
		/* Tail starts here */
		static void Main(String[] args)
		{

			int _ar_size;
			_ar_size = Convert.ToInt32(Console.ReadLine());
			int[] _ar = new int[_ar_size];
			String elements = Console.ReadLine();
			String[] split_elements = elements.Split(' ');
			for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
			{
				_ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
			}

			insertionSort(_ar);
		}
	}
}
