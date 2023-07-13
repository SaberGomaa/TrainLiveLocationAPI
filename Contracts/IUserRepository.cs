using Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUser();
        User? GetUserByPhone(string Phone);
        User? GetUserById(int userID);
        User? GetUserTokenByPhone(string Phone);
        User? CheckEmail(string Email);
        User? CheckPassword( string Password);
        User? CheckPhone(string Phone);
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
    }
}
