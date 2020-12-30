using AbcTestApp.Infrastructure.Data.Identity;
using AbcTestApp.SharedModel.Administrations.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcTestApp.Application.Interfaces
{
    public interface IAdministrationService
    {
        //User
        Task<ApplicationUser> CreateUser(NewUserModel _);
        void UpdateUser();
        void DeleteUser();
        IEnumerable<ApplicationUser> GetUsers();
        ApplicationUser GetUserById(string userId);
        Task<ApplicationUser> GetUser(string username);
        Task<bool> SignIn(Credentials _);
        Task<bool> SignOut();

        //Role
        IdentityRole GetRole(string id);
        IEnumerable<IdentityRole> GetRoles();
    }
}
