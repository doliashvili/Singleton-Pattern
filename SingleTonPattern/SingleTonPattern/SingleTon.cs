using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTonPattern
{
    public sealed class SingleTon
    {
        private static volatile SingleTon instance;
        private static object lockObject = new object();
        private int numberOfInstance = 0;

        private int box = 3;

        private SingleTon()
        {
            numberOfInstance++;
            Console.WriteLine("Number of instances ={0}", numberOfInstance);
        }


        public int GetBox()
        {
            if (box > 0)
            {
                box--;
                Console.WriteLine($"number of box: {box}");
                return box;
            }
            Console.WriteLine($"number of box: {box}");
            return 0;
        }

        public static SingleTon Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SingleTon();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
