using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    using System;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Arithmetic()
        {
            int num1;
            int num2;
            double sum;

            Console.Write("Enter first integer: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second integer: ");
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;

            Console.WriteLine($"Sum is {sum}");
            sum = num1 * num2;
            Console.WriteLine($"Product is {sum}");
            sum = num1 - num2;
            Console.WriteLine($"Difference is {sum}");
            sum = num1 / num2;
            Console.WriteLine($"Quotient is {sum}." + (num1 % num2));
        }
        static void StringOut()
        {
            int[] Values = { 1, 2, 3, 4 };
            Console.WriteLine("1 2 3 4");
            Console.Write("1 ");
            Console.Write("2 ");
            Console.Write("3 ");
            Console.Write("4\n");
            Console.WriteLine($"{Values[0]} {Values[1]} {Values[2]} {Values[3]}");
        }
        static void MathAssignment()
        {
            double r = 1;
            Console.WriteLine("Enter the Radius: ");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine($"Diameter is {2 * r}");
            Console.WriteLine($"Circumference is {2 * Math.PI * r}");
            Console.WriteLine($"Area is {Math.PI * (r * r)}");
        }
        /*static void InvoiceAssignment()
        /*static void Main(string[] args)
        {
            void Display(Invoice ToDisplay)
            {
                Console.WriteLine("Invoice");
                Console.WriteLine($"Part Number: {ToDisplay.GetPartNumber()}");
                Console.WriteLine($"Quantity: {ToDisplay.GetQuantity()}");
                Console.WriteLine($"Description: {ToDisplay.GetDescription()}");
                Console.WriteLine($"Price Per Unit: {ToDisplay.GetUnitPrice()}");
                Console.WriteLine($"Total Price: {ToDisplay.CalculatePrice()}");
            }

            Display(new Invoice("AB001", "Test Item", 5, 125.23));
        }*/
        static void comassignment()
        {
            Item i1 = new Item(1, (decimal)239.99);
            Item i2 = new Item(2, (decimal)129.75);
            Item i3 = new Item(3, (decimal)99.95);
            Item i4 = new Item(4, (decimal)350.89);
            Item[] Items = { i1, i2, i3, i4 };
            decimal TotalCom = 200;
            Console.WriteLine("Please Enter the number of items sold for each type: ");
            foreach (Item i in Items)
            {
                Console.Write($"Item {i.GetID()} (Commission Value: {i.GetCom()}): ");
                TotalCom += int.Parse(Console.ReadLine()) * i.GetCom();
            }

        }
        static void DupeAssignment()
        {

        }
        static void LINQ()
        {
            
        }
        static void States()
        {
            List<char> letters = new List<char>();
            List<char> Distinct = new List<char>();

            Random r = new Random();
            for (int i = 0; i < 30; i++)
            {
                letters.Add((char)('A' + r.Next(0, 26)));
            }
            foreach (var c in letters.Distinct())
            {
                Distinct.Add(c);
            }
            var asc = from char c in letters orderby c ascending select c;
            Console.WriteLine("Ascending: ");
            foreach (char d in asc) { Console.Write(d); }
            var desc = from char c in letters orderby c descending select c;
            Console.WriteLine("\nDescending: ");
            foreach (char d in desc) { Console.Write(d); }
            var unique = from char c in Distinct orderby c ascending select c;

            Console.WriteLine($"\nUnique (Ascending) TYPE = {unique.GetType().ToString()}: ");
            foreach (char d in unique) { Console.Write(d); }
            Console.WriteLine();
        }
        static void Shapes()
        {
            Shape[] Shapes = { new Circle { Radius = 5 }, new Square { SideLength = 10 }, new Sphere { Radius = 7 }, new Cube { SideLength = 3 } };
            int i = 1;
            foreach (Shape s in Shapes)
            {
                if (s is Shape2D)
                {
                    Console.Write($"{i} - {s.GetType()} (2D Shape): ");
                    if (s is Circle) { Console.WriteLine($"Radius is {(s as Circle).Radius} | Area is {(s as Circle).Area}"); }
                    if (s is Square) { Console.WriteLine($"Side Length is {(s as Square).SideLength} | Area is {(s as Square).Area}"); }
                }
                else if (s is Shape3D)
                {
                    Console.Write($"{i} - {s.GetType()} (3D Shape) ");
                    if (s is Sphere) { Console.WriteLine($"Radius is {(s as Sphere).Radius} | Area is {(s as Sphere).Area} | Volume is {(s as Sphere).Volume}"); }
                    if (s is Cube) { Console.WriteLine($"Side Length is {(s as Cube).SideLength} | Area is {(s as Cube).Area} | Volume is {(s as Cube).Volume}"); }
                }
            }
        }
        static void Main(string[] args)
        {
            Stack<char> word = new Stack<char>();
            string input = Console.ReadLine();
            foreach (char c in input.ToCharArray())
            {
                word.Push(c);
            }
            Console.WriteLine();
            foreach (char c in word)
            {
                word.p
                Console.Write(c);
            }
            Console.WriteLine();
        }
        public class Example
        {
            double _y = 0.1;
            public double Y
            {
                get { return _y; }
                set 
                { 
                    if (value > 0) { _y = value; }
                    else { throw new BasicException($"Exception in {this.GetType()}: Y Cannot be set to a number less than zero"); } 
                }
            }
        }
        public class ExampleChild : Example { };


    [System.Serializable]
    public class BasicException : Exception
    {
        public BasicException() { }
        public BasicException(string message) : base(message) { }
            
    }
}
    public abstract class Shape { }
    public abstract class Shape2D : Shape
    {
        public int a = 10;
        public abstract double Area
        {
            get;
        }
    }
    public abstract class Shape3D : Shape
    {
        public abstract double Area
        {
            get;
        }
        public abstract double Volume
        {
            get;
        }
    }
    public class Circle : Shape2D
    {
        public double Radius;
        public override double Area
        {
            get { return Math.PI * Math.Pow(Radius, 2); }
        }
    }
    public class Square : Shape2D
    {
        public double SideLength;
        public override double Area
        {
            get { return Math.Pow(SideLength, 2); }
        }
    }
    public class Sphere : Shape3D
    {
        public double Radius;
        public override double Area
        {
            get { return 4 * Math.PI * Math.Pow(Radius, 2); }
        }
        public override double Volume
        {
            get { return (4 / 3) * Math.PI * (Radius * 3); }
        }
    }
    public class Cube : Shape3D
    {
        public double SideLength;
        public override double Area
        {
            get { return 6 * Math.Pow(SideLength, 2); }
        }
        public override double Volume
        {
            get { return Math.Pow(SideLength, 3); }
        }
    }




    public class Item
    {
        int _id;
        decimal _value;
        public Item(int ID, decimal Cost)
        {
            _id = ID;
            _value = Cost;
        }
        public int GetID()
        {
            return _id;
        }
        public decimal GetCom()
        {
            return ((decimal)_value) * (decimal).09;
        }
    }
}

