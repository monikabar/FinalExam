using FinalExam.Database.Entities;
using FinalExam.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Runtime.ConstrainedExecution;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersLoginsController : ControllerBase
    {
        private readonly IUserLoginRepo _userLoginRepo;

        public UsersLoginsController(IUserLoginRepo userLoginRepo)
        {
            _userLoginRepo = userLoginRepo;
        }

        [HttpPost("Register")]
        public UserLogin Register([FromBody] UserLoginDTO userLogin)
        {
            return _userLoginRepo.AddNewUserLogin(userLogin);
        }

        /*
        [HttpGet("Login")]
        public UserLogin Login([FromQuery] UserLoginDTO userLoginDTO)
        {
            return _userLoginRepo.GetUserLogin(userLoginDTO);
        }
        */

        [HttpGet("LoginWithUsernamePassword")]
        public List<UserLogin> GetUserLoginByUsernameAndPassword([FromQuery] string username, string password)
        {
            return _userLoginRepo.GetUserLoginByUsernameAndPassword(username, password);
        }

        [HttpGet("GetAllLogins")]
        public List<UserLogin> GetAllUsersLogins()
        {
            return _userLoginRepo.GetAllUsersLogins();
        }

        [HttpGet("GetLoginById")]
        public List<UserLogin> GetUserLoginById([FromQuery] int id)
        {
            return _userLoginRepo.GetUserLoginById(id);
        }

        [HttpPut("UpdateLoginById")]
        public UserLogin UpdateUserLoginById([FromQuery] int id, [FromBody] UserLoginDTO userLogin)
        {
            return _userLoginRepo.UpdateUserLoginById(id, userLogin);
        }

        [HttpDelete("DeleteLoginById")]
        public UserLogin DeleteUserLogin([FromQuery] int id)
        {
            return _userLoginRepo.DeleteUserLoginById(id);
        }

    }
}
