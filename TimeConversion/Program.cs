using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{

				Console.WriteLine("Enter the time:");
				var time = Console.ReadLine();
				var timein12format = time.Split(':');
				var hour = Convert.ToInt32(timein12format[0]);
				if (time.ToLower().Contains("am") && hour==12)
				{
					hour = 0;
				}
				if (time.ToLower().Contains("pm") && hour < 12)
				{
					hour = 12 + hour;
				}
				var format24 = string.Format("{0}:{1}:{2}", hour < 10 ? "0" + hour.ToString() : hour.ToString(), timein12format[1],
					timein12format[2].Substring(0, 2));
				Console.WriteLine(format24);
			}
		}
	}
}
