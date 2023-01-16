using FinalExam.Database;
using FinalExam.Database.Entities;
using FinalExam.Interfaces;

namespace FinalExam.Repositories
{
    public class UserAccountRepo : IUserAccountRepo
    {
        private readonly ApplicationDbContext _context;

        public UserAccountRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly List<UserAccount> _usersAccounts = new();

        public UserAccount AddNewUserAccount(UserAccountDTO userAccount)
        {
            var newUserAccount = new UserAccount
            {
                Image = userAccount.Image,
                FirstName = userAccount.FirstName,
                LastName = userAccount.LastName,
                PersonalCode = userAccount.PersonalCode,
                PhoneNumber = userAccount.PhoneNumber,
                Email = userAccount.Email,
            };
            _context.UsersAccounts.Add(newUserAccount);
            _context.SaveChanges();

            return newUserAccount;
        }

        public UserAccount UpdateAllUserAccount(int id, UserAccountDTO userAccount)
        {
            var userAccountToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountToUpdate.Image = userAccount.Image;
            userAccountToUpdate.FirstName = userAccount.FirstName;  
            userAccountToUpdate.LastName = userAccount.LastName;
            userAccountToUpdate.PersonalCode = userAccount.PersonalCode;
            userAccountToUpdate.PhoneNumber = userAccount.PhoneNumber;
            userAccountToUpdate.Email = userAccount.Email;
            _context.SaveChanges();

            return userAccountToUpdate;
        }

        public UserAccount UpdateUserAccountImage(int id, byte[] image)
        {
            var userAccountImageToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountImageToUpdate.Image = image;
            _context.SaveChanges();

            return userAccountImageToUpdate;
        }

        public UserAccount UpdateUserAccountFirstName(int id, string name)
        {
            var userAccountFirstNameToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountFirstNameToUpdate.FirstName = name;
            _context.SaveChanges();

            return userAccountFirstNameToUpdate;
        }

        public UserAccount UpdateUserAccountLastName(int id, string lastName)
        {
            var userAccountLastNameToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountLastNameToUpdate.LastName = lastName;
            _context.SaveChanges();

            return userAccountLastNameToUpdate;
        }

        public UserAccount UpdateUserAccountPersonalCode(int id, int personalCode)
        {
            var userAccountPersonalCodeToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountPersonalCodeToUpdate.PersonalCode = personalCode;
            _context.SaveChanges();

            return userAccountPersonalCodeToUpdate;
        }

        public UserAccount UpdateUserAccountPhoneNumber(int id, int phoneNumber)
        {
            var userAccountPhoneNumberToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountPhoneNumberToUpdate.PhoneNumber = phoneNumber;
            _context.SaveChanges();

            return userAccountPhoneNumberToUpdate;
        }

        public UserAccount UpdateUserAccountEmail(int id, string email)
        {
            var userAccountEmailToUpdate = _context.UsersAccounts.Single(x => x.Id == id);
            userAccountEmailToUpdate.Email = email;
            _context.SaveChanges();

            return userAccountEmailToUpdate;
        }

        public UserAccount DeleteUserAccount(int id)
        {
            var userAccountToDelete = _context.UsersAccounts.Single(x => x.Id == id);
            _context.UsersAccounts.Remove(userAccountToDelete);
            _context.SaveChanges();

            return userAccountToDelete;
        }

        public List<UserAccount> GetAllUsersAccounts()
        {
            return _context.UsersAccounts.ToList();
        }

        public List<UserAccount> GetUserAccountById(int id)
        {
            return _context.UsersAccounts.Where(x => x.Id == id).ToList();
        }

        public UserAccount GetUserAccountById2(int id)
        {
            var userAccount = _context.UsersAccounts.Single(x => x.Id == id);
            return userAccount;
        }
    }
}
