using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignment
{
	internal class Negative
	{

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, -5, 6, 7, -55, -77 };


            foreach (int items in arr)
            {
                if (items < 0)
                {
                    Console.WriteLine("Negative Elements Array: {0}",items);
                }

            }






        }
    }
}
