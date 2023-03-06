namespace CargoOrderCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstBrandName = "Adidas";
            int countOfShoesFromFirstBrand = 4;
            decimal priceOfShoesFromFirstBrand = 200;
            decimal totalPriceFromFirstBrand = countOfShoesFromFirstBrand * priceOfShoesFromFirstBrand;

            string secondBrandName = "Gucci";
            int countOfShoesFromSecondBrand = 2;
            decimal priceOfShoesFromSecondBrand = 1000;
            decimal totalPriceFromSecondBrand = countOfShoesFromSecondBrand * priceOfShoesFromSecondBrand;

            string thirdBrandName = "Nike";
            int countOfShoesFromThirdBrand = 1;
            decimal priceOfShoesFromThirdBrand = 150;
            decimal totalPriceFromThirdBrand = countOfShoesFromThirdBrand * priceOfShoesFromThirdBrand;

            decimal totalPrice = totalPriceFromFirstBrand + totalPriceFromSecondBrand + totalPriceFromThirdBrand;

            Console.WriteLine("Firma : " + firstBrandName);
            Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromFirstBrand);
            Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromFirstBrand);
            Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromFirstBrand);

            Console.WriteLine();
            Console.WriteLine("Firma : " + secondBrandName);
            Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromSecondBrand);
            Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromSecondBrand);
            Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromSecondBrand);

            Console.WriteLine();
            Console.WriteLine("Firma : " + thirdBrandName);
            Console.WriteLine("Ayaqqabı sayı : " + countOfShoesFromThirdBrand);
            Console.WriteLine("Birinin qiyməti ($) : " + priceOfShoesFromThirdBrand);
            Console.WriteLine("Hamısının birlikdə qiyməti ($) : " + totalPriceFromThirdBrand);

            Console.WriteLine();
            Console.WriteLine("Total :" + totalPrice);
        }
    }
}