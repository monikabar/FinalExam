namespace FinalExam.Database.Entities
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

    }
}
