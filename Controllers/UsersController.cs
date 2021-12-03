using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myAspMiniProject.Interface;
using myAspMiniProject.ViewModel;

namespace myAspMiniProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly IUsers _iuser;

        public UsersController(IUsers iuser)
        {
            _iuser = iuser;
        }


        [HttpPost]

        public async Task<IActionResult> AddUser(AddUsersViewModel vm)
        {

            var user = await _iuser.AddUsers(vm);
            switch (user)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.Success:
                    return Ok("عملیات با موفقیت انجام شد");
                default:
                    return Ok();
            }

        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUsersViewModel vm)
        {

            var user = await _iuser.UpdateUsers(vm);
            switch (user)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.Success:
                    return Ok("عملیات با موفقیت انجام شد");
                default:
                    return Ok();
            }

        }


        [HttpDelete("id")]
        public async Task<IActionResult> DeleteUser(int id)
        {


            var user = await _iuser.DeleteUser(id);
            switch (user)
            {
                case Enum.Result.Error:
                    return BadRequest("خطایی رخ داده است");
                case Enum.Result.Success:
                    return Ok("عملیات با موفقیت انجام شد");
                default:
                    return Ok();
            }

        }


    }
}