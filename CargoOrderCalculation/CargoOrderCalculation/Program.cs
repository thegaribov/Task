namespace CargoOrderCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter brand count : ");
            int brandCount = int.Parse(Console.ReadLine());

            decimal discountPercentage = 20;
            decimal discountStartNumber = 5;

            string[] brandNames = new string[brandCount];
            decimal[] shoesPrices = new decimal[brandCount];
            int[] shoesCounts = new int[brandCount];
            decimal[] shoesTotalPrices = new decimal[brandCount];
            decimal[] shoesTotalPricesWithDiscount = new decimal[brandCount];

            int index = 0;

            while (index < brandCount)
            {
                Console.Write("Brand name : ");
                brandNames[index] = Console.ReadLine();

                Console.Write("Count of shoes : ");
                shoesCounts[index] = int.Parse(Console.ReadLine());

                Console.Write("Price of shoes : ");
                shoesPrices[index] = decimal.Parse(Console.ReadLine());

                shoesTotalPrices[index] = shoesCounts[index] * shoesPrices[index];
                shoesTotalPricesWithDiscount[index] = shoesTotalPrices[index];

                if (shoesCounts[index] > discountStartNumber)
                {
                    shoesTotalPricesWithDiscount[index] =
                        shoesTotalPricesWithDiscount[index] - shoesTotalPricesWithDiscount[index] * discountPercentage / 100;
                }

                index++;
            }

            index = 0;

            while (index < brandCount)
            {
                Console.WriteLine();
                Console.WriteLine($"Firma : {brandNames[index]}"); //string interpolation
                Console.WriteLine($"Ayaqqabı sayı : {shoesCounts[index]}");
                Console.WriteLine($"Birinin qiyməti ($) : {shoesPrices[index]}");
                Console.WriteLine($"Hamısının birlikdə qiyməti ($) : {shoesTotalPrices[index]}");
                Console.WriteLine($"Hamısının birlikdə qiyməti (endirimli) ($) : {shoesTotalPricesWithDiscount[index]}");

                index++;
            }


            //Console.WriteLine();
            //Console.WriteLine($"Yekun : {total}");

            //if (total != totalWithDiscount)
            //    Console.WriteLine($"(Yekun) Endirimli : {totalWithDiscount}");
        }
    }
}