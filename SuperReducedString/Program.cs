using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
	class Program
	{
		private static void Main(string[] args)
		{
			var input = Console.ReadLine();
			if (input == null) return;
			while (true)
			{
				var str = input.ToCharArray();
				input = string.Empty;
				bool found = true;
				for (int i = 0; i < str.Length; i++)
				{
					if ((i < str.Length - 1) && str[i] == str[i + 1])
					{
						str[i] = ' ';
						str[i + 1] = ' ';
						found = false;
					}
					else
					{
						if (str[i] != ' ')
						{
							input += str[i];
						}
					}

				}
				if (found) break;
			}
			Console.WriteLine(input.Length == 0 ? "Empty String" : input);
		}
	}
}
