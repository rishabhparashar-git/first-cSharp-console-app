namespace Calculator
{
    internal class BasicOperations : SecondaryOperations
    {
        public BasicOperations()
        {
            Console.WriteLine("New Calculator Initiated !!!");
        }

        private int result;

        //private int[,] resultStack;
        private string[] resultStack = new string[5];
        public string[] ResultStack() { return resultStack; }




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

        public void PushResult(int counter, string element)
        {
            if(counter < 5)
            {
                resultStack[counter] = element;
            }
        }
    }
}

// Override, virtual
// Singleton class 

// sorting