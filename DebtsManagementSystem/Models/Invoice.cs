namespace DebtsManagementSystem.Models
{
    public enum InvoiceType { Sales=1,Purchase=2}
    public class Invoice
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public InvoiceType InvoiceType { get; set; }
        public Customer Customer { get; set; }
        public string ProductName { get; set; } = "";
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal ReminigAmount { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

    }
}
