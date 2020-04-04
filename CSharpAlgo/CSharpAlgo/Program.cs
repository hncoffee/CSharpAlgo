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
            int [] a = {-2,1,-3,4,-1,2,1,-5,4}; 

            ArrayEasy test = new ArrayEasy();
            int t = test.A53_MaxSubArray(a);
            Console.WriteLine(t);
            Console.Read();

        }
    }
}
