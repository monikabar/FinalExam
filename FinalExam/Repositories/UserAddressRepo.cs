using FinalExam.Database.Entities;
using FinalExam.Database;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class UserAddressRepo : IUserAddressRepo
    {
        private readonly ApplicationDbContext _context;

        public UserAddressRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly List<UserAddress> _usersAddresses = new();

        public UserAddress AddNewUserAddress(UserAddressDTO userAddress)
        {
            var newUserAddress = new UserAddress
            {
                UserLoginId = userAddress.UserLoginId,
                City = userAddress.City,
                Street = userAddress.Street,
                HouseNumber = userAddress.HouseNumber,
                ApartmentNumber = userAddress.ApartmentNumber,
            };
            _context.UsersAddresses.Add(newUserAddress);
            _context.SaveChanges();

            return newUserAddress;
        }

        public UserAddress UpdateAllUserAddress(int id, UserAddressDTO userAddress)
        {
            var userAddressToUpdate = _context.UsersAddresses.Single(x => x.Id == id);
            //userAddressToUpdate.UserLoginId = userAddress.UserLoginId;
            userAddressToUpdate.City = userAddress.City;
            userAddressToUpdate.Street = userAddress.Street;
            userAddressToUpdate.HouseNumber = userAddress.HouseNumber;
            userAddressToUpdate.ApartmentNumber = userAddress.ApartmentNumber;
            _context.SaveChanges();

            return userAddressToUpdate;
        }

        public UserAddress UpdateUserAddressCity(int id, string city)
        {
            var userAddressCityToUpdate = _context.UsersAddresses.Single(x => x.Id == id);
            userAddressCityToUpdate.City = city;
            _context.SaveChanges();

            return userAddressCityToUpdate;
        }

        public UserAddress UpdateUserAddressStreet(int id, string street)
        {
            var userAddressStreetToUpdate = _context.UsersAddresses.Single(x => x.Id == id);
            userAddressStreetToUpdate.Street = street;
            _context.SaveChanges();

            return userAddressStreetToUpdate;
        }

        public UserAddress UpdateUserAddressHouseNumber(int id, string houseNumber)
        {
            var userAddressHouseNumberToUpdate = _context.UsersAddresses.Single(x => x.Id == id);
            userAddressHouseNumberToUpdate.HouseNumber = houseNumber;
            _context.SaveChanges();

            return userAddressHouseNumberToUpdate;
        }
        public UserAddress UpdateUserAddressApartmentNumber(int id, int apartmentNumber)
        {
            var userAddressApartmentNumberToUpdate = _context.UsersAddresses.Single(x => x.Id == id);
            userAddressApartmentNumberToUpdate.ApartmentNumber = apartmentNumber;
            _context.SaveChanges();

            return userAddressApartmentNumberToUpdate;
        }

        public UserAddress DeleteUserAddressById(int id)
        {
            var userAddressToDelete = _context.UsersAddresses.Single(x => x.Id == id);
            _context.UsersAddresses.Remove(userAddressToDelete);
            _context.SaveChanges();

            return userAddressToDelete;
        }

        public List<UserAddress> GetAllUsersAddresses()
        {
            return _context.UsersAddresses.ToList();
        }

        public List<UserAddress> GetUserAddressById(int id)
        {
            return _context.UsersAddresses.Where(x => x.Id == id).ToList();
        }

        public UserAddress GetUserAddressById2(int id)
        {
            var userAddress = _context.UsersAddresses.Single(x => x.Id == id);
            return userAddress;
        }
    }
}
