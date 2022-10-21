using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Calculator
{
    internal class SecondaryOperations
    {
        public virtual int[] SortResults(string[] arr)
        {
            int n = arr.Length;
            int[] indexArr = new int[n];
            int[] elementArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                string currentEle = arr[i];
                int siz = currentEle.Length;
                indexArr[i] = i;
                string numFound = "";
                for (int j = currentEle.Length - 1; j >= 0; j--)
                {
                    char currentChar = currentEle[j];
                    if (Char.IsDigit(currentChar))
                    {
                        numFound = currentChar + numFound;
                    }
                    else
                    {
                        break;
                    }
                }
                int num = Convert.ToInt32(numFound);
                indexArr[i] = i;
                elementArr[i] = num;
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
