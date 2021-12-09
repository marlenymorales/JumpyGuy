using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpyGuy
{
    class RunTime
    {
        int jump = 0;
        int x = 1;
        int y = 1;
        int walk;
        bool grounded = true;
        bool running = false;
        public void engine(char[,] area)
        {
            bool play = true;
            //Keyboard test = new Keyboard();
            while (play)
            {
                string frame = "";
                //Console.WriteLine(x + " " + y + " " + grounded + " " + jump);
                if (jump > 0)
                {
                    if (area[x, y + 1] != 'X')
                    {
                        y = y + 1;
                    }
                    jump--;
                }
                if (area[x, y - 1] == 'X')
                {
                    grounded = true;
                }
                else if (jump <= 0)
                {
                    y--;
                    grounded = false;
                } else
                {
                    grounded = false;
                }
                if (walk == 1 && area[x + 1, y] != 'X')//(System.Windows.Input.Keyboard.IsKeyDown(System.Windows.Input.Key.LeftShift) == true)
                {
                    x++;
                }
                else if (walk == -1 && area[x - 1, y] != 'X')
                {
                    x--;
                }
                else
                {
                }
                //player position
                for (int i = 0; i < 160; i++)
                {
                    for (int j = 0; j < 40; j++)
                    {
                        if (area[i, j] == 'z')
                        {
                            area[i, j] = ' ';
                        }
                        if (i == x && j == y)
                        {
                            area[i, j] = 'z';
                        }
                    }
                }
                //draw field
                for (int i = 40; i >= 0; i--)
                {
                    for (int j = 0; j < 160; j++)
                    {
                        frame += area[j, i];
                    }
                    frame += "\r\n";
                }
                Console.Write(frame);
                string input = Console.ReadLine();
                if (input.Length > 0)
                {
                    if (input[0] == 'w' || input[0] == 'W' || input[0] == ' ')
                    {
                        if (grounded)
                        {
                            jump = 10;
                        }
                    }
                    else if (input[0] == 's' || input[0] == 'S')
                    {
                        jump = 0;
                    }
                    else if (input[0] == 'a' || input[0] == 'A')
                    {
                        walk = -1;
                    }
                    else if (input[0] == 'd' || input[0] == 'D')
                    {
                        walk = 1;
                    }
                    else if (input[0] == 'x' || input[0] == 'X')
                    {
                        walk = 0;
                    }
                }
            }
        }
    }
}