using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NullRobot : Robot
    {
        public void Clean()
        {
        }

        public bool Move()
        {
            return true;
        }

        public void TurnLeft()
        {
        }

        public void TurnRight()
        {
        }
    }
}
