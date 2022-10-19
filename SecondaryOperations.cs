using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class SecondaryOperations
    {
        public int[] SortResults(string[] arr)
        {
            int n = arr.Length;
            int[] indexArr = new int[n];
            int[] elementArr= new int[n];
            for (int i = 0; i < n; i++)
            {
                int siz = arr[i].Length;
                string ele = arr[i]; 
                indexArr[i] = i;
                elementArr[i] = Convert.ToInt32(ele[siz - 1]); ;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (elementArr[i] > elementArr[j])
                    {
                        int temp;
                        temp = elementArr[j];
                        elementArr[j] = elementArr[i];
                        elementArr[i] = temp;
                        int xtemp;
                        xtemp = indexArr[j];
                        indexArr[j] = indexArr[i];
                        indexArr[i] = xtemp;
                    }
                }
            }
            return indexArr;

        }
    }
}
