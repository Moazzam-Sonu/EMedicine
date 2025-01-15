namespace EMedicine.Web.Model
{
    public class Users
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public decimal Fund { get; set; }
        public string? Type { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
