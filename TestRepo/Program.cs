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

    }
    public class Invoice
    { 
        //string Number{ get { return ""; } set{ Number = "Num: " } };
        string Number;
        string Description;
        int Quantity;
        double UnitPrice;
        public Invoice(string PartNumber, string PartDescription, int PartQuantity, double price)
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
}
