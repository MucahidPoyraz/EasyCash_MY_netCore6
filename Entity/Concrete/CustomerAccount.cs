namespace Entity.Concrete
{
    public class CustomerAccount : BaseEntity
    {
        public string? Number { get; set; }
        public decimal Balance { get; set; }
        public string? BankBranch { get; set; }
        public int CurrencyId { get; set; }
        public Currency? Currency { get; set; }
    }
}
