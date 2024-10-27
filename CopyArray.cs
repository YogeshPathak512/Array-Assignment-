using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	class CopyArray
	{
		static void Main(string[] args)
		{
			int[] arr = { 1, 2, 3, 5, 7, 8 };
			int[] arr2 = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				arr2[i] = arr[i];
			}
			foreach (int i in arr2)
			{
				Console.Write(i + " ");
			}

		}
	}
}
