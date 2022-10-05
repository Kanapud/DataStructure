using System;
using Stacks;

namespace TowerOfHanoi
{
    internal class Program
    {
        class ToH
        {
            private int n_disk, n_move;
            private Stack a, b, c;
            public ToH(int n_disk)
            {
                this.n_disk = n_disk;
                a = new ArrayStack(n_disk);
                b = new ArrayStack(n_disk);
                c = new ArrayStack(n_disk);
                reset();
            }
            private void reset()
            {
                for (int i = n_disk; i >= 1; i--)
                    a.push(i);
            }
            public bool move(string f, string t)
            {
                Stack from = a, to = b;
                switch (f)
                {
                    case "A":
                        from = a;
                        break;
                    case "B":
                        from = b;
                        break;
                    case "C":
                        from = c;
                        break;
                }
                switch (t)
                {
                    case "A":
                        to = a;
                        break;
                    case "B":
                        to = b;
                        break;
                    case "C":
                        to = c;
                        break;
                }
                if (!from.isEmpty())
                {
                    int d = (int)from.peek();
                    if (to.isEmpty() || (int)to.peek() > d)
                    {
                        to.push(from.pop());
                        n_move++;
                        display();
                        return true;
                    }
                    return false;
                }
                return false;
            }
            public void display()
            {
                object[] data_a = ((ArrayStack)a).DATA();
                object[] data_b = ((ArrayStack)b).DATA();
                object[] data_c = ((ArrayStack)c).DATA();
                if (a.isEmpty())
                    Console.Write(n_move + ": [] ");
                else
                {
                    Console.Write(n_move + ": [");
                    for (int i = 0; i < a.size(); i++)
                    {
                        Console.Write(data_a[i] + ",");
                    }
                    Console.Write("\b] ");
                }
                if (b.isEmpty())
                    Console.Write("[] ");
                else
                {
                    Console.Write("[");
                    for (int i = 0; i < b.size(); i++)
                    {
                        Console.Write(data_b[i] + ",");
                    }
                    Console.Write("\b] ");
                }
                if (c.isEmpty())
                    Console.Write("[]\n");
                else
                {
                    Console.Write("[");
                    for (int i = 0; i < c.size(); i++)
                    {
                        Console.Write(data_c[i] + ",");
                    }
                    Console.Write("\b]\n");
                }
                if (CheckWin())
                    Console.WriteLine("Win");
            }
            public Stack A() { return a; }
            public Stack B() { return b; }
            public Stack C() { return c; }
            public bool CheckWin()
            {
                if (c.size() == n_disk)
                    return true;
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many disks do you want?");
            int n_disk = int.Parse(Console.ReadLine());
            ToH game = new ToH(n_disk);
            game.display();
            while (!game.CheckWin())
            {
                Console.WriteLine("From");
                string f = Console.ReadLine();
                Console.WriteLine("To");
                string t = Console.ReadLine();
                bool valid_move = game.move(f, t);
                if (!valid_move)
                    Console.WriteLine("Invalid move, try again");
            }
            Console.ReadLine();
        }
    }
}
