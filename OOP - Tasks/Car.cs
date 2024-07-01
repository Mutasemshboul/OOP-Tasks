using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Tasks
{
    internal class Car
    {
        public string Makes { get; set; }
        public DateTime Year   { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public string Model { get; set; }
        public string PalletNumber { get; set; }
        public string Color { get; set; }

        public Car(string makes, DateTime year, string type, decimal price, string model, string palletNumber, string color)
        {
            Makes = makes;
            Year = year;
            Type = type;
            Price = price;
            Model = model;
            PalletNumber = palletNumber;
            Color = color;
        }

        public void StartEngine()
        {
            Console.WriteLine("The Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("The Engine stoped");
        }


        public override string ToString()
        {
            return $"Car: {Makes}, Year: {Year.ToString("yyyy")}, Type: {Type}, Price: ${Price:F2}, Model: {Model}, Pallet Number: {PalletNumber}, Color: {Color}";
        }



    }
}
