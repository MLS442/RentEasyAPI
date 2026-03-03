namespace RentEasyAPI.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }

        public int TenantId { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }
    }
}
