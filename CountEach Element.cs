using System;
using System.Collections.Generic;

class Program1
{
	static void Main()
	{
		// Example array
		int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 1, 1, 3, 2 };

		// Dictionary to store the count of each element
		Dictionary<int, int> elementCount = new Dictionary<int, int>();

		// Loop through the array and count occurrences
		foreach (var item in arr)
		{
			if (elementCount.ContainsKey(item))
			{
				elementCount[item]++;
			}
			else
			{
				elementCount[item] = 1;
			}
		}

		// Output the results
		Console.WriteLine("Element counts:");
		foreach (var pair in elementCount)
		{
			Console.WriteLine($"{pair.Key}: {pair.Value}");
		}
	}
}
