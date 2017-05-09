using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciArt
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			WaterTank tank = new WaterTank();
			WaterTankMonitor monitor = new WaterTankMonitor(tank);
			monitor.Fill();
			monitor.Empty();
			Console.ReadLine();

		}



	}

	public class WaterTankMonitor
	{
		private WaterTank tank;
        object sync=new object();
		public WaterTankMonitor(WaterTank tank)
		{
			this.tank = tank;
		}

		public void Empty()
		{
			lock (sync)
			{
				while (tank.IsEmpty())
				{
				}
				tank.SetEmpty(true);
			}
		}

		public void Fill()
		{
			lock (sync)
			{
				while (!tank.IsEmpty())
				{
				}
				tank.SetEmpty(false);
			}
		}
	}
}

public class WaterTank
{
	private bool empty = true;

	public virtual bool IsEmpty()
	{
		return empty;
	}

	public virtual void SetEmpty(bool b)
	{
		// Something is wrong if b == empty
		empty = b;
		Console.WriteLine(empty ? "Empty" : "Full");
	}
}
