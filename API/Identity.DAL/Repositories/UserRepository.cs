using Identity.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Identity.DAL.Repositories
{
    public class UserRepository
    {
        private readonly IdentityContext _identityContext;

        public UserRepository(IdentityContext identityContext)
        {
            _identityContext = identityContext;
        }

        public async Task CreateUser(User user)
        {
           await _identityContext.Users.AddAsync(user);
        }

        public async Task<User?> FindUser(string name)
        {
          return await _identityContext.Users.FirstOrDefaultAsync(i => i.Name == name);
        }
    }
}
