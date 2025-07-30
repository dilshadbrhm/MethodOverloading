using System.Data;

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area(2));
            Console.WriteLine(Area(2,3));
            Console.WriteLine(Area(1,2,3));
            Console.WriteLine(Area(1,2,3,4));


        }
        public static int Area(int r)
        {
            int p = 3;
            int s = r * r * p;
            return s;
        }

        public static int Area(int a, int b)
        {
            int s = a * b;
            return s;
        }
        public static int Area(int a, int b, int c)
        {
            int s = 2 * ((a * b) + (a * c) + (b * c));
            return s;
        }
        public static int Area(int a, int b, int c, int r)
        {
            int p = (a+b+c)/2;
            int s = p * r;

            return s; 
        }



    }
}
