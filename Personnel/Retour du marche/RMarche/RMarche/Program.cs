using System;
using System.Linq;

namespace RMarche
{
    internal class Program
    {

        public class Product
        {
            public int Location { get; set; }
            public string Producer { get; set; }
            public string ProductName { get; set; }
            public int Quantity { get; set; }
            public string Unit { get; set; }
            public double PricePerUnit { get; set; }
        }

        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
{
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Groseilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pêches", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Haricots", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Courges", Quantity = 18,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 3, Producer = "Vonlanthen", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Pastèques", Quantity = 6,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Melons", Quantity = 14,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 4, Producer = "Barizzi", ProductName = "Raisin", Quantity = 15,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Pruneaux", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Myrtilles", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Groseilles", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Pêches", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 5, Producer = "Blanc", ProductName = "Haricots", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Courges", Quantity = 12,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Pommes", Quantity = 15,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Poires", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 6, Producer = "Repond", ProductName = "Pastèques", Quantity = 7,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Pêches", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Haricots", Quantity = 11,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Courges", Quantity = 10,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Tomates", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 7, Producer = "Mancini", ProductName = "Pommes", Quantity = 14,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Pastèques", Quantity = 5,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Haricots", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Courges", Quantity = 17,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 8, Producer = "Favre", ProductName = "Tomates", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Pommes", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Poires", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Pastèques", Quantity = 20,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Melons", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 9, Producer = "Bovay", ProductName = "Noix", Quantity = 13,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Raisin", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Pruneaux", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Myrtilles", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Groseilles", Quantity = 10,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 10, Producer = "Cherix", ProductName = "Pêches", Quantity = 9,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Haricots", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Courges", Quantity = 16,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Tomates", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Pommes", Quantity = 8,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 11, Producer = "Beaud", ProductName = "Poires", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Pastèques", Quantity = 15,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Melons", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Noix", Quantity = 11,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Raisin", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 12, Producer = "Corbaz", ProductName = "Pruneaux", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Myrtilles", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Groseilles", Quantity = 19,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Pêches", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Haricots", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 13, Producer = "Amaudruz", ProductName = "Courges", Quantity = 7,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Tomates", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pommes", Quantity = 17,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Poires", Quantity = 7,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Pastèques", Quantity = 11,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 14, Producer = "Bühlmann", ProductName = "Melons", Quantity = 7,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Noix", Quantity = 10,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Raisin", Quantity = 17,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Pruneaux", Quantity = 18,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 15, Producer = "Crizzi", ProductName = "Groseilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 }
};

            var productsDic = new Dictionary<string, string>()

            {
                { "Pommes","Apples"},
                { "Poires","Pears"},
                { "Pastèques","Watermelons"},
                { "Melons","Melons"},
                { "Noix","Nuts"},
                { "Raisin","Grapes"},
                { "Pruneaux","Plums"},
                { "Myrtilles","Blueberries"},
                { "Groseilles","Berries"},
                { "Tomates","Tomatoes"},
                { "Courges","Pumpkins"},
                { "Pêches","Peaches"},
                { "Haricots","Beans"}
            };
            //Transformer

            List<Tuple<string, string, double>> transformedProducts = products
          .Select(p => new Tuple<string, string, double>(
              p.Producer.Substring(0, 3) + "..." + p.Producer.Last(),
              productsDic[p.ProductName],
              p.Quantity * p.PricePerUnit
          ))
          .ToList();


            Console.WriteLine("Seller\tProduct\tCA");
            for (int i = 0; i < transformedProducts.Count; i++)
            {
                Tuple<string, string, double> item = transformedProducts[i];
                Console.WriteLine(item.Item1 + "\t" + item.Item2 + "\t" + item.Item3);
            }

            // Livrable 2: Exportar a un archivo CSV sin foreach
            using (StreamWriter writer = new StreamWriter("products.csv"))
            {
                writer.WriteLine("Seller,Product,CA");
                for (int i = 0; i < transformedProducts.Count; i++)
                {
                    Tuple<string, string, double> item = transformedProducts[i];
                    writer.WriteLine(item.Item1 + "," + item.Item2 + "," + item.Item3);
                }
            }
// Continuando desde el código anterior...

            // Cantidad de groseilles disponibles
int groseillesQuantity = products
    .Where(p => p.ProductName == "Groseilles")
    .Sum(p => p.Quantity);
            Console.WriteLine("Cantidad de groseilles: " + groseillesQuantity + " kg");

            // Chiffre d’affaire total por productor
            List<Tuple<string, double>> totalCAByProducer = products
                .GroupBy(p => p.Producer)
                .Select(g => new Tuple<string, double>(
                    g.Key,
                    g.Sum(p => p.Quantity * p.PricePerUnit)
                ))
                .ToList();

            // Chiffre d’affaire más grande, más pequeño y la media
            double maxCA = totalCAByProducer.Max(p => p.Item2);
            double minCA = totalCAByProducer.Min(p => p.Item2);
            double avgCA = totalCAByProducer.Average(p => p.Item2);

            Console.WriteLine("CA más grande: " + maxCA);
            Console.WriteLine("CA más pequeño: " + minCA);
            Console.WriteLine("CA promedio: " + avgCA);

            // Productor con más noix
            Product maxNoixProducer = products
                .Where(p => p.ProductName == "Noix")
                .OrderByDescending(p => p.Quantity)
                .FirstOrDefault();
            Console.WriteLine("El productor con más noix: " + (maxNoixProducer != null ? maxNoixProducer.Producer : "Ninguno"));

            // Productor con más afinidad con sus productos
            List<Tuple<string, string, int>> affinities = products
                .Select(p => new Tuple<string, string, int>(
                    p.Producer,
                    p.ProductName,
                    Affinity(p.Producer, p.ProductName)
                ))
                .OrderByDescending(a => a.Item3)
                .ToList();

            Tuple<string, string, int> maxAffinityProducer = affinities.Count > 0 ? affinities[0] : null;
            Console.WriteLine("El productor con más afinidad: " + (maxAffinityProducer != null ? maxAffinityProducer.Item1 : "Ninguno"));

            // Función de afinidad
            static int Affinity(string name, string product)
            {
                return name.GroupBy(letter => letter)
                           .Union(product.GroupBy(letter => letter))
                           .Sum(group => group.Count());
            }


            /*
            IEnumerable<(string produc, string Product, double CA)> transformedProducts = Product.Select(p => (
               produc: $"{p.Producer.Substring(0, 3)}...{p.Producer.Last()}",
               Product: i18n[p.ProductName],
               CA: p.Quantity * p.PricePerUnit
           ));
            foreach (var item in transformedProducts)
            {
                Console.WriteLine($"{item.produc}\t{item.Product}\t{item.CA}");
            }
            */




            /*
            List<Product> result = products.Select(p => new p
            {
                Seller = p.Producer.Substring(0, 3) + "..." + p.Producer.Last(),
                Product = productsDic.ContainsKey(p.ProductName) ? productsDic[p.ProductName] : p.ProductName,
                CA = p.Quantity * p.PricePerUnit
            }).ToList();

            // Output to console
            Console.WriteLine("Seller\tProduct\tCA");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Seller}\t{item.Product}\t{item.CA}");
            }*/

        }

    }
}
