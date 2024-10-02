using System.Diagnostics.Tracing;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using OfficeOpenXml;
using System.IO;


namespace ExEpsilon
{
    public class Movie()
    {
        public string Title;
        public string Genre;
        public double Rating;
        public int Year;
        public string [] LanguageOptions;
        public string [] StreamingPlatforms;
        
    }
    public class ComputerHardware
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double ClockSpeed { get; set; }
        public int Cores { get; set; }
        public string Brand { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Ex. Hardware
            List<ComputerHardware> computerHardware = new List<ComputerHardware>()
        {
            new ComputerHardware() { Name = "Intel Core i7-9700K", Type = "CPU", Price = 400, ClockSpeed = 3.6, Cores = 8, Brand = "Intel" },
            new ComputerHardware() { Name = "AMD Ryzen 9 5950X", Type = "CPU", Price = 700, ClockSpeed = 3.4, Cores = 16, Brand = "AMD" },
            new ComputerHardware() { Name = "NVIDIA GeForce RTX 3080", Type = "GPU", Price = 700, ClockSpeed = 1.7, Cores = 8704, Brand = "NVIDIA" },
            new ComputerHardware() { Name = "AMD Radeon RX 6800 XT", Type = "GPU", Price = 650, ClockSpeed = 2.0, Cores = 72, Brand = "AMD" },
            new ComputerHardware() { Name = "Intel Core i5-10400", Type = "CPU", Price = 200, ClockSpeed = 2.9, Cores = 6, Brand = "Intel" },
            new ComputerHardware() { Name = "AMD Ryzen 5 5600X", Type = "CPU", Price = 300, ClockSpeed = 3.7, Cores = 6, Brand = "AMD" },
            new ComputerHardware() { Name = "NVIDIA GeForce RTX 3060 Ti", Type = "GPU", Price = 400, ClockSpeed = 1.6, Cores = 4864, Brand = "NVIDIA" },
            new ComputerHardware() { Name = "AMD Radeon RX 6700 XT", Type = "GPU", Price = 400, ClockSpeed = 2.4, Cores = 40, Brand = "AMD" },
            new ComputerHardware() { Name = "Intel Core i9-11900K", Type = "CPU", Price = 500, ClockSpeed = 3.2, Cores = 10, Brand = "Intel" },
            new ComputerHardware() { Name = "AMD Ryzen 7 5800X", Type = "CPU", Price = 350, ClockSpeed = 3.9, Cores = 8, Brand = "AMD" },
            new ComputerHardware() { Name = "NVIDIA GeForce RTX 3090", Type = "GPU", Price = 1500, ClockSpeed = 1.4, Cores = 10496, Brand = "NVIDIA" },
            new ComputerHardware() { Name = "AMD Radeon RX 6900 XT", Type = "GPU", Price = 1000, ClockSpeed = 2.0, Cores = 80, Brand = "AMD" },
            new ComputerHardware() { Name = "Intel Core i3-10100", Type = "CPU", Price = 150, ClockSpeed = 3.6, Cores = 4, Brand = "Intel" },
            new ComputerHardware() { Name = "AMD Ryzen 3 5600X", Type = "CPU", Price = 250, ClockSpeed = 3.6, Cores = 6, Brand = "AMD" },
            new ComputerHardware() { Name = "NVIDIA GeForce RTX 3070", Type = "GPU", Price = 500, ClockSpeed = 1.5, Cores = 5888, Brand = "NVIDIA" },
            new ComputerHardware() { Name = "AMD Radeon RX 6700", Type = "GPU", Price = 350, ClockSpeed = 2.3, Cores = 36, Brand = "AMD" },
            new ComputerHardware() { Name = "Intel Core i9-9900K", Type = "CPU", Price = 450, ClockSpeed = 3.2, Cores = 8, Brand = "Intel" },
            new ComputerHardware() { Name = "AMD Ryzen 7 3700X", Type = "CPU", Price = 300, ClockSpeed = 3.6, Cores = 8, Brand = "AMD" },
            new ComputerHardware() { Name = "NVIDIA GeForce RTX 3080 Ti", Type = "GPU", Price = 1200, ClockSpeed = 1.6, Cores = 5888, Brand = "NVIDIA" },
            new ComputerHardware() { Name = "AMD Radeon RX 6800", Type = "GPU", Price = 600, ClockSpeed = 1.8, Cores = 64, Brand = "AMD" }
        };

            // Filtro 1: Piezas que no son "centro de calculs"
            List<ComputerHardware> nonComputeCenterParts = computerHardware
                .Where(h => h.Type != "CPU" && h.Type != "GPU")
                .ToList();

            // Filtro 2: Piezas con un precio mayor a 500
            List<ComputerHardware> expensiveParts = computerHardware
                .Where(h => h.Price > 500)
                .ToList();

            // Filtro 3: CPUs malos para jugar
            List<ComputerHardware> badGamingCPUs = computerHardware
                .Where(h => h.Type == "CPU" && (h.ClockSpeed < 3 || h.Cores < 4))
                .ToList();

            // Filtro 4: Configs potables (GPUs >= 32 núcleos, CPUs >= 8 núcleos)
            List<ComputerHardware> goodConfigs = computerHardware
                .Where(h => (h.Type == "GPU" && h.Cores >= 32) || (h.Type == "CPU" && h.Cores >= 8))
                .ToList();

            // Filtro 5: Configs AMD
            List<ComputerHardware> amdConfigs = computerHardware
                .Where(h => h.Brand == "AMD")
                .ToList();

            // Exportar los resultados a CSV
            ExportToCSV(amdConfigs, "AMDConfigs.csv");

            // Exportar los resultados a Excel
           //ExportToExcel(amdConfigs, "AMDConfigs.xlsx");



            // Ex Cinema
            /*
            List<Movie> frenchMovies = new List<Movie>()
            {
                new Movie() { Title = "Le fabuleux destin d'Amélie Poulain", Genre = "Comédie", Rating = 8.3, Year = 2001, LanguageOptions = new string[] {"Français", "English"}, StreamingPlatforms = new string[] {"Netflix", "Hulu"} },
new Movie() { Title = "Intouchables", Genre = "Comédie", Rating = 8.5, Year = 2011, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix", "Amazon"} },
new Movie() { Title = "The Matrix", Genre = "Science-Fiction", Rating = 8.7, Year = 1999, LanguageOptions = new string[] {"English", "Español"}, StreamingPlatforms = new string[] {"Hulu", "Amazon"} },
new Movie() { Title = "La Vie est belle", Genre = "Drame", Rating = 8.6, Year = 1946, LanguageOptions = new string[] {"Français", "Italiano"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Gran Torino", Genre = "Drame", Rating = 8.2, Year = 2008, LanguageOptions = new string[] {"English"}, StreamingPlatforms = new string[] {"Hulu"} },
new Movie() { Title = "La Haine", Genre = "Drame", Rating = 8.1, Year = 1995, LanguageOptions = new string[] {"Français"}, StreamingPlatforms = new string[] {"Netflix"} },
new Movie() { Title = "Oldboy", Genre = "Thriller", Rating = 8.4, Year = 2003, LanguageOptions = new string[] {"Coréen", "English"}, StreamingPlatforms = new string[] {"Amazon"} }
            };

            //Ex1
            Console.WriteLine("Movies non Comédie ni Drama : ");
            frenchMovies
                .Where(m => m.Genre != "Comédie" && m.Genre != "Drame")
                .ToList()
                .ForEach(m=>Console.WriteLine(m.Title));


            //Ex2
            Console.WriteLine("Movies Rating > 7");
            frenchMovies
                .Where(m => m.Rating > 7).ToList().ForEach(m=>Console.WriteLine(m.Title));
            

            //Ex3
            Console.WriteLine("Movie Year > 2000");
            frenchMovies
                .Where(m=>m.Year>2000).ToList().ForEach(m=>Console.WriteLine(m.Title));

            //Ex4
            Console.WriteLine("No language Français");
            frenchMovies.Where(m => !m.LanguageOptions.Contains("Français"))
                .ToList()
                .ForEach(m => Console.WriteLine(m.Title));

            //Ex5
            Console.WriteLine("No Netflix ");

            frenchMovies.Where(m => !m.StreamingPlatforms.Contains("Netflix")).ToList().ForEach(m => Console.WriteLine(m.Title));
            

            */
            /* Ex Dictionnaire
            List<string> frenchWords = new List<string>() {
                "Merci", "Hotdog", "Oui", "Non", "Désolé", "Réunion", "Manger", "Boire", "Téléphone", "Ordinateur",
            "Internet", "Email", "Sandwich", "Hello", "Taxi", "Hotel", "Gare", "Train", "Bus", "Métro", "Tramway",
            "Vélo", "Voiture", "Piéton", "Feu rouge", "Cédez", "Ralentir", "gauche", "droite", "Continuer", "Sandwich",
            "Retourner", "Arrêter", "Stationnement", "Parking", "Interdit", "Péage", "Trafic", "Route", "Rond-point",
            "Football", "Carrefour", "Feu", "Panneau", "Vitesse", "Tramway", "Aéroport", "Héliport", "Port", "Ferry",
            "Bateau", "Canot", "Kayak", "Paddle", "Surf", "Plage", "Mer", "Océan", "Rivière", "Lac", "Étang", "Marais",
            "Forêt", "Hello", "Montagne", "Vallée", "Plaine", "Désert", "Jungle", "Savane", "Volleyball", "Tundra",
            "Glacier", "Neige", "Pluie", "Soleil", "Nuage", "Vent", "Tempête", "Ouragan", "Tornade", "Séisme", 
            "Tsunami", "Volcan", "Éruption", "Ciel"
            };

            List<string> englishWords = new List<string>()
            {
                "Thank you", "Hotdog", "Yes", "No", "Sorry", "Meeting", "Eat", "Drink", "Phone", "Computer",
    "Internet", "Email", "Sandwich", "Hello", "Taxi", "Hotel", "Train station", "Train", "Bus", "Subway", "Tramway",
    "Bicycle", "Car", "Pedestrian", "Traffic light", "Yield", "Slow down", "Left", "Right", "Continue", "Sandwich",
    "Go back", "Stop", "Parking", "Parking lot", "Forbidden", "Toll", "Traffic", "Road", "Roundabout",
    "Football", "Intersection", "Light", "Sign", "Speed", "Tramway", "Airport", "Heliport", "Port", "Ferry",
    "Boat", "Canoe", "Kayak", "Paddle", "Surf", "Beach", "Sea", "Ocean", "River", "Lake", "Pond", "Marsh",
    "Forest", "Hello", "Mountain", "Valley", "Plain", "Desert", "Jungle", "Savanna", "Volleyball", "Tundra",
    "Glacier", "Snow", "Rain", "Sun", "Cloud", "Wind", "Storm", "Hurricane", "Tornado", "Earthquake",
    "Tsunami", "Volcano", "Eruption", "Sky"
            };

            var commonWords = frenchWords
                .Where(word => englishWords.Contains(word, StringComparer.OrdinalIgnoreCase)).ToList();
            Console.WriteLine("English and Frensh similar words : ");
            commonWords.ForEach(Console.WriteLine);

            //Solution GPT
            List<string> commonWords = frenchWords
    .Where(frenchWord => englishWords.Contains(frenchWord))
    .ToList();

// Mostrar las palabras comunes
commonWords.ForEach(word => Console.WriteLine(word));

            */
            /* EX EPSILON
            Dictionary<char, double> letterFrequencies = new Dictionary<char, double>
            {
                { 'A', 8.15 }, { 'B', 0.97 }, { 'C', 3.15 }, { 'D', 3.55 }, { 'E', 17.40 },
                { 'F', 1.05 }, { 'G', 1.30 }, { 'H', 1.20 }, { 'I', 7.35 }, { 'J', 0.61 },
                { 'K', 0.05 }, { 'L', 5.49 }, { 'M', 2.96 }, { 'N', 7.10 }, { 'O', 5.27 },
                { 'P', 3.02 }, { 'Q', 0.99 }, { 'R', 6.55 }, { 'S', 7.75 }, { 'T', 6.95 },
                { 'U', 6.35 }, { 'V', 1.02 }, { 'W', 0.04 }, { 'X', 0.45 }, { 'Y', 0.30 },
                { 'Z', 0.15 }
            };


            //Exemple
            List<string> words = new List<string> { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

            List<(string Word, double Epsilon)> filteredWords = words
              .Select(word => (Word: word, Epsilon: CalculateEpsilon(word.ToUpper(), letterFrequencies)))
              .Where(result => result.Epsilon >= 0.5 && result.Epsilon <= 0.95)
              .ToList();

            filteredWords.ForEach(result =>
                Console.WriteLine($"{result.Word} - Epsilon: {result.Epsilon}")
            );



        }

        static double CalculateEpsilon(string word, Dictionary<char, double> letterFrequencies)
        {
            return word
                .GroupBy(letter => letter)
                .Sum(group => (letterFrequencies.ContainsKey(group.Key) ? letterFrequencies[group.Key] : 0.0) / 100 / group.Count());
        }
            */
        }

