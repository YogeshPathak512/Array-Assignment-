using System;
using System.Collections.Generic;

public class MergeTwoArray
{
	public static void Main()
	{
		int[] array1 = { 1, 2 };
		int[] array2 = { 3, 4,8 };
		var list = new List<int>();
		for (int i = 0; i < array1.Length; i++)
		{
			list.Add(array1[i]);
			list.Add(array2[i]);
		}
		int[] array3 = list.ToArray();
		foreach (int res in array3)
		{
			Console.WriteLine(res);
		}
	}
}