using AbcTestApp.Application.Extensions;
using AbcTestApp.Application.Interfaces;
using AbcTestApp.Infrastructure.Data.Identity;
using AbcTestApp.SharedModel.Administrations.Users;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AbcTestApp.Application.Services
{
    public class AdministrationService : IAdministrationService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public AdministrationService(UserManager<ApplicationUser> userManager, 
                                     RoleManager<IdentityRole> roleManager, 
                                     SignInManager<ApplicationUser> signInManager, 
                                     IMapper mapper)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _mapper = mapper;
        }

        public async Task<ApplicationUser> CreateUser(NewUserModel _)
        {
            try
            {
                var user = new ApplicationUser
                {
                    Name = _.Name,
                    LastName = _.LastName,
                    Email = _.Email,
                    UserName = _.Email
                };
                FillCrudData<ApplicationUser>.Entry(ref user);

                var result = await _userManager.CreateAsync(user, _.Password);

                if (!result.Succeeded)
                    return null;
                await _userManager.AddToRoleAsync(user, "Moderator");

                return user;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteUser()
        {
            throw new NotImplementedException();
        }

        public async Task<ApplicationUser> GetUser(string username)
        {
            return await _userManager.FindByNameAsync(username);
        }

        public ApplicationUser GetUserById(string userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ApplicationUser> GetUsers()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SignIn(Credentials _)
        {
            var result = await _signInManager.PasswordSignInAsync(_.Email, _.Password, _.RememberMe, false);

            if (result.Succeeded)
                return true;

            return false;
        }

        public async Task<bool> SignOut()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void UpdateUser()
        {
            throw new NotImplementedException();
        }

        public IdentityRole GetRole(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IdentityRole> GetRoleByName(string name)
        {
            return await _roleManager.FindByNameAsync(name);
        }

        public IEnumerable<IdentityRole> GetRoles()
        {
            throw new NotImplementedException();
        }
    }
}
