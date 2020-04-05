using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = {1,2,2};
            int n=19;
            int [] a = { 0, 1, 0, 12, 3 }; 

            ArrayEasy test = new ArrayEasy();
            test.A283_MoveZeroes(a);
            Console.WriteLine(a);
            Console.Read();

        }
    }
}
