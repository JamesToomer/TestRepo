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
        static void InvoiceAssignment()
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
        }
        static void comassignment()
        {
            Item i1 = new Item(1, (decimal)239.99);
            Item i2 = new Item(2, (decimal)129.75);
            Item i3 = new Item(3, (decimal)99.95);
            Item i4 = new Item(4, (decimal)350.89);
            Item[] Items = { i1, i2, i3, i4 };
            decimal TotalCom = 200;
            Console.WriteLine("Please Enter the number of items sold for each type: ");
            foreach(Item i in Items)
            {
                Console.Write($"Item {i.GetID()} (Commission Value: {i.GetCom()}): ");
                TotalCom += int.Parse(Console.ReadLine()) * i.GetCom();
            }
        
        }
        public class AutoPolicy
        {
            public int accountNumber;
            public string makeAndModel;
            string _state;
            public string State
            {
                get => _state;
                set
                {
                    _state = value;
                }

            }
            public AutoPolicy(int Account, string MakeModel, string State)
            {
                accountNumber = Account;
                makeAndModel = MakeModel;
                _state = State;
            }

            public bool IsNoFaultState
            {
                get
                {
                    if(_state.Equals("CT")||_state.Equals("MA") ||_state.Equals("ME") ||_state.Equals("NH") ||_state.Equals("NJ") ||_state.Equals("NY") ||_state.Equals("PA") ||_state.Equals("VT"))
                    { 
                        bool noFaultState;

                        switch (_state)
                        {
                            case "MA": case "NJ": case "NY": case "PA":
                                noFaultState = true;
                                break;
                            default:
                                noFaultState = false;
                                break;
                        }
                        
                        return noFaultState;
                    }
                    else { Console.WriteLine($"Policy: #{accountNumber} cannot have their state set to {State}"); return false;}
                }

            }
        }
        static void PolicyAssignment()
        {
            //create two AutoPolicy objects
            AutoPolicy policy1 = new AutoPolicy(11111111, "Toyota Camry", "NJ");
            AutoPolicy policy2 = new AutoPolicy(22222222, "Ford Fusion", "ME");
            Console.WriteLine(Math.Pow(6, 5));
            void PolicyInNoFaultState(AutoPolicy Pol)
            {
                Console.WriteLine($"The Auto Policy:\n Account #{Pol.accountNumber}; Car: {Pol.makeAndModel}\nState: {Pol.State} {(Pol.IsNoFaultState ? "is" : "is not")} a no-fault state");
            }

            PolicyInNoFaultState(policy1);
            PolicyInNoFaultState(policy2);
        }
        public static double toCelsius(double TempF)
        {
            return 5.0 / 9.0 * (TempF - 32);
        }
        public static double toFarenheit(double TempC)
        {
            return 9.0/5.0*TempC+32;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Desired unit (C/F)");
            string userin = Console.ReadLine();
            double temp;
            if (userin.Equals("C")) { Console.WriteLine("Now enter the temperature in Farenheit"); temp = toCelsius(double.Parse(Console.ReadLine())); Console.WriteLine($"The temperature in Celsius is {temp}"); }
            else if (userin.Equals("F")) { Console.WriteLine("Now enter the temperature in Celsius"); temp = toFarenheit(double.Parse(Console.ReadLine())); Console.WriteLine($"The temperature in Farenheit is {temp}"); }
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
