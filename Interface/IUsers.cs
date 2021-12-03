using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myAspMiniProject.Enum;
using myAspMiniProject.ViewModel;

namespace myAspMiniProject.Interface
{
    public interface IUsers
    {
        public Task<Result> AddUsers(AddUsersViewModel vm);
        public Task<Result> UpdateUsers(UpdateUsersViewModel vm);
        public Task<Result> DeleteUser(int id);
    }
}