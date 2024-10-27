using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class MinAndMax
	{
        static void Main(string[] args)
        {
			int[] Numbers = { 23, 55, 66, 77, 8898, 9 };

			Console.WriteLine("Minimum number is " + Numbers.Min());
			Console.WriteLine("Maximum number is " + Numbers.Max());
		}
        

	}
}
