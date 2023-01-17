using FinalExam.Database.Entities;

namespace FinalExam.Interfaces
{
    public interface IUserLoginRepo
    {
        public UserLogin AddNewUserLogin(UserLoginDTO userLogin);
        public UserLogin UpdateUserLoginById(int id, UserLoginDTO userLogin);
        public UserLogin DeleteUserLoginById(int id);
        List<UserLogin> GetAllUsersLogins();
        List<UserLogin> GetUserLoginById(int id);
        List<UserLogin> GetUserLoginByUsernameAndPassword(string username, string password);
        public UserLogin GetUserLogin(UserLoginDTO userLoginDTO);
    }
}
