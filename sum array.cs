using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class sum_array
	{





		public static int CalculateSum(int[] numbers)
		{
			int sum = 0; 

			
			foreach (int number in numbers)
			{
				sum += number; 
			}

			return sum;

		}
		public static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5 }; 

			
			int totalSum = CalculateSum(numbers);

			// Display the result
			Console.WriteLine($"The sum of all elements in the array is: {totalSum}");
		}
	}






}

