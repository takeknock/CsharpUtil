using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    class PercentileCalculator
    {
        private double[] data;
        public PercentileCalculator(IEnumerable<double> sequence)
        {
            data = sequence.ToArray();
            Array.Sort(data);
        }

        /// <summary>
        /// O(N) because of ToArray as deep copy.
        /// </summary>
        /// <param name="sequence"></param>
        /// <param name="percentile"></param>
        /// <returns></returns>
        public double Calculate(double percentile)
        {
            int N = data.Length;
            double n = (N - 1) * percentile + 1;
            if (n == 1d) return data[0];
            else if (n == N) return data[N - 1];
            else
            {
                int k = (int)n;
                double d = n - k;
                return data[k - 1] + d * (data[k] - data[k - 1]);
            }
        }
    }
}
