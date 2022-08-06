using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode01
{
    public class ArrangeElements
    {
        public int[] ArrangePairs(int [] inputArray)
        {
            if(inputArray is null)
                throw new ArgumentNullException(nameof(inputArray));

            var tempArray = new int[inputArray.Length];
            int counter = 0;//Reset this if count is even
            int index = 0; 

            foreach (var item in inputArray)
            {
                counter++;

                tempArray[index] = item;

                if (counter == 2)
                {
                    counter = 0;
                    if (inputArray[index] < inputArray[index - 1])
                    {
                        tempArray[index] = inputArray[index - 1];
                        tempArray[index - 1] = inputArray[index];
                    }
                }

                index++;
            }

            return tempArray;
        }
    }
}
