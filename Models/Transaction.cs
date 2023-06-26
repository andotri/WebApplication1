namespace WebApplication1.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public String UserId { get; set; } = null!;
        public int ServiceId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int Total { get; set; }
        public Service Service { get; set; } = null!;
    }
}
