namespace FinalExam.Database.Entities
{
    public class UserAccountDTO
    {
        public byte[] Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalCode { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
