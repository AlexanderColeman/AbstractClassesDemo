using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public bool IsAManual { get; set; }

        public override void DriveAbstract()
        {
            throw new NotImplementedException();
        }
    }
}
