using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utils
{
    class DirectoryInfoSample
    {
        void Main()
        {
            DirectoryInfo di = new DirectoryInfo(@"C:\tests");
            FileInfo fi = new FileInfo(@"C:\tests\test.txt");
            if (!di.Exists)
            {
                di.Create();
                fi.Create();
            }
            di.Delete(true);

        }
    }
}
