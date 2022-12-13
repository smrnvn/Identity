using Identity.BLL.DTOs;

namespace Identity.BLL.Services
{
    public interface IUserService
    {
        public Task<bool> Login(UserDTO userDTO);
        public Task<RegistrationResult> Registrate(UserDTO userDTO);
    }
}
