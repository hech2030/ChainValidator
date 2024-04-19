namespace ChainValidatorSample.DTO
{
    internal class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string EmailConfirmed { get; set; } = string.Empty;
        public string PasswordConfirmed { get; set; } = string.Empty;
    }
}
