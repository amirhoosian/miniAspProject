using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myAspMiniProject.Enum;
using myAspMiniProject.Interface;
using myAspMiniProject.Models;
using myAspMiniProject.ViewModel;

namespace myAspMiniProject.Services
{
    public class UsersServices : IUsers
    {
        private readonly miniApiContext _context;

        public UsersServices(miniApiContext context)
        {
            _context = context;
        }

        public async Task<Result> AddUsers(AddUsersViewModel vm)
        {
            User newUser = new()
            {
                Fullname = vm.Fullname,
                Email = vm.Email
            };

            await _context.AddAsync(newUser);
            await _context.SaveChangesAsync();

            return Result.Success;

        }

        public async Task<Result> DeleteUser(int id)
        {
            var User = await _context.Users.FindAsync(id);
            _context.Remove(User);
            await _context.SaveChangesAsync();
            return Result.Success;
        }

        public async Task<Result> UpdateUsers(UpdateUsersViewModel vm)
        {
            var Users = await _context.Users.FirstOrDefaultAsync(c => c.Id == vm.id);
            Users.Fullname = vm.Fullname;
            Users.Email = vm.Email;

            _context.Update(Users);
            await _context.SaveChangesAsync();

            return Result.Success;
        }
    }
}