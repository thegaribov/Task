namespace CargoOrderCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter brand count : ");
            int brandCount = int.Parse(Console.ReadLine());
            decimal total = 0;

            while (brandCount >= 1)
            {
                Console.Write("Brand name : ");
                string brandName = Console.ReadLine();

                Console.Write("Count of shoes : ");
                int countOfShoesFromBrand = int.Parse(Console.ReadLine());

                Console.Write("Price of shoes : ");
                decimal priceOfShoesFromBrand = decimal.Parse(Console.ReadLine());
                decimal totalPriceFromBrand = countOfShoesFromBrand * priceOfShoesFromBrand;
                total = total + totalPriceFromBrand;

                Console.WriteLine();
                Console.WriteLine("Firma : " + brandName);
                Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromBrand);
                Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromBrand);
                Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromBrand);
                Console.WriteLine("############################################################################");

                //brandCount = brandCount - 1;
                brandCount -= 1;
            }

            Console.WriteLine();
            Console.WriteLine("Yekun");
            Console.WriteLine(total);

            //Console.Write("Brand name : ");
            //string firstBrandName = Console.ReadLine();

            //Console.Write("Count of shoes : ");
            //int countOfShoesFromFirstBrand = int.Parse(Console.ReadLine());

            //Console.Write("Price of shoes : ");
            //decimal priceOfShoesFromFirstBrand = decimal.Parse(Console.ReadLine());
            //decimal totalPriceFromFirstBrand = countOfShoesFromFirstBrand * priceOfShoesFromFirstBrand;

            //Console.Write("Brand name : ");
            //string secondBrandName = Console.ReadLine();

            //Console.Write("Count of shoes : ");
            //int countOfShoesFromSecondBrand = int.Parse(Console.ReadLine());

            //Console.Write("Price of shoes : ");
            //decimal priceOfShoesFromSecondBrand = decimal.Parse(Console.ReadLine());
            //decimal totalPriceFromSecondBrand = countOfShoesFromSecondBrand * priceOfShoesFromSecondBrand;


            //Console.Write("Brand name : ");
            //string thirdBrandName = Console.ReadLine();

            //Console.Write("Count of shoes : ");
            //int countOfShoesFromThirdBrand = int.Parse(Console.ReadLine());

            //Console.Write("Price of shoes : ");
            //decimal priceOfShoesFromThirdBrand = decimal.Parse(Console.ReadLine());
            //decimal totalPriceFromThirdBrand = countOfShoesFromThirdBrand * priceOfShoesFromThirdBrand;

            //decimal totalPrice = totalPriceFromFirstBrand + totalPriceFromSecondBrand + totalPriceFromThirdBrand;

            //Console.WriteLine();

            //Console.WriteLine("Firma : " + firstBrandName);
            //Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromFirstBrand);
            //Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromFirstBrand);
            //Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromFirstBrand);

            //Console.WriteLine();
            //Console.WriteLine("Firma : " + secondBrandName);
            //Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromSecondBrand);
            //Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromSecondBrand);
            //Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromSecondBrand);

            //Console.WriteLine();
            //Console.WriteLine("Firma : " + thirdBrandName);
            //Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromThirdBrand);
            //Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromThirdBrand);
            //Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromThirdBrand);

            //Console.WriteLine();
            //Console.WriteLine("Total :" + totalPrice);
        }
    }
}