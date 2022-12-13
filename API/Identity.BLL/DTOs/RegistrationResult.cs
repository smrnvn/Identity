namespace Identity.BLL.DTOs
{
    public class RegistrationResult
    {
        public RegistrationResult(bool isRegistrate, UserDTO? user)
        {
            IsRegistrate = isRegistrate;
            User = user;
        }
        public bool IsRegistrate { get; set; }
        public UserDTO? User { get; set; } 
    }
}
