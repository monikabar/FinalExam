using FinalExam.Database.Entities;

namespace FinalExam.Interfaces
{
    public interface IUserAccountRepo
    {
        public UserAccount AddNewUserAccount(UserAccountDTO userAccount);
        public UserAccount UpdateAllUserAccount(int id, UserAccountDTO userAccount);
        public UserAccount UpdateUserAccountImage(int id, byte[] image);
        public UserAccount UpdateUserAccountFirstName(int id, string firstName);
        public UserAccount UpdateUserAccountLastName(int id, string lastName);
        public UserAccount UpdateUserAccountPersonalCode(int id, int personalCode);
        public UserAccount UpdateUserAccountPhoneNumber(int id, int phoneNumber);
        public UserAccount UpdateUserAccountEmail(int id, string email);
        public UserAccount DeleteUserAccountById(int id);
        public List<UserAccount> GetAllUsersAccounts();
        public List<UserAccount> GetUserAccountById(int id);
        public UserAccount GetUserAccountById2(int id);
    }
}
