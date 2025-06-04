using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sample
    {
        public static int classVar = 0;

        static Sample()
        {
            classVar = 100;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}
