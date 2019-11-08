using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(DateTime.Now.Millisecond); // Define a random variable
            int[] A = new int[20];
            int[] B = new int[20];
            int[] C = new int[20];
            int size = A.Length;
            for (int i=0; i<size; i++) // Fills the arrays with numbers
            {
                A[i] = r.Next(18, 123);
                B[i] = r.Next(18, 123);
            }
            for (int i = 0; i < size; i++) // Check which array is larger and the difference is put in the array C
            {
                if (A[i] > B[i])
                    C[i] = A[i] - B[i];
                else C[i] = B[i] - A[i];
            }
            for (int i = 0; i < size; i++) //Printing array A
                Console.Write("{0,-5}",A[i]);
            Console.WriteLine();
            for (int i = 0; i < size; i++) //Printing array B
                Console.Write("{0,-5}", B[i]);
            Console.WriteLine();
            for (int i = 0; i < size; i++)
                Console.Write("{0,-5}", C[i]); //Printing array C
            Console.WriteLine();

        }

    }
}
