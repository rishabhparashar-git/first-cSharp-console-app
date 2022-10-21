namespace Calculator
{
    internal class BasicOperations : SecondaryOperations
    {
        public BasicOperations()
        {
            Console.WriteLine("New Calculator Initiated !!!");
        }
        private int result;

        public string add(int a, int b)
        {
            result = a + b;
            return($"{a} + {b} = {result}");
        }

        public string subtract(int a, int b)
        {
            result = a - b;
            return ($"{a} - {b} = {result}");
        }

        public string multiply(int a, int b)
        {
            result = a * b;
            return($"{a} x {b} = {result}");
        }

        public string divide(int a, int b)
        {
            result = a / b;
            return($"{a} / {b} = {result}");
        }

        public override int[] SortResults(string[] arr)
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
                for (int j = 0; j < currentEle.Length; j++)
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

// Override, virtual
