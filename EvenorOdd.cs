using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class EvenorOdd
	{

		public static void Main()
		{
			int[] values = { 1, 22, 13, 44, 52, 66, 71, 88, 99, 100 };

			foreach (var result in values)
			{
				if (result % 2 == 0)
				{
					Console.WriteLine(result + " is Even Value");
				}
				else
				{
					Console.WriteLine(result + " is Odd Value");
				}
			}
		}










	}
}
