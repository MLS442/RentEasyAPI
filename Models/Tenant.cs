namespace RentEasyAPI.Models
{
    public class Tenant
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateOnly BirthDate { get; set; }

    }
}
