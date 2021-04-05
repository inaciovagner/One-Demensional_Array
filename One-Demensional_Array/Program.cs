using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Demensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50 };
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}

                   
