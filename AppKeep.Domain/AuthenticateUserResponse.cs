namespace AppKeep.Domain
{
    public class AuthenticateUserResponse
    {
        public bool Authenticated { get; set; }
        public bool EmailAddressFound { get; set; }
        public bool PasswordValid { get; set; }
        public User User { get; set; }
    }
}