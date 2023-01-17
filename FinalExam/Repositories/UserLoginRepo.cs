using FinalExam.Database;
using FinalExam.Database.Entities;
using FinalExam.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinalExam.Repositories
{
    public class UserLoginRepo : IUserLoginRepo
    {
        private readonly ApplicationDbContext _context;

        public UserLoginRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        private readonly List<UserLogin> _usersLogins = new();

        public UserLogin AddNewUserLogin(UserLoginDTO userLogin)
        {
            var newUserLogin = new UserLogin
            {
                Username = userLogin.Username,
                Password = userLogin.Password,
                //Role = userLogin.Role,
                Role = "User"
            };
            _context.UsersLogins.Add(newUserLogin);
            _context.SaveChanges();

            return newUserLogin;
        }

        public UserLogin UpdateUserLoginById(int id, UserLoginDTO userLogin)
        {
            var userLoginToUpdate = _context.UsersLogins.Single(x => x.Id == id);
            //userLoginToUpdate.Username = userLogin.Username;
            userLoginToUpdate.Password = userLogin.Password;
            //userLoginToUpdate.Role = userLogin.Role;
            _context.SaveChanges();

            return userLoginToUpdate;
        }

        public UserLogin DeleteUserLoginById(int id)
        {
            var userLoginToDelete = _context.UsersLogins.Single(x => x.Id == id);
            _context.UsersLogins.Remove(userLoginToDelete);
            _context.SaveChanges();

            return userLoginToDelete;
        }

        public List<UserLogin> GetAllUsersLogins()
        {
            return _context.UsersLogins.ToList();
        }

        public List<UserLogin> GetUserLoginById(int id)
        {
            return _context.UsersLogins.Where(x => x.Id == id).ToList();
        }

        public List<UserLogin> GetUserLoginByUsernameAndPassword(string username, string password)
        {
            return _context.UsersLogins.Where(x => x.Username == username && x.Password == password).ToList();
        }

        public UserLogin GetUserLogin(UserLoginDTO userLoginDTO)
        {
            var userLoginToGet = _context.UsersLogins.Single(x => (x.Username == userLoginDTO.Username && x.Password == userLoginDTO.Password));
            return userLoginToGet;
        }

    }
}
