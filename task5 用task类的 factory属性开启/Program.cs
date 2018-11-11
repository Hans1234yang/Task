using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5_用task类的_factory属性开启
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(Test);
            Console.ReadLine();
        }

        static void Test()
        {
            Console.WriteLine("Hello world");
        }
    }
}
