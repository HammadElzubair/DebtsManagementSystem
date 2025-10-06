namespace DebtsManagementSystem.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public string TransactionNumber { get; set; } = ""; // رقم العملية البنكية (فريد)
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Note { get; set; } = string.Empty;

    }
}
