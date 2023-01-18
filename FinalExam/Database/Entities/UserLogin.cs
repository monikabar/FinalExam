namespace FinalExam.Database.Entities
{
    public class UserLogin
    {
        public int Id { get; set; }
        //public int UserLoginId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserAccount UserAccount { get; set; }
        //public int UserAccountId {get; set}
        public UserAddress UserAddress { get; set; }
        //public int UserAccountId {get; set}
    }
}
