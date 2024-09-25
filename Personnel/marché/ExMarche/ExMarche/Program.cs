using System;
using System.Linq;
class Program
{
    public class ProductData
    {
        public int Block { get; set; }
        public string Producer { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }

    }

    string answ1 = "Il y a {} vendeurs de {}";
    string answ2 = "C'est {} qui a le plus de pastèques (stand {}, {} pièces)";

    static void Main()
    {
        List<ProductData> dataList = new List<ProductData>
        {
            new ProductData { Block = 1, Producer = "Bornand", Product = "Apples", Quantity = 20, Unit = "kg", Price = 6.90 },
            new ProductData { Block = 1, Producer = "Bornand", Product = "Pears", Quantity = 16, Unit = "kg", Price = 3.50 },
            new ProductData { Block = 1, Producer = "Bornand", Product = "Watermelons", Quantity = 14, Unit = "piece", Price = 6.00 },
            new ProductData { Block = 1, Producer = "Bornand", Product = "Melons", Quantity = 5, Unit = "kg", Price = 7.00 },
            new ProductData { Block = 2, Producer = "Dumont", Product = "Walnuts", Quantity = 20, Unit = "bag", Price = 8.60 },
            new ProductData { Block = 2, Producer = "Dumont", Product = "Grapes", Quantity = 6, Unit = "kg", Price = 5.60 },
            new ProductData { Block = 2, Producer = "Dumont", Product = "Prunes", Quantity = 13, Unit = "kg", Price = 8.10 },
            new ProductData { Block = 2, Producer = "Dumont", Product = "Blueberries", Quantity = 12, Unit = "kg", Price = 8.90 },
            new ProductData { Block = 2, Producer = "Dumont", Product = "Red Currants", Quantity = 12, Unit = "kg", Price = 5.20 },
            new ProductData { Block = 3, Producer = "Vonlanthen", Product = "Peaches", Quantity = 8, Unit = "kg", Price = 8.70 },
            new ProductData { Block = 3, Producer = "Vonlanthen", Product = "Beans", Quantity = 6, Unit = "kg", Price = 6.90 },
            new ProductData { Block = 3, Producer = "Vonlanthen", Product = "Squashes", Quantity = 18, Unit = "piece", Price = 4.30 },
            new ProductData { Block = 3, Producer = "Vonlanthen", Product = "Tomatoes", Quantity = 12, Unit = "kg", Price = 9.40 },
            new ProductData { Block = 3, Producer = "Vonlanthen", Product = "Apples", Quantity = 20, Unit = "kg", Price = 3.90 },
            new ProductData { Block = 4, Producer = "Barizzi", Product = "Pears", Quantity = 5, Unit = "kg", Price = 6.30 },
            new ProductData { Block = 4, Producer = "Barizzi", Product = "Watermelons", Quantity = 6, Unit = "piece", Price = 2.50 },
            new ProductData { Block = 4, Producer = "Barizzi", Product = "Melons", Quantity = 14, Unit = "kg", Price = 4.20 },
            new ProductData { Block = 4, Producer = "Barizzi", Product = "Walnuts", Quantity = 20, Unit = "bag", Price = 7.50 },
            new ProductData { Block = 4, Producer = "Barizzi", Product = "Grapes", Quantity = 15, Unit = "kg", Price = 7.20 },
            new ProductData { Block = 5, Producer = "Blanc", Product = "Prunes", Quantity = 5, Unit = "kg", Price = 9.00 },
            new ProductData { Block = 5, Producer = "Blanc", Product = "Blueberries", Quantity = 18, Unit = "kg", Price = 5.60 },
            new ProductData { Block = 5, Producer = "Blanc", Product = "Red Currants", Quantity = 10, Unit = "kg", Price = 2.10 },
            new ProductData { Block = 5, Producer = "Blanc", Product = "Peaches", Quantity = 20, Unit = "kg", Price = 6.40 },
            new ProductData { Block = 5, Producer = "Blanc", Product = "Beans", Quantity = 9, Unit = "kg", Price = 2.90 },
            new ProductData { Block = 6, Producer = "Repond", Product = "Squashes", Quantity = 12, Unit = "piece", Price = 7.40 },
            new ProductData { Block = 6, Producer = "Repond", Product = "Tomatoes", Quantity = 12, Unit = "kg", Price = 4.20 },
            new ProductData { Block = 6, Producer = "Repond", Product = "Apples", Quantity = 15, Unit = "kg", Price = 6.50 },
            new ProductData { Block = 6, Producer = "Repond", Product = "Pears", Quantity = 18, Unit = "kg", Price = 2.40 },
            new ProductData { Block = 6, Producer = "Repond", Product = "Watermelons", Quantity = 7, Unit = "piece", Price = 5.70 },
            new ProductData { Block = 7, Producer = "Mancini", Product = "Peaches", Quantity = 10, Unit = "kg", Price = 2.90 },
            new ProductData { Block = 7, Producer = "Mancini", Product = "Beans", Quantity = 11, Unit = "kg", Price = 6.70 },
            new ProductData { Block = 7, Producer = "Mancini", Product = "Squashes", Quantity = 10, Unit = "piece", Price = 6.40 },
            new ProductData { Block = 7, Producer = "Mancini", Product = "Tomatoes", Quantity = 13, Unit = "kg", Price = 1.50 },
            new ProductData { Block = 7, Producer = "Mancini", Product = "Apples", Quantity = 14, Unit = "kg", Price = 7.00 },
            new ProductData { Block = 8, Producer = "Favre", Product = "Pears", Quantity = 5, Unit = "kg", Price = 8.40 },
            new ProductData { Block = 8, Producer = "Favre", Product = "Watermelons", Quantity = 5, Unit = "piece", Price = 1.70 },
            new ProductData { Block = 8, Producer = "Favre", Product = "Beans", Quantity = 5, Unit = "kg", Price = 3.00 },
            new ProductData { Block = 8, Producer = "Favre", Product = "Squashes", Quantity = 17, Unit = "piece", Price = 2.00 },
            new ProductData { Block = 8, Producer = "Favre", Product = "Tomatoes", Quantity = 9, Unit = "kg", Price = 5.20 },
            new ProductData { Block = 9, Producer = "Bovay", Product = "Apples", Quantity = 13, Unit = "kg", Price = 7.70 },
            new ProductData { Block = 9, Producer = "Bovay", Product = "Pears", Quantity = 5, Unit = "kg", Price = 3.80 },
            new ProductData { Block = 9, Producer = "Bovay", Product = "Watermelons", Quantity = 20, Unit = "piece", Price = 2.10 },
            new ProductData { Block = 9, Producer = "Bovay", Product = "Melons", Quantity = 20, Unit = "kg", Price = 6.40 },
            new ProductData { Block = 9, Producer = "Bovay", Product = "Walnuts", Quantity = 13, Unit = "bag", Price = 8.80 },
            new ProductData { Block = 10, Producer = "Cherix", Product = "Grapes", Quantity = 8, Unit = "kg", Price = 7.10 },
            new ProductData { Block = 10, Producer = "Cherix", Product = "Prunes", Quantity = 19, Unit = "kg", Price = 7.90 },
            new ProductData { Block = 10, Producer = "Cherix", Product = "Blueberries", Quantity = 9, Unit = "kg", Price = 4.20 },
            new ProductData { Block = 10, Producer = "Cherix", Product = "Red Currants", Quantity = 10, Unit = "kg", Price = 4.40 },
            new ProductData { Block = 10, Producer = "Cherix", Product = "Peaches", Quantity = 9, Unit = "kg", Price = 4.40 },
            new ProductData { Block = 11, Producer = "Beaud", Product = "Beans", Quantity = 19, Unit = "kg", Price = 8.40 },
            new ProductData { Block = 11, Producer = "Beaud", Product = "Squashes", Quantity = 16, Unit = "piece", Price = 8.70 },
            new ProductData { Block = 11, Producer = "Beaud", Product = "Tomatoes", Quantity = 18, Unit = "kg", Price = 5.30 },
            new ProductData { Block = 11, Producer = "Beaud", Product = "Apples", Quantity = 8, Unit = "kg", Price = 7.30 },
            new ProductData { Block = 11, Producer = "Beaud", Product = "Pears", Quantity = 13, Unit = "kg", Price = 9.20 },
            new ProductData { Block = 12, Producer = "Corbaz", Product = "Watermelons", Quantity = 15, Unit = "piece", Price = 7.40 },
            new ProductData { Block = 12, Producer = "Corbaz", Product = "Melons", Quantity = 12, Unit = "kg", Price = 1.60 },
            new ProductData { Block = 12, Producer = "Corbaz", Product = "Walnuts", Quantity = 11, Unit = "bag", Price = 7.50 },
            new ProductData { Block = 12, Producer = "Corbaz", Product = "Grapes", Quantity = 16, Unit = "kg", Price = 4.50 },
            new ProductData { Block = 12, Producer = "Corbaz", Product = "Prunes", Quantity = 20, Unit = "kg", Price = 3.30 },
            new ProductData { Block = 13, Producer = "Amaudruz", Product = "Blueberries", Quantity = 18, Unit = "kg", Price = 5.70 },
            new ProductData { Block = 13, Producer = "Amaudruz", Product = "Red Currants", Quantity = 19, Unit = "kg", Price = 8.00 },
            new ProductData { Block = 13, Producer = "Amaudruz", Product = "Peaches", Quantity = 12, Unit = "kg", Price = 5.50 },
            new ProductData { Block = 13, Producer = "Amaudruz", Product = "Beans", Quantity = 13, Unit = "kg", Price = 5.20 },
            new ProductData { Block = 13, Producer = "Amaudruz", Product = "Squashes", Quantity = 7, Unit = "piece", Price = 9.60 },
            new ProductData { Block = 14, Producer = "Bühlmann", Product = "Tomatoes", Quantity = 12, Unit = "kg", Price = 7.70 },
            new ProductData { Block = 14, Producer = "Bühlmann", Product = "Apples", Quantity = 17, Unit = "kg", Price = 1.90 },
            new ProductData { Block = 14, Producer = "Bühlmann", Product = "Pears", Quantity = 7, Unit = "kg", Price = 3.00 },
            new ProductData { Block = 14, Producer = "Bühlmann", Product = "Watermelons", Quantity = 11, Unit = "piece", Price = 6.90 },
            new ProductData { Block = 14, Producer = "Bühlmann", Product = "Melons", Quantity = 7, Unit = "kg", Price = 4.70 },
            new ProductData { Block = 15, Producer = "Crizzi", Product = "Walnuts", Quantity = 10, Unit = "bag", Price = 1.60 },
            new ProductData { Block = 15, Producer = "Crizzi", Product = "Grapes", Quantity = 17, Unit = "kg", Price = 7.80 },
            new ProductData { Block = 15, Producer = "Crizzi", Product = "Prunes", Quantity = 18, Unit = "kg", Price = 9.00 },
            new ProductData { Block = 15, Producer = "Crizzi", Product = "Blueberries", Quantity = 12, Unit = "kg", Price = 3.00 },
            new ProductData { Block = 15, Producer = "Crizzi", Product = "Red Currants", Quantity = 12, Unit = "kg", Price = 3.50 },
        };

        

        Console.WriteLine("Combien y a-t-il de vendeurs de pêche dans ce marché ?");

        //int count = 0;
        //Exemple 2
        int maxQuantity = 0;
        ProductData maxProduct = null;

        int count2 = (from pd in dataList
                      where pd.Product == "Peaches"
                      select pd).Count();

        ProductData maxProd = (from dl in dataList
                               where dl.Product == "Peaches"
                               orderby dl.Quantity descending
                               select dl).FirstOrDefault();
                    
        //Exemple 1
        /*
        for (int i = 0; i< dataList.Count; i++)
        {
            if (dataList[i].Product == "Peaches")
            {
                count++;

                if (dataList[i].Quantity > maxQuantity)
                {
                    maxQuantity = dataList[i].Quantity;
                    maxProduct = dataList[i];
                }
            }
        }
        */

        Console.WriteLine($"Il y a {count2} vendeurs de pêches");

        //Preunta 2 
        Console.WriteLine("Quel producteur a le plus de pastèques à vendre ? Où est-il ? Combien en a-t-il ?");


        //Respuesta 

        Console.WriteLine($"C'est {maxProd.Producer} qui a le plus de pastèques (stand {maxProd.Block}, {maxProd.Quantity} pièces)");



    }
}