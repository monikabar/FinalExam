namespace FinalExam.Database.Entities
{
    public class UserAddressDTO
    {
        public int UserLoginId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }
    }
}
