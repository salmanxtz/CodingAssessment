using MarsRoverEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolveMarsTask
{
    public class RoverOutput
    {
        public void Display(string GRID, string rover1Intial, string roverDir, string rover2Initial, string rover2Dir)
        {
            ILandingSurface landingSurface = new Plateau(GRID);
            RoverSquad roverSquad = new RoverSquad(landingSurface);

            roverSquad.DeployNewRover(rover1Intial, roverDir);
            roverSquad.DeployNewRover(rover2Initial, rover2Dir);

            int roverOneIdx = 0;
            int roverTwoIdx = 1;

            IRover roverOne = roverSquad[roverOneIdx];
            IRover roverTwo = roverSquad[roverTwoIdx];

            Console.WriteLine("Input");
            Console.WriteLine(GRID);
            Console.WriteLine(rover1Intial);
            Console.WriteLine(roverDir);
            Console.WriteLine(rover2Initial);
            Console.WriteLine(rover2Dir);
            Console.WriteLine("\n");
            Console.WriteLine("OUTPUT");
            Console.WriteLine(roverOne.XCoordinate.ToString() + " " + roverOne.YCoordinate.ToString() + " " + roverOne.DirectionFacing);
            Console.WriteLine(roverTwo.XCoordinate.ToString() + " " + roverTwo.YCoordinate.ToString() + " " + roverTwo.DirectionFacing);
            Console.ReadLine();
        }
    }
}
