namespace Lab2.Contracts.User
{
    public class CreateUserRequest
    {
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string Card { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

    }
}
