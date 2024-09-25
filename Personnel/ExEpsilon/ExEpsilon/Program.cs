using System.Diagnostics.Tracing;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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


    class Program
    {
        static void Main(string[] args)
        {

            // Ex Cinema
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
    }
}
