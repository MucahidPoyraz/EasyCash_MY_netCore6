namespace Entity.Concrete
{
    public class Currency : BaseEntity
    {
        public string CurrencyType { get; set; }
        public List<CustomerAccount> CustomerAccounts { get; set; }
    }
}
