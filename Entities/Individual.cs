
namespace ExFinal.Entities
{
    internal class Individual : TaxPayer
    {
        public double HelthExpenditures { get; set; }
        double x = 0;
        double total;
        public Individual(string nome, double anualIncome, double helthExpenditures)
            : base(nome, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }
        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                if (HelthExpenditures > 0)
                {
                    x = HelthExpenditures / 2;
                }
                total = (AnualIncome * 0.15) - x;
            }
            else
            {
                if (HelthExpenditures > 0)
                {
                    x = HelthExpenditures / 2;
                }
                total = (AnualIncome * 0.25) - x;
            }
            return total;
        }
    }
}
