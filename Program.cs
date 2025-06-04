using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample32
{
    class Program
    {
        static void Main(string[] args)
        {   
            //상수 readonly 키워드 비교 예제
           Item item1 = new Item( "고구마", 1000);
            Item item2 = new Item("감자", 2000);
            Item item3 = new Item("옥수수", 3000);
            Console.WriteLine(item1.id);
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            //item3.id = 100; // readonly 키워드가 지정된 인스턴스 변수는 수정 불가

            // 참조 복사
            Test test1 = new Test();
            test1.value = 5;
            Change(test1); // test1을 참조로 전달
            Console.WriteLine(test1.value); // 20 출력
        }
        class Test
        {
            public int value = 10;
        }
        static void Change(Test input) //메인메서드오 ㅏ같은 위치 레퍼런스를 매개변수로 받음
        {
            input.value = 20; // 참조 복사로 인해 원본 값이 변경됨
        }
    }
}