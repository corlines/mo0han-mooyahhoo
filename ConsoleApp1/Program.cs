using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region final mouse
            //bool cc = false;
            //int x = 15;
            //if (x > 10 && x < 20) Console.WriteLine("[1-1]1.");

            //char ch = ' ';
            //if (ch != ' ' || ch != '\t')
            //    Console.WriteLine("[1-1]2.");
            //ch = 'x';
            //if (ch == 'x' || ch == 'X')
            //    Console.WriteLine("[1-1]3.");
            //ch = '5';
            //if (ch >= '0' && ch<='9')
            //    Console.WriteLine("[1-1]4.");
            //ch = 'b';
            //if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
            //    Console.WriteLine("[1-1]5.");
            //string cha = "yes";
            //if (cha.Equals("yes"))
            //    Console.WriteLine("[1-1]6.");
            //int tl = 0;


            //for(int i = 1; i <= 20; i++)
            //{
            //    if(i % 2 != 0 && i%3 != 0)
            //    {
            //        tl += i;
            //    }
            //}
            //Console.WriteLine("[1-2]." + tl);


            //tl = 0;
            //int sum = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //     tl += i;
            //    sum += tl;
            //}
            //Console.WriteLine("[1-3]." + sum);



            //tl = 0;
            //int n = 0;
            //int delta = 1;
            //Console.WriteLine("[1-4].");
            //for (int i = 1; ;i++)
            //{
            //    tl += i * delta;
            //    delta = -delta;
            //    if (tl >= 100)
            //    {
            //        Console.WriteLine(i);
            //        break;
            //    }
            //}


            //Console.WriteLine("[1-5].");
            //tl = 0;
            //for (int i = 1;i <= 6;i++)
            //{
            //    if(6-i != 0)
            //       Console.WriteLine(i + "+"+(6-i) +"=6");
            //}
            //int y = 0, j = 0;

            //while((y++) <= 10)
            //{

            //    j = 0;
            //    while ((j++)< y)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //j = 0;
            //y = 0;
            //while (y < 10)
            //{


            //    j = 0;
            //    while (j < y)
            //    {
            //        Console.Write("*");
            //        j++;
            //    }

            //    Console.WriteLine();
            //    y++;


            //}
            //string str = "12345";
            //int sun = 0;
            //y = 0;
            //while(y<str.Length)
            //{

            //    char sc = str.ElementAt(y);

            //    y++;
            //    sun += sc - '0';

            //}

            //Console.WriteLine(sun);
            #endregion
            Shape[] shapes = { new Rectangle(2, 4),  new circle(1)};
            foreach(Shape s in shapes)
            {
                s.calcArea();
                Console.WriteLine(s.area);
                s.round();
                Console.WriteLine(s.ro);
            }
        }
        

    }
    class Rectangle : Shape
    {
        int width { get; init; }
        int height { get; init; }

        public Rectangle(int v1, int v2)
        {
            this.width = v1;
            this.height = v2;
        }
        public override void calcArea()
        {
            area = width * height;
        }
        public override void round()
        {
            ro = width * 2 + height * 2;
        }
    }
    abstract class Shape
    {
        public double area;
        public double ro;
        public abstract void calcArea();
        public abstract void round();
    }
    class circle : Shape
    {
        double diameter { get; init; }
        public circle(double v1) 
        {
            this.diameter = v1;
        }
        public override void calcArea()
        {
            area = diameter / 2 * diameter / 2 * 3.14159265358979;
        }
        public override void round()
        {
            ro = diameter * 3.14159265358979;
        }
    }
}
