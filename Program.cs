using System.Diagnostics.Metrics;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicOperations calculator = new BasicOperations();
            bool activeStatus = true;
            while (activeStatus)
            {
                Console.WriteLine("\nPlease Enter first operand: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please Enter second operand: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Entered operands are "+a+" and "+b);
                bool flag = true;
                int counter = 0;
                while (flag & (counter < 5))
                {
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
                            calculator.PushResult(counter, result);
                            counter++;
                            break;

                        case 2:
                            result = calculator.subtract(a, b);
                            Console.WriteLine(result);
                            calculator.PushResult(counter, result);
                            counter++;
                            break;

                        case 3:
                            result = calculator.multiply(a, b);
                            Console.WriteLine(result);
                            calculator.PushResult(counter, result);
                            counter++;
                            break;

                        case 4:
                            result = calculator.divide(a, b);
                            Console.WriteLine(result);
                            calculator.PushResult(counter, result);
                            counter++;
                            break;

                        case 5:
                            string[] resultStack = calculator.ResultStack();
                            Console.WriteLine("Result History");
                            for (int i = 0; i < counter; i++)
                            {
                                Console.WriteLine(resultStack[i]);
                            } 
                            break;
                        case 55:
                            string[] anotherResultStack = calculator.ResultStack();
                            int[] order = calculator.SortResults(anotherResultStack);
                            Console.WriteLine("Result History");
                            for (int i = 0; i < counter; i++)
                            {
                                Console.WriteLine(anotherResultStack[order[i]]);
                            }
                            break;



                        default:
                            Console.WriteLine("Sorry Invalid Choice");
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
