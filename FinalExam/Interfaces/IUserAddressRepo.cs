using FinalExam.Database.Entities;

namespace FinalExam.Interfaces
{
    public interface IUserAddressRepo
    {
        public UserAddress AddNewUserAddress(UserAddressDTO userAddress);
        public UserAddress UpdateAllUserAddress(int id, UserAddressDTO userAddress);
        public UserAddress UpdateUserAddressCity(int id, string city);
        public UserAddress UpdateUserAddressStreet(int id, string street);
        public UserAddress UpdateUserAddressHouseNumber(int id, string houseNumber);
        public UserAddress UpdateUserAddressApartmentNumber(int id, int apartmentNumber);
        public UserAddress DeleteUserAddressById(int id);
        public List<UserAddress> GetAllUsersAddresses();
        public List<UserAddress> GetUserAddressById(int id);
        public UserAddress GetUserAddressById2(int id);
    }
}
