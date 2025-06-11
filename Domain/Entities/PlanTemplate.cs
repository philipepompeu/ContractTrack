namespace ContractTrack.Domain.Entities
{
    public class PlanTemplate
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool HasFixedSchedule { get; set; }
        public bool HasFinancialForecast { get; set; }
        public bool AllowsAutoMeasurement { get; set; }

        public decimal MeasurementOverflowLimit {  get; set; }




    }
}
