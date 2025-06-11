namespace ContractTrack.Domain.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public ICollection<Plan> Plans { get; set; } = new List<Plan>();
    }
}
