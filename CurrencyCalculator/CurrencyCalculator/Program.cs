namespace CurrencyCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            decimal amountInAzn = 10_000;

            decimal usdRate = 1.7M;
            decimal euroRate = 1.8092M;
            decimal rubRate = 0.0225M;

            Console.WriteLine("Mebleg (AZN) : " + amountInAzn);
            Console.WriteLine();
            Console.WriteLine("ABŞ dolları (USD) : " + amountInAzn / usdRate);
            Console.WriteLine("Avro (EUR) : " + amountInAzn / euroRate);
            Console.WriteLine("Rusiya rublu (RUB) : " + amountInAzn / rubRate);
        }
    }
}