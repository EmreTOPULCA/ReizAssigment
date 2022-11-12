using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizAssigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Question(Using Clock class)
            //------------------------------------
            Clock clock = Clock.CreateClock();
            clock.CalculateAngel();
            //------------------------------------

            //2.Question(Using Branch class)
            //------------------------------------
            Branch root = Branch.InitializeTree(); //structure given in assignment
            int depth = root.CalculateDepth();
            Console.WriteLine();
			Console.WriteLine("Your structure's depth: "+ depth);
			Console.ReadLine();
            //------------------------------------


        }
    }
}
