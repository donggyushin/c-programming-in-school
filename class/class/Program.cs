using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Program
    {

        class MyMath
        {
            public static double PI = 3.14;
        }

        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1,2,3,4,5,6};
            foreach (var item in intList)
            {
                Console.WriteLine(intList.Count + " : " + item);
            }

            Console.WriteLine(MyMath.PI);


            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            foreach ( var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
