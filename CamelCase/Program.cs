using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CamelCase
{
	class Program
	{
		private static void Main(string[] args)
		{
			string s = Console.ReadLine();
			var words = Regex.Replace(s, "(\\B[A-Z])", " $1").Split(' ');
			Console.WriteLine(words.Count());
		}
	}
}
