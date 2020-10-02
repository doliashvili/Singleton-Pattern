using System;
using System.Threading.Tasks;

namespace SingleTonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                  () => GetInstance1(),
                  () => GetInstance2(),
                  () => GetInstance3()
                );

            //Parallel.Invoke(
            //      () => GetInstance1().GetBox(),
            //      () => GetInstance2().GetBox(),
            //      () => GetInstance3().GetBox()
            //    );

            //GetInstance1().GetBox();
            //GetInstance2().GetBox();
            //GetInstance3().GetBox();

            Console.ReadLine();
        }

        private static SingleTon GetInstance1()
        {
            SingleTon obj1 = SingleTon.Instance;
            return obj1;
        } 
        private static SingleTon GetInstance2()
        {
            SingleTon obj1 = SingleTon.Instance;
            return obj1;
        } 
        private static SingleTon GetInstance3()
        {
            SingleTon obj1 = SingleTon.Instance;
            return obj1;
        }
    }
}
