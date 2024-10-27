using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class UniqueElement
	{
		public class Program
		{
			static void Main()
			{
				int[] numbers = { 4, 7, 2, 3, 4, 5, 3, 6, 7, 8, 1, 8 };
				HashSet<int> distinctNumbers = new();
				HashSet<int> duplicateNumbers = new();

				foreach (int number in numbers)
				{
					if (!distinctNumbers.Add(number))
						duplicateNumbers.Add(number);
				}

				Console.WriteLine("original array");
				PrintArray(numbers);

				Console.WriteLine("distinct Numbers");
				PrintArray(distinctNumbers.ToArray());

				Console.WriteLine("duplicate Numbers");
				PrintArray(duplicateNumbers.ToArray());

				Console.ReadLine();
			}

			static void PrintArray(int[] numArray)
			{
				foreach (int num in numArray)
				{
					Console.Write($"{num} ");
				}
				Console.WriteLine();
			}
		}
	}
}
