using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory3
{
     class Program
    {
        // 입출고 내용 저장
        static void Process(int[] x)
        {
            // 입고일 경우 x 는 input 배열을 받고 출고일경우는 output 배열과 연결된다
            Console.Write("날짜를 입력하세요 (1~31)");
            int day = int.Parse(Console.ReadLine()); // 날짜 입력
            if (0 < day && day < 32) // 날짜 에러 체크
            {
                Console.Write("수량을 입력하세요");
                 int qty = int.Parse(Console.ReadLine());
                x[day - 1] += qty; // 일 번호 위치 배열에 수량을 저장한다
            }
            else
            {
                Console.WriteLine("잘못된 날짜 입력 입니다");
            }
        }
        // 배열 x 의 합을 출력
        static void ShowSum(int[] x)
        {

        }
        // 총입고 - 총출고를 계산하여 현재고를 보여줌
        static void ShowCurrentStock(int[] input, int[] output) 
        {
        
        }
        // 한달동안 일별 입출고 내역을 보여준다
        static void ShowMonthHistory(int[] input, int[] output)
        {
        
        }
        static void Main(string[] args)
        {
            int[] input = new int[31];
            int[] output = new int[31];
            while (true)
            {
                Console.WriteLine("# 1=입고 , 2=출고 , 3=총입고량 , 4=총출고량 #");
                Console.WriteLine("# 5=재고량 , 6=월 현황 출력 , 0=프로그램 종료 #");
                Console.Write("원하는 작업을 입력하세요");

                int command = int.Parse(Console.ReadLine());

                if (command == 0)
                {
                    break;
                }
                switch (command)
                {
                    case 1:
                        Console.WriteLine("** 입고처리");
                        Process(input);
                        break;
                    case 2:
                        Console.WriteLine("** 출고처리");
                        Process(output);
                        break;
                    case 3:
                        Console.WriteLine("** 총 입고량은");
                        ShowSum(input);
                        break;
                    case 4:
                        Console.WriteLine("** 총 출고량은");
                        ShowSum(output);
                        break;
                    case 5:
                        ShowCurrentStock(input, output);
                        break;
                    case 6:
                        ShowMonthHistory(input, output);
                        break;
                }
            }           
        }
    }
}
