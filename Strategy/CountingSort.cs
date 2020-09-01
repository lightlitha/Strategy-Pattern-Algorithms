using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CountingSort : ISort
    {
        public object RunAlgorithm(object data)
        {
            var list = data as List<int>; // Data type object to int
            int[] output = new int[list.Count]; // new output array
            // Length for unique numbers
            int countLength = 0;
            foreach (var element in list)
            {
                countLength = Math.Max(countLength, element);
            }
            int[] count = new int[countLength]; // Stores the count of each unique number
            for(int i = 0; i < count.Length; ++i)
            {
                count[i] = 0;
            }
            for(int i = 0; i < list.Count; ++i)
            {
                ++count[list[i]];
            }
            
            //Change count[i] so that count[i] now contains actual position of  
            //this character in the output array.
            for (int i = 1; i <= count.Length-1; ++i)
            {
                count[i] += count[i - 1];
            }

            //Build the output array.
            //To make this sorting algorithm stable, we are operating in reverse order. 
            for (int i = list.Count - 1; i >= 0; i--)
            {
                output[count[list[i]] - 1] = list[i];
                --count[list[i]];
            }

            //Copy the output array to the final array.
            for (int i = 0; i < list.Count; ++i)
            {
                list[i] = output[i];
            }

            return list;
        }
    }
}
