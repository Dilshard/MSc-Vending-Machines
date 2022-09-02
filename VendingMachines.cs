using System;
namespace VendingMachines
{
	public class VendingMachines
	{
		private String location;

		public VendingMachines()
		{
		}

		public VendingMachines(int value1)
		{
		}

		public void addCans(int num)
        {
			Console.WriteLine("Test addCans");
        }

		public void setName(String value1)
        {
			Console.WriteLine("Test setName");
		}

		public bool insertToken(int value1)
        {
			return true;
        }

		public void setLocation(String location)
        {
			this.location = location;
        }
	}
}

