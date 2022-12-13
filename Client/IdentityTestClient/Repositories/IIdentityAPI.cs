using IdentityTestClient.Models;
using Refit;
using System.Threading.Tasks;

namespace IdentityTestClient.Repositories
{
    public interface IIdentityAPI
    {
        [Post("/users/login")]
        Task<bool> Login([Body]User user);

        [Post("/users/registrate")]
        Task<RegistrationResult> Registrate([Body]User user);
    }
}
