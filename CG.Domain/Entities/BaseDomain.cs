namespace CG.Domain.Entities
{
    public abstract class BaseDomain
    {
        public Guid Id { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
