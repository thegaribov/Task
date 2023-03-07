namespace CargoOrderCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pls enter brand count : ");
            int brandCount = int.Parse(Console.ReadLine());
            decimal total = 0;
            decimal totalWithDiscount = 0;
            decimal discountPercentage = 20;
            decimal discountStartNumber = 5;

            while (brandCount >= 1)
            {
                string brandName = "";

                while (true)
                {
                    Console.Write("Brand name : ");
                    brandName = Console.ReadLine();

                    if (brandName.Length > 5 && brandName.Length < 10)
                    {
                        break;
                    }
                }



                Console.Write("Count of shoes : ");
                int countOfShoesFromBrand = int.Parse(Console.ReadLine());

                Console.Write("Price of shoes : ");
                decimal priceOfShoesFromBrand = decimal.Parse(Console.ReadLine());
                decimal totalPriceFromBrand = countOfShoesFromBrand * priceOfShoesFromBrand;
                decimal totalPriceFromBrandWithDiscount = totalPriceFromBrand;

                Console.WriteLine();
                Console.WriteLine($"Firma : {brandName}"); //string interpolation
                Console.WriteLine($"Ayaqqabı sayı : {countOfShoesFromBrand}");
                Console.WriteLine($"Birinin qiyməti ($) : {priceOfShoesFromBrand}");
                Console.WriteLine($"Hamısının birlikdə qiyməti ($) : {totalPriceFromBrand}");
                if (countOfShoesFromBrand > discountStartNumber)
                {
                    totalPriceFromBrandWithDiscount = totalPriceFromBrandWithDiscount - totalPriceFromBrandWithDiscount * discountPercentage / 100;
                    Console.WriteLine($"Hamısının birlikdə endirimli qiyməti ($) : {totalPriceFromBrandWithDiscount}");
                }

                Console.WriteLine("############################################################################");

                total = total + totalPriceFromBrand;
                totalWithDiscount = totalWithDiscount + totalPriceFromBrandWithDiscount;
                brandCount -= 1;
            }

            Console.WriteLine();
            Console.WriteLine($"Yekun : {total}");

            if (total != totalWithDiscount)
                Console.WriteLine($"(Yekun) Endirimli : {totalWithDiscount}");



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