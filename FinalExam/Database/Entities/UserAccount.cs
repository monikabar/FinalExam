namespace FinalExam.Database.Entities
{
    public class UserAccount
    {
        public int Id { get; set; }
        public int UserLoginId { get; set; }
        public byte[] Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public int UserAddressId { get; set; }

    }
}
