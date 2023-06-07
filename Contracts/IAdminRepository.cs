using Entites;
using Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAdminRepository
    {
            IEnumerable<Admin> GetAllAdmins();
            Admin GetAdminById(int Id);
            Admin LoginForAdmin(string phone, string password);
            void CreateAdmin(Admin admin);
            void DeleteAdmin(Admin admin);
            void UpdateAdmin(Admin admin);
    }
    
}
