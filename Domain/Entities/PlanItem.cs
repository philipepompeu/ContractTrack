namespace ContractTrack.Domain.Entities
{
    public class PlanItem
    {
        public Guid Id { get; set; }

        public Plan Plan { get; set; }

        public Product Product { get; set; }

        
    }
}
