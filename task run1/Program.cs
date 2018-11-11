using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_run1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task.run 无参数，无返回值使用  //因为 task.run 的参数是 Action，并没有Action<int ,int> 所以不能有参数
            //Task.Run(
            //    () =>{ Console.WriteLine("hello world"); }
            //    );
            //Console.ReadLine();

           Task<int> t1=   Task<int>.Run<int>(
                () =>{ return 1 + 2; }
                );
           var result= t1.Result;
           Console.WriteLine(result);
           Console.ReadLine();

        }
     
    }
}
