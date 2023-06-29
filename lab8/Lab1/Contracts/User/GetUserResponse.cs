namespace Lab2.Contracts.User
{
    public class GetUserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Card { get; set; }
        public bool IsDeleted { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
