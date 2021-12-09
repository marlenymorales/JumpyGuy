using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpyGuy
{
    class Area
    {
        public char[,] area = new char[165, 45];
        public Area()
        {
            for (int i = 0; i < 40; i++)
            {
                for (int j = 0; j < 160; j++)
                {
                    if (i == 0) { area[j, i] = 'X'; }
                    if (i == 5)
                    {
                        if (j >= 10 && j <= 30)
                            /////
                        {
                            area[j, i] = 'X';
                        }
                        else if (j >= 130 && j <= 150)
                        {
                            area[j, i] = 'X';
                        }

                        /////
                    }
                    if (i == 8)
                    {
                        if (j >= 40 && j <= 50)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (i == 5)
                    {
                        if (j >= 85 && j <= 95)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (i == 8)
                    {
                        if (j >= 100 && j <= 110)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 9)
                    {
                        if (i >= 1 && i <= 5)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 20)
                    {
                        if (i >= 5 && i <= 10)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 40)
                    {
                        if (i >= 1 && i <= 8)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 80)
                    {
                        if (i >= 1 && i <= 5)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 100)
                    {
                        if (i >= 1 && i <= 10)
                        {
                            area[j, i] = 'X';
                        }
                    }
                    if (j == 120)
                    {
                        if (i >= 1 && i <= 15)
                        {
                            area[j, i] = 'X';
                        }
                    }
                }
            }
        }
    }
}







