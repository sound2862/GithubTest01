using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //삼각형의 넓이를 구하는 수식을 작성하라.
            Console.Write("세로 : ");
            int height = int.Parse(Console.ReadLine());

            Console.Write("가로 : ");
            int width = int.Parse(Console.ReadLine());

            double result = (width * height)/2.0;

            Console.WriteLine("결과는? : " + result);
        }
    }
}
