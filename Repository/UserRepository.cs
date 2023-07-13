using Entites;
using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.Design;
using System.Numerics;

namespace Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public User? CheckEmail(string Email)
        {
            return FindByCondition(x => x.Email == Email).FirstOrDefault();
        }


        public User? GetUserByPhone(string Phone)
        {
            return FindByCondition(c => c.Phone.Equals(Phone)).SingleOrDefault();
        }
        public User? CheckPassword(string Password)
        {
            return FindByCondition(x => x.Password == Password).SingleOrDefault();
        }
        public User? CheckPhone(string Phone)
        {
            return FindByCondition(x => x.Phone == Phone).SingleOrDefault();
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public IEnumerable<User> GetAllUser()
        {
            return FindAll().ToList();
        }


        public User? GetUserById(int userID)
        {
            return FindByCondition(c => c.Id.Equals(userID)).SingleOrDefault();
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public User? GetUserTokenByPhone(string Phone)
        {
            return FindByCondition(c => c.Phone.Equals(Phone)).SingleOrDefault();
        }
    }
}
