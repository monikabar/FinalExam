using FinalExam.Database.Entities;
using FinalExam.Interfaces;
using FinalExam.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FinalExam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersAddressesController : ControllerBase
    {
        private readonly IUserAddressRepo _userAddressRepo;

        public UsersAddressesController(IUserAddressRepo userAddressRepo)
        {
            _userAddressRepo = userAddressRepo;
        }

        [HttpPost("EnterUserAddressInfo")]
        public UserAddress EnterUserAddressInfo([FromBody] UserAddressDTO userAddress)
        {
            return _userAddressRepo.AddNewUserAddress(userAddress);
        }

        [HttpGet("GetAllUsersAddresses")]
        public List<UserAddress> GetAllUsersAddresses()
        {
            return _userAddressRepo.GetAllUsersAddresses();
        }

        [HttpGet("GetUserAddressById")]
        public List<UserAddress> GetUserAddressById([FromQuery] int id)
        {
            return _userAddressRepo.GetUserAddressById(id);
        }

        [HttpGet("GetUserAddressById2")]
        public UserAddress GetUserAddressById2([FromQuery] int id)
        {
            return _userAddressRepo.GetUserAddressById2(id);
        }

        [HttpPut("UpdateAllUserAddress")]
        public UserAddress UpdateAllUserAddress([FromQuery] int id, [FromBody] UserAddressDTO userAddress)
        {
            return _userAddressRepo.UpdateAllUserAddress(id, userAddress);
        }

        [HttpPut("UpdateUserAddressCity")]
        public UserAddress UpdateUserAddressCity([FromQuery] int id, [FromBody] string city)
        {
            return _userAddressRepo.UpdateUserAddressCity(id, city);
        }

        [HttpPut("UpdateUserAddressStreet")]
        public UserAddress UpdateUserAddressStreet([FromQuery] int id, [FromBody] string street)
        {
            return _userAddressRepo.UpdateUserAddressStreet(id, street);
        }

        [HttpPut("UpdateUserAddressHouseNumber")]
        public UserAddress UpdateUserAddressHouseNumber([FromQuery] int id, [FromBody] string houseNumber)
        {
            return _userAddressRepo.UpdateUserAddressHouseNumber(id, houseNumber);
        }

        [HttpPut("UpdateUserAddressApartmentNumber")]
        public UserAddress UpdateUserAddressApartmentNumber([FromQuery] int id, [FromBody] int apartmentNumber)
        {
            return _userAddressRepo.UpdateUserAddressApartmentNumber(id, apartmentNumber);
        }

        [HttpDelete("DeleteUserAddressById")]
        public UserAddress DeleteUserAddressById([FromQuery] int id)
        {
            return _userAddressRepo.DeleteUserAddressById(id);
        }
    }
}
