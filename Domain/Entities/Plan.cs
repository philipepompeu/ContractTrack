namespace ContractTrack.Domain.Entities
{
    public class Plan
    {
        public Guid Id { get; set; }

        public Guid ContractId { get; set; }
        public Contract Contract { get; set; }
        public Customer Customer { get; set; }

        public PlanTemplate Template { get; set; }
        public ICollection<PlanItem> Items { get; set; }


    }
}
