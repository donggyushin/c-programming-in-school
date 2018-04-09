using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(-52273));    //절대값
            Console.WriteLine(Math.Ceiling(52.273));    //올림
            Console.WriteLine(Math.Floor(52.273));  //내림
            Console.WriteLine(Math.Max(52, 273));   //최대값
            Console.WriteLine(Math.Min(52, 273));   //최솟값
            Console.WriteLine(Math.Round(52.273));  //반올림
        }
    }
}
