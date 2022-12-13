namespace IdentityTestClient.Models
{
    public class RegistrationResult
    {
        public RegistrationResult(bool isRegistrate, User? user)
        {
            IsRegistrate = isRegistrate;
            User = user;
        }
        public bool IsRegistrate { get; set; }
        public User? User { get; set; } 
    }
}
