using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo
{
    class TicTacToe
    {
        public static bool p1move = true;
        public static bool winner = false;
        public static bool p1win = false;
        public static bool draw = false;
        /*static void Main(string[] args)
        {
            
            int[,] board = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            
            while(winner == false && draw == false)
            {
                board = Game(board);
            }
            int[,] c = board;
            Console.WriteLine($"   A   B   C \n");
            Console.WriteLine($"1   {x(c[0, 0])}| {x(c[1, 0])} |{x(c[2, 0])} ");
            Console.WriteLine($"   ---------");
            Console.WriteLine($"2   {x(c[0, 1])}| {x(c[1, 1])} |{x(c[2, 1])} ");
            Console.WriteLine($"   ---------");
            Console.WriteLine($"3   {x(c[0, 2])}| {x(c[1, 2])} |{x(c[2, 2])} ");
            if (winner) { Console.WriteLine($"Player {(p1win ? "1" : "2")} Wins"); }
            else if (draw) { Console.WriteLine("The game has ended in a draw"); }
        }*/
        public static int[,] Game(int[,] currentboard)
        {
            int[,] c = currentboard;
            Console.WriteLine($"   A   B   C \n");
            Console.WriteLine($"1   {x(c[0,0])}| {x(c[1, 0])} |{x(c[2, 0])} ");
            Console.WriteLine($"   ---------");
            Console.WriteLine($"2   {x(c[0, 1])}| {x(c[1, 1])} |{x(c[2, 1])} ");
            Console.WriteLine($"   ---------");
            Console.WriteLine($"3   {x(c[0, 2])}| {x(c[1, 2])} |{x(c[2, 2])} ");
            Console.WriteLine($"Player {(p1move ? "1" : "2")} please enter your move by entering the coordinates you'd like to take (for example, A1)");
            char[] userin = Console.ReadLine().ToCharArray();
            int[] input = { y(userin[0]), int.Parse(userin[1].ToString())-1 };
            Console.Clear(); 

            if (input[0] < 0 || input[0] > 2 || input[1] < 0 || input[1] > 2) { Console.WriteLine("Invalid Move: Must be between A1 and C3"); return c; }
            
            if (c[input[0], input[1]].Equals(0))
            {
                c[input[0], input[1]] = p1move ? 1 : 2;
                if (p1move) { p1move = false; }
                else { p1move = true; };
            }
            else { Console.WriteLine($"Invalid Move: Space {userin[0]}{userin[1]} is taken"); }

            //X Axis Win check
            for(int x = 0; x < 3; x++)
            {
                int p1 = 0;
                int p2 = 0;
                for (int y = 0; y < 3; y++)
                {
                    if (c[x, y].Equals(1)) { p1++; }
                    else if (c[x, y].Equals(2)){ p2++;}
                }
                if (p1 >= 3) { p1win = true; winner = true; break; }
                if (p2 >= 3) { p1win = false; winner = true; break; }
            };
            //Y Axis Win check
            for (int y = 0; y < 3; y++)
            {
                int p1 = 0;
                int p2 = 0;
                for (int x = 0; x < 3; x++)
                {
                    if (c[x, y].Equals(1)) { p1++; }
                    else if (c[x, y].Equals(2)) { p2++; }
                }
                if (p1 >= 3) { p1win = true; winner = true; break; }
                if (p2 >= 3) { p1win = false; winner = true; break; }
            };
            //Diag Win check
            if(c[0,0].Equals(1) && c[1,1].Equals(1) && c[2,2] == 1) { p1win = true; winner = true;  }
            if (c[0, 0].Equals(2 )&& c[1, 1].Equals(2) && c[2, 2].Equals(2)) { p1win = false; winner = true; }

            if (c[2, 0].Equals(1) && c[1, 1].Equals(1) && c[0, 2].Equals(1)) { p1win = true; winner = true; }
            if (c[2, 0].Equals(2) && c[1, 1].Equals(2) && c[0, 2].Equals(2)) { p1win = false; winner = true; }

            //Draw check
            draw = true;
            foreach(int i in c)
            {
                if (i.Equals(0)) { draw = false; }
            }

            return c;
        }
        public static string x(int value)
        {
            switch(value)
            {
                case 0: return " ";
                default: return value.ToString();
            }
        }
        public static int y(char input)
        {
            if (input == 'A') return 0;
            if (input == 'B') return 1;
            if (input == 'C') return 2;
            return 3;
        }
    }
}
