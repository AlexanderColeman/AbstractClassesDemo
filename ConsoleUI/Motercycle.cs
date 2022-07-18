using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public bool HasASideCar { get; set; }

        public string Type { get; set; }

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drive one handed");
        }
    }
}
