using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpyGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Area zoom = new Area();
            RunTime skip = new RunTime();
           
            
                skip.engine(zoom.area);
            
            Console.ReadLine();
        }
    }
}
