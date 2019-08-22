using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static int[] arr = { 1, 31, 23, 41, 12 };
        static int temp;
        static void Main(string[] args)
        {
            Print();
        }
        public void InsertSort()
        {

        }
        public static void Print()
        {
            Console.Write("Unsorrted array is:");
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i]+" ");
                
                    }
            Console.Read();
        }
    }
}
