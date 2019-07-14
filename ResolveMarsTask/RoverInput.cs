using MarsRoverEngine;
using ResolveMarsTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverClient
{
    class Program
    {
        static void Main(string[] args)
        {           
            RoverOutput output = new RoverOutput();
            output.Display("5 5", "1 2 N", "LMLMLMLMM", "3 3 E", "MMRMMRMRRM");
        }
    }
}
