using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        protected double S { get; set; }
        protected double P{ get; set; }

        public abstract double Find_p();
        public abstract double Find_s();


    }
    class Triangle : Figure
    {
        public Triangle(int a, int b, int c) {
            if (a + b > c && b + c > a && c + a > b)
            {
                this.a = a; this.b = b; this.c = c;
            }
            else
            {
                Console.WriteLine("Трикутник неможливий");
            }
        }

        public override double Find_p()
        {
            double res = (a + b + c) / 2;
            P = res;
            return res;
        }
        public override double Find_s()
        {
            double p = Find_p();
            double res = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            S = res;
            return res;
        }

        int a,b,c;
        
    }

    class Rectangle : Figure
    {
        public Rectangle(int a, int b)
        {

            this.a = a; this.b = b;

        }
        int a, b;
        public override double Find_p()
        {
            double res = 2*(a+b);
            return res;
        }
        public override double Find_s()
        {
            double res = a*b;
            return res;
        }
    }

    class Square : Figure
    {
        public Square(int a)
        {

            this.a = a;

        }
        int a;
        public override double Find_p()
        {
            double res = 4 * a;
            return res;
        }
        public override double Find_s()
        {
            double res = a * a;
            return res;
        }
    }

    class Diamond : Figure
    {
        public Diamond(int a,int b)
        {

            this.a = a; this.b = b;

        }
        int a,b;
        public override double Find_p()
        {
            double res = -1;
            return res;
        }
        public override double Find_s()
        {
            double res = -1;
            return res;
        }
    }

    class Parallelogram : Figure
    {
        public Parallelogram(int a,int b,int h)
        {
            this.h = h;
            this.a = a;
            this.b = b;

        }
        int a,b,h;
        public override double Find_p()
        {
            double res = 2 * (a+b);
            return res;
        }
        public override double Find_s()
        {
            double res = h * a;
            return res;
        }

    }

    class Trapeze : Figure
    {
        public Trapeze(int a, int b,int c,int d,int h)
        {

            this.a = a; this.b = b; this.c = c; this.d = d;
            this.h = h;
            m = (a + b) / 2;

        }
        int a, b,c,d,h,m;
        public override double Find_p()
        {
            double res = a + b + c + d;
            return res;
        }
        public override double Find_s()
        {
            double res = m*h;
            return res;
        }

    }

    class Circle : Figure
    {
        public Circle(int r)
        {

            this.r = r;

        }
        int r;
        public override double Find_p()
        {
            double res = 2 * 3.14 * r;
            return res;
        }
        public override double Find_s()
        {
            double res = 3.14 * (r*r);
            return res;
        }
    }

    class Elipse : Figure
    {
        public Elipse(int a,int b)
        {

            this.a = a; this.b = b;

        }
        int a,b;
        public override double Find_p()
        {
            double res = 4 * ( (3.14 * a * b + (a - b)) / ( a + b ) );
            return res;
        }
        public override double Find_s()
        {
            double res = 3.14 * a * b;
            return res;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть номер фігури площу і периметр яких хочете розрахувати: ");
            Console.WriteLine("1 - трикутник \n2 - квадрат \n3 - прямокутник \n4 - паралелограм \n5 - ромб \n6 - трапеція \n7 - коло \n8 - еліпс");
            int choice = Convert.ToInt32(Console.ReadLine());
            int a,b,c,d,h,r;
            Figure f;
            switch (choice)
            {
                case 1:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону c");
                    c = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Triangle(a,b,c);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");
                    break;
                case 2:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Square(a);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");
                    break;
                case 3:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Rectangle(a, b);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                case 4:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть висоту h");
                    h = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || h <= 0 || b <=0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Parallelogram(a,b, h);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                case 5:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Diamond(a, b);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                case 6:

                    Console.WriteLine("Введіть сторону а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону b");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону c");
                    c = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть сторону d");
                    d = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть висоту h");
                    h = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || h <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Trapeze(a, b, c, d, h);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                case 7:

                    Console.WriteLine("Введіть радіус r");
                    r = Convert.ToInt32(Console.ReadLine());

                    if (r <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Square(r);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                case 8:

                    Console.WriteLine("Введіть напівось а");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введіть напівось b");
                    b = Convert.ToInt32(Console.ReadLine());

                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("Некоректні дані");
                        break;
                    }

                    f = new Elipse(a, b);

                    Console.WriteLine($"Периметр фігури - {f.Find_p()}");
                    Console.WriteLine($"Площа фігури - {f.Find_s()}");

                    break;
                default:
                    Console.WriteLine("Некоректний вибір");
                    break;
            }
            Console.ReadKey();
        }
    }
}
