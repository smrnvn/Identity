using Identity.BLL.DTOs;
using Identity.BLL.Extantions;
using Identity.BLL.Infrastructure;
using Identity.DAL;
using Identity.DAL.Repositories;

namespace Identity.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IdentityContext _identityContext;
        private readonly IEncryptation _encryptation;
        private readonly UserRepository _userRepository;

        public UserService(IdentityContext identityContext,IEncryptation encryptation)
        {
            _identityContext = identityContext;
            _encryptation = encryptation;
            _userRepository = new UserRepository(identityContext);
        }
        public async Task<bool> Login(UserDTO userDTO)
        {
           var user = await _userRepository.FindUser(userDTO.Name);

            if (user == null)
            {
                return false;
            }

            var pass = _encryptation.UnEncrypte(user.Password);

            if (pass != userDTO.Password)
            {
                return false;
            }

            return true;
        }

        public async Task<RegistrationResult> Registrate(UserDTO userDTO)
        {
            var user = await _userRepository.FindUser(userDTO.Name);
            if(user != null)
            {
                return new RegistrationResult(false, null);
            }

            var newUser = userDTO.ToEntity();
            newUser.Password = _encryptation.ToEncrypte(newUser.Password);

            await _userRepository.CreateUser(newUser);
            await _identityContext.SaveChangesAsync();

            return new RegistrationResult(true, newUser.ToDTO());
        }
    }
}
