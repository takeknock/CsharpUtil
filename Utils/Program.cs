using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] data = { 0, 1, 2, 3, 4, 5 };
            PercentileCalculator percentile = new PercentileCalculator(data);
            double result = percentile.Calculate(0.25);
            Console.WriteLine(result);



        }
    }
}
