using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(
                     () => { Console.WriteLine("hello world"); }
                );
            t1.Start();
            Console.ReadLine();
        }
    }
}
