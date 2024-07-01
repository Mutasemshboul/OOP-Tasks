using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Tasks
{
    internal class Toyota : Car
    {
        public int TopSpeed { get; set; }
        public Toyota(string makes, DateTime year, string type, decimal price, string model, string palletNumber, string color,int topSpeed) : base(makes, year, type, price, model, palletNumber, color)
        {
            TopSpeed = topSpeed;
        }

        public override string ToString()
        {
            return base.ToString() + $"Top Speed {TopSpeed}";
        }
    }
}
