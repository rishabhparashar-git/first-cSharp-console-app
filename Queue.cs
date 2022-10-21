using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Queue
    {

        private static Queue instance = null;
        public static Queue Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Queue();
                }
                return instance;
            }
        }

        private static int size=3;
        private static int totalElements=0;

        private string[] resultQueue = new string[size];
        public string[] ResultQueue{ get { return resultQueue; } }

        /*
        private int userInputSize;
        private Queue()
        {
            Console.WriteLine("Enter the size of Queue");
            userInputSize = Convert.ToInt32(Console.ReadLine);
        }
        public static void sizeInit()
        {
            size = userInputSize;
        }
        */


        public void enQueue(string data)
        {
            if (totalElements < size)
            {
                resultQueue[totalElements++] = data;
            }
            else
            {
                for(int i=0; i < totalElements-1; i++)
                {
                    resultQueue[i] = resultQueue[i+1];
                }
                resultQueue[totalElements-1] = data;
            }
        }
        public void showResults()
        {
            for (int i= resultQueue.Length-1; i >= 0 ; i--)
            {
                Console.WriteLine(resultQueue[i]);
            }
        }
        public void clearQueue()
        {
            for (int i = 0; i < resultQueue.Length; i++)
            {
                resultQueue[i]="empty";
            }
        }


    }
}
