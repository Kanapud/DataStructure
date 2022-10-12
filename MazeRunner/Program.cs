using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Stacks;

namespace MazeRunner
{
    class Maze
    {
        class Cell
        {
            public int x, y;
            public Cell(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        private char[][] MAZE;
        private Stack stack = new ArrayStack(10);
        int x, y, xe, ye, step = 1;
        private const char EXIT = 'e', PLAYER = 'p', VISITED = '.', PASSAGE = '0', WALL = 'X';
        public Maze(string[] maze)
        {
            MAZE = new char[maze.Length + 2][];
            for (int i = 0; i < maze.Length; i++)
            {
                MAZE[i + 1] = (WALL + maze[i] + WALL).ToCharArray();
            }
            MAZE[0] = new char[MAZE[1].Length];
            MAZE[MAZE.Length - 1] = new char[MAZE[1].Length];
            for (int i = 0; i < MAZE[1].Length; i++)
            {
                MAZE[0][i] = WALL;
                MAZE[MAZE.Length - 1][i] = WALL;
            }
        }
        private void getLocation()
        {
            for (int i = 0; i < MAZE.Length; i++)
                for (int j = 0; j < MAZE[i].Length; j++)
                {
                    if (MAZE[i][j] == PLAYER)
                    { x = i; y = j; }
                    if (MAZE[i][j] == EXIT)
                    { xe = i; ye = j; }
                }
        }
        public bool solve()
        {
            getLocation();
            bool is_move = true;
            while (is_move && !(x == xe && y == ye))
            {
                getAvailablePath();
                is_move = move();
            }
            return false;
        }
        private void getAvailablePath()
        {
            if (MAZE[x - 1][y] == PASSAGE || MAZE[x - 1][y] == EXIT)
                stack.push(new Cell(x - 1, y));
            if (MAZE[x][y + 1] == PASSAGE || MAZE[x][y + 1] == EXIT)
                stack.push(new Cell(x, y + 1));
            if (MAZE[x + 1][y] == PASSAGE || MAZE[x + 1][y] == EXIT)
                stack.push(new Cell(x + 1, y));
            if (MAZE[x][y - 1] == PASSAGE || MAZE[x][y - 1] == EXIT)
                stack.push(new Cell(x, y - 1));
        }
        private bool move()
        {
            if (stack.isEmpty())
                return false;
            Cell m = (Cell)stack.pop();
            MAZE[m.x][m.y] = PLAYER;
            MAZE[x][y] = VISITED;
            x = m.x;
            y = m.y;
            Console.WriteLine("STEP: " + step++);
            display();
            return true;
        }
        public void display()
        {
            for (int i = 0; i < MAZE.Length; i++)
            {
                for (int j = 0; j < MAZE[i].Length; j++)
                { Console.Write(MAZE[i][j]); }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] game = {
                "0000Xe",
                "0XX000",
                "0XXX0p",
                "000000",
            };
            Maze maze = new Maze(game);
            maze.display();
            maze.solve();
            Console.ReadLine();
        }
    }
}
