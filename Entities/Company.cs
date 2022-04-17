namespace ExFinal.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberEmployees { get; set; }
        double total;
        public Company(string nome, double anualIncome, int numberEmployees)
            : base(nome, anualIncome)
        {
            NumberEmployees = numberEmployees;
        }
        public override double Tax()
        {
            if (NumberEmployees > 10)
            {
                total = (AnualIncome * 0.14);
            }
            else
            {
                total = (AnualIncome * 0.16);
            }
            return total;
        }
    }
}