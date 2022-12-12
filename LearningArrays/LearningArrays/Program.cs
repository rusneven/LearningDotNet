using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of string size 5. Fill array items with values.
            string[] names = new string[] { "Name1", "Name2", "Name3", "Name4", "Name5" };
            
            //Print all words using loop
            foreach (string state in names)
            {
                // The `state` variable takes on the value of an element in `states` and updates every iteration.
                Console.WriteLine(state);
            }

            //Create an int array size 20. 
            int[] intArray = new int[20];

            // Fill values from 0 till 20.
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;
            }

            // Print numbers backwards
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }

        }
    }
}
