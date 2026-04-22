namespace WebApi.Model
{
    public class CreateSpendingRequest
    {
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
    }
}
