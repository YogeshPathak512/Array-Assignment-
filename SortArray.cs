using System;
using System.Collections.Generic;
using System.Globalization;
namespace Demo
{
	public class MyApplication
	{
		public static void Main(string[] args)
		{
			int[] aaray1 = { 98, 23, 97, 36, 77 };
			Console.WriteLine("Original Unsorted List :");
			foreach (int i in aaray1)
			{
				Console.Write(i + " ");
			}
			Array.Sort(aaray1);
            Console.WriteLine();
			Console.WriteLine("Sorted List :");
            
  
		 for (int i = 0; i < aaray1.Length; i++)
			{
				Console.Write(aaray1[i] + " ");
			}
		}
	}
}
