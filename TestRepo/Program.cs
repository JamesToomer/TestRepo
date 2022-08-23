using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    using System;
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
            Invoice[] invoices = new Invoice[8];
            invoices[0] = new Invoice(83, "Electric sander", 7, 59.98m);
            invoices[1] = new Invoice(24, "Power saw", 7, 99.99m);
            invoices[2] = new Invoice(7, "Sledge hammer", 7, 21.50m);
            invoices[3] = new Invoice(77, "Hammer", 7, 11.99m);
            invoices[4] = new Invoice(39, "Lawn mower", 7, 79.50m);
            invoices[5] = new Invoice(68, "Screwdriver", 7, 6.99m);
            invoices[6] = new Invoice(56, "Jig saw", 7, 11.00m);
            invoices[7] = new Invoice(3, "Wrench", 7, 7.50m);
            var PartDesc =
                from Invoice i in invoices
                orderby i.PartDescription descending
                select i;
            var Price =
                from Invoice i in invoices
                orderby i.Price descending
                select i;
            var Quantity =
                from Invoice i in invoices
                orderby i.Quantity descending
                select (i.PartDescription, i.Quantity);
            var TotalCost =
                from Invoice i in invoices
                let InvoiceTotal = i.Price * i.Quantity
                orderby InvoiceTotal descending
                select new { i.PartDescription, InvoiceTotal };
            var InRange =
                from i in TotalCost
                where (i.InvoiceTotal < 500 && i.InvoiceTotal > 200)
                select i;
            Console.WriteLine(InRange.GetType().ToString() + "\n\n\n");
            Console.WriteLine("Original:");
            foreach (var i in invoices) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nSorted by description:");
            foreach (var i in PartDesc) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nSorted by price:");
            foreach (var i in Price) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nSorted by Quantity:");
            foreach (var i in Quantity) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nSorted by total cost of items:");
            foreach (var i in TotalCost) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nSorted by total cost of items:");
            foreach (var i in TotalCost) { Console.WriteLine($"{i}"); }
            Console.WriteLine("\nBetween $200 and $500:");
            foreach (var i in InRange) { Console.WriteLine($"{i}"); }
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
        static void Main(string[] args)
        {
            Shape[] Shapes = { new Circle { Radius = 5 }, new Square { SideLength = 10 }, new Sphere { Radius = 7 }, new Cube { SideLength = 3 } };
            int i = 1;
            foreach(Shape s in Shapes)
            {
                if(s is Shape2D) 
                { 
                    Console.Write($"{i} - {s.GetType()} (2D Shape): "); 
                    if(s is Circle) { Console.WriteLine($"Radius is {(s as Circle).Radius} | Area is {(s as Circle).Area}"); }
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
    }
    public abstract class Shape { }
    public abstract class Shape2D : Shape
    {
        public int a = 10;
        public abstract double Area
        {
            get { return 0; }
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
            get { return Math.PI*Math.Pow(Radius,2); }
        }
    }
    public  class Square : Shape2D
    {
        public double SideLength;
        public override double Area
        {
            get { return Math.Pow(SideLength,2); }
        }
    }
    public  class Sphere : Shape3D
    {
        public double Radius;
        public override double Area
        {
            get { return 4*Math.PI*Math.Pow(Radius,2); }
        }
        public override double Volume
        {
            get { return (4/3)*Math.PI*(Radius*3); }
        }
    }
    public  class Cube : Shape3D
    {
        public double SideLength;
        public override double Area
        {
            get { return 6*Math.Pow(SideLength,2); }
        }
        public override double Volume
        {
            get { return Math.Pow(SideLength,3); }
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
    public class oldInvoice
    { 
        //string Number{ get { return ""; } set{ Number = "Num: " } };
        string Number;
        string Description;
        int Quantity;
        double UnitPrice;
        public oldInvoice(string PartNumber, string PartDescription, int PartQuantity, double price)
        {
            Number = PartNumber;
            Description = PartDescription;
            Quantity = PartQuantity;
            UnitPrice = price;
        }
        public double CalculatePrice()
        {
            return Quantity * UnitPrice;
        }
        
        public string GetPartNumber() { return Number; }
        public string GetDescription() { return Description; }
        public int GetQuantity() { return Quantity; }
        public double GetUnitPrice() { return UnitPrice; }
        public void SetPartNumber(string NewNumber) { Number = NewNumber; }
        public void SetDescription(string NewDescription) { Description = NewDescription; }
        public void SetUnitPrice(double NewPrice) { if (NewPrice > 0) { UnitPrice = NewPrice; } }
        public void SetQuantity(int NewQuantity) { if (NewQuantity > 0) { Quantity = NewQuantity; } }
    }
public class Invoice
    {
        // declare variables for Invoice object
        private int quantityValue;
        private decimal priceValue;
        // auto-implemented property PartNumber
        public int PartNumber { get; set; }
        // auto-implemented property PartDescription
        public string PartDescription { get; set; }
        // four-argument constructor
        public Invoice(int part, string description,
           int count, decimal pricePerItem)
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            Price = pricePerItem;
        }
        // property for quantityValue; ensures value is positive
        public int Quantity
        {
            get
            {
                return quantityValue;
            }
            set
            {
                if (value > 0) // determine whether quantity is positive
                {
                    quantityValue = value; // valid quantity assigned
                }
            }
        }
        // property for pricePerItemValue; ensures value is positive
        public decimal Price
        {
            get
            {
                return priceValue;
            }
            set
            {
                if (value >= 0M) // determine whether price is non-negative
                {
                    priceValue = value; // valid price assigned
                }
            }
        }
        // return string containing the fields in the Invoice in a nice format
        public override string ToString()
        {
            // left justify each field, and give large enough spaces so
            // all the columns line up
            return $"{PartNumber,-5} {PartDescription,-20} {Quantity,-5} {Price,6:C}";
        }
    }
}
