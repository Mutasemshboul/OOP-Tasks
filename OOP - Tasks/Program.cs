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




            string filePath = "personal_info.txt";

            // Writing to the file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name: Mutasem Ali Shboul");
                writer.WriteLine("Specialization: Software Development");
                writer.WriteLine("Age: 23");
                writer.WriteLine("Description: I am a software developer working in the tech industry, focusing on web development.");
            }

            // Reading from the file and processing contents
            int totalCharacters = 0;
            int totalWords = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);  // Print the line

                    // Count characters excluding spaces
                    totalCharacters += line.Replace(" ", "").Length;

                    // Count words
                    totalWords += line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
                }
            }

            // Outputting the results
            Console.WriteLine("Total number of characters (without spaces): " + totalCharacters);
            Console.WriteLine("Total number of words (disregarding spaces): " + totalWords);
        }
    }
    
}
