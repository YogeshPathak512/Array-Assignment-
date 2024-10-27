using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class AscendingOrder
	{

        static void Main(string[] args)
        {
			int[] arr = new int[] { 1, 10, 6, 7, 5, 9 };


			Array.Sort(arr);
			Console.WriteLine("Ascending: ");
			foreach (int value in arr)
			{
				Console.Write(value + " ");
			}
			Console.ReadLine();



		}













	}
}
