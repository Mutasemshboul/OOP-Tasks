namespace OOP___Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Toyota", new DateTime(2020, 1, 1), "Sedan", 25000m, "Camry", "PLT123", "Black");
            Console.WriteLine(car1);

            Toyota myToyota = new Toyota("Toyota", new DateTime(2023, 1, 1), "Sedan", 30000m, "Corolla", "TY123", "Silver", 180);
            Console.WriteLine(myToyota.ToString());
        }
    }
}
