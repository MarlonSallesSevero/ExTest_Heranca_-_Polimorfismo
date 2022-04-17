namespace ExFinal.Entities
{
    internal abstract class TaxPayer
    {
        public string Nome { get; set; }
        public double AnualIncome { get; set; }
        public TaxPayer()
        {
        }
        public TaxPayer(string nome, double anualIncome)
        {
            Nome = nome;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
