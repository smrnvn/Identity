using Identity.BLL.DTOs;
using Identity.DAL.Models;

namespace Identity.BLL.Extantions
{
    internal static class UserExtantion
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO()
            { 
                Id = user.Id, 
                Name = user.Name, 
                Password = user.Password 
            };
        }
        public static User ToEntity(this UserDTO user)
        {
            return new User() 
            { 
                Id = user.Id, 
                Name = user.Name, 
                Password = user.Password 
            };
        }
    }
}
