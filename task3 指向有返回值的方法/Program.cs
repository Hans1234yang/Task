using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_指向有返回值的方法
{
    class Program
    {
        //task 3 调用的方法有返回类型
        static void Main(string[] args)
        {
            //Task<int> t1 = new Task<int>(FangFa);
            //t1.Start();
            //int result = t1.Result;
            //Console.WriteLine(result);

            Task<int> t2 = new Task<int>(
                () => { return 1 + 2; }
                );

            t2.Start();
            int result2 = t2.Result;
            Console.WriteLine(result2);

            Console.ReadLine();
        }

        static int FangFa()
        {
            return 1 + 2;
        }
    }
}
