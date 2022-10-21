using System.Diagnostics.Metrics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicOperations calculator = new BasicOperations();
            Queue resultQueue = new Queue();

            bool activeStatus = true;
            while (activeStatus)
            {
                bool flag = true;
                while (flag)
                {


                    Console.WriteLine("\nPlease Enter first operand: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Enter second operand: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Entered operands are " + a + " and " + b);



                    Console.WriteLine("Please enter your choice for performing the following operations.");
                    Console.WriteLine("Addition (+) : 1");
                    Console.WriteLine("Subtract (-) : 2");
                    Console.WriteLine("Multiply (x) : 3");
                    Console.WriteLine("Division (/) : 4");
                    Console.WriteLine("Result Stack : 5");

                    Console.WriteLine("\nSelected choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    flag = false;
                    string result;
                    switch (choice)
                    {
                        
                        case 1:
                            result = calculator.add(a, b);
                            Console.WriteLine(result);
                            resultQueue.enQueue(result);
                            break;

                        case 2:
                            result = calculator.subtract(a, b);
                            Console.WriteLine(result);
                            resultQueue.enQueue(result);
                            break;

                        case 3:
                            result = calculator.multiply(a, b);
                            Console.WriteLine(result);
                            resultQueue.enQueue(result);
                            break;

                        case 4:
                            result = calculator.divide(a, b);
                            Console.WriteLine(result);
                            resultQueue.enQueue(result);
                            break;

                        case 5:
                            Console.WriteLine("Result History");
                            resultQueue.showResults();
                            Console.WriteLine("Do you want to clear the results history ?");
                            bool ans = Convert.ToBoolean( Console.ReadLine());
                            if (ans)
                            {
                                resultQueue.clearQueue();
                            }
                            break;
                        case 55:
                            string[] results= resultQueue.ResultQueue;
                            string[] dummyResults =
                            {
                                "7*1=7",
                                "2+2=4",
                                "5*5=25",
                                "2+3=6",
                                "2*1=2", };
                            int[] order = calculator.SortResults(dummyResults);
                            Console.WriteLine("Result History");
                            for (int i = 0; i < dummyResults.Length ; i++)
                            {
                                //Console.WriteLine(results[order[i]]);
                                Console.WriteLine(dummyResults[order[i]]);
                            }
                            break;



                        default:
                            Console.WriteLine("Choice Invalid for these Input types");
                            flag = true;    
                            break;    
                    }

                    Console.WriteLine("Do You Want to continue? Select Your Operation !!!");
                    Console.WriteLine("Press Y for Yes\nPress N for No");
                    char continueSelection = Convert.ToChar(Console.ReadLine());
                    if (continueSelection != 'Y')
                    {
                        if (continueSelection != 'N')
                        {
                            Console.WriteLine("Invalid Selection\nPress Enter to Terminate");
                            Console.ReadLine();
                        }
                            activeStatus = false;
                    }

                }
            }
        }
    }
}
