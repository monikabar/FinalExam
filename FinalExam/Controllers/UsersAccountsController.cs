using FinalExam.Database.Entities;
using FinalExam.Interfaces;
using FinalExam.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersAccountsController : ControllerBase
    {
        private readonly IUserAccountRepo _userAccountRepo;
        public UsersAccountsController(IUserAccountRepo userAccountRepo)
        {
            _userAccountRepo = userAccountRepo;
        }

        [HttpPost("EnterUserAccountInfo")]
        public UserAccount EnterUserAccountInfo([FromBody] UserAccountDTO userAccount)
        {
            return _userAccountRepo.AddNewUserAccount(userAccount);
        }

        [HttpGet("GetAllUsersAccounts")]
        public List<UserAccount> GetAllUsersAccounts()
        {
            return _userAccountRepo.GetAllUsersAccounts();
        }

        [HttpGet("GetUserAccountById")]
        public List<UserAccount> GetUserAccountById([FromQuery] int id)
        {
            return _userAccountRepo.GetUserAccountById(id);
        }

        [HttpGet("GetUserAccountById2")]
        public UserAccount GetUserAccountById2([FromQuery] int id)
        {
            return _userAccountRepo.GetUserAccountById2(id);
        }

        [HttpPut("UpdateAllUserAccount")]
        public UserAccount UpdateAllUserAccount([FromQuery] int id, [FromBody] UserAccountDTO userAccount)
        {
            return _userAccountRepo.UpdateAllUserAccount(id, userAccount);
        }

        [HttpPut("UpdateUserAccountImage")]
        public UserAccount UpdateUserAccountImage([FromQuery]int id, [FromBody]byte[] image)
        {
            return _userAccountRepo.UpdateUserAccountImage(id, image);
        }

        [HttpPut("UpdateUserAccountFirstName")]
        public UserAccount UpdateUserAccountFirstName([FromQuery] int id, [FromBody] string firstName)
        {
            return _userAccountRepo.UpdateUserAccountFirstName(id, firstName);
        }

        [HttpPut("UpdateUserAccountLastName")]
        public UserAccount UpdateUserAccountLastName([FromQuery] int id, [FromBody] string lastName)
        {
            return _userAccountRepo.UpdateUserAccountLastName(id, lastName);
        }

        [HttpPut("UpdateUserAccountPersonalCode")]
        public UserAccount UpdateUserAccountPersonalCode([FromQuery] int id, [FromBody] int personalCode)
        {
            return _userAccountRepo.UpdateUserAccountPersonalCode(id, personalCode);
        }

        [HttpPut("UpdateUserAccountPhoneNumber")]
        public UserAccount UpdateUserAccountPhoneNumber([FromQuery] int id, [FromBody] int phoneNumber)
        {
            return _userAccountRepo.UpdateUserAccountPhoneNumber(id, phoneNumber);
        }

        [HttpPut("UpdateUserAccountEmail")]
        public UserAccount UpdateUserAccountEmail([FromQuery] int id, [FromBody] string email)
        {
            return _userAccountRepo.UpdateUserAccountEmail(id, email);
        }

        [HttpDelete("DeleteUserAccountById")]
        public UserAccount DeleteUserAccountById([FromQuery] int id)
        {
            return _userAccountRepo.DeleteUserAccountById(id);
        }
    }
}
