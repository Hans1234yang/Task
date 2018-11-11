using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 封装task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //myTask t1 = new myTask(SayHi);
            //t1.MyStart();
           

            //myTask t2 = new myTask
            //    (
            //      () => { Console.WriteLine("Hello world"); }
            //    );
            //t2.MyStart();


            //int 指的是返回结果类型 
            MyTask<int> t3 = new MyTask<int>(Add);
            t3.Start();
            int result = t3.Result();
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Add()
        {
            return 1+2;
        }



        static void SayHi()
        {
            Console.WriteLine("hello hans ");
        }
    }

    public class myTask
    {
        Action action1;
        public myTask(Action _action1)
        {
            action1 = _action1;
        }

        public void MyStart()
        {
            action1();  //调用这个action
        }

    }

    public class MyTask<TResult>
    {
        Func<TResult> Func1;    ///参数类型为 TResult的 action

            //接受返回值
        public  TResult result;
        private Func<int> add;

        public MyTask(Func<int> add)
        {
            this.add = add;
        }

        public void myTask(Func<TResult> _Func1)
        {
            Func1 = _Func1;
        }

        public void myTask()
        {

        }

        public void Start()
        {
            result= Func1();
        }

        public TResult Result()
        {
            return result ;
        }
    }

}