        public static void ExportToCSV(List<ComputerHardware> hardwareList, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Name,Type,Price,ClockSpeed,Cores,Brand");
                foreach (ComputerHardware hardware in hardwareList)
                {
                    writer.WriteLine($"{hardware.Name},{hardware.Type},{hardware.Price},{hardware.ClockSpeed},{hardware.Cores},{hardware.Brand}");
                }
            }
        }

        // Método para exportar a Excel
        public static void ExportToExcel(List<ComputerHardware> hardwareList, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Hardware");
                worksheet.Cells[1, 1].Value = "Name";
                worksheet.Cells[1, 2].Value = "Type";
                worksheet.Cells[1, 3].Value = "Price";
                worksheet.Cells[1, 4].Value = "ClockSpeed";
                worksheet.Cells[1, 5].Value = "Cores";
                worksheet.Cells[1, 6].Value = "Brand";

                int row = 2;
                foreach (ComputerHardware hardware in hardwareList)
                {
                    worksheet.Cells[row, 1].Value = hardware.Name;
                    worksheet.Cells[row, 2].Value = hardware.Type;
                    worksheet.Cells[row, 3].Value = hardware.Price;
                    worksheet.Cells[row, 4].Value = hardware.ClockSpeed;
                    worksheet.Cells[row, 5].Value = hardware.Cores;
                    worksheet.Cells[row, 6].Value = hardware.Brand;
                    row++;
                }

                FileInfo file = new FileInfo(filePath);
                package.SaveAs(file);
            }
        }

    }
}
