namespace CountryBudgetCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal countryBudget = 20_000_000_000;
            decimal percentageOfMod = 20; //MOD - Ministry of Defence
            decimal percentageOfmoht = 20; //MOHT - Ministry of high tech

            decimal budgetOfMod = countryBudget * percentageOfMod / 100;
            decimal budgetOfMoht = countryBudget * percentageOfmoht / 100;

            Console.WriteLine("Büdcə :");
            Console.WriteLine(countryBudget);

            Console.WriteLine("Müdafiə Nazirliyinə :");
            Console.WriteLine(budgetOfMod);

            Console.WriteLine("Yüksek Texnologiyalar Nazirliyinə :");
            Console.WriteLine(budgetOfMoht);

            Console.WriteLine("Remaining country budget :");
            Console.WriteLine(countryBudget - budgetOfMod - budgetOfMoht);
        }
    }
}