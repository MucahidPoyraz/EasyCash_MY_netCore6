namespace Entity.Concrete
{
    public class CustomerAccountProcess : BaseEntity
    {
        public Guid CustomerAccountId { get; set; }
        public CustomerAccount? CustomerAccount { get; set; }
    }
}
