using System.ComponentModel.DataAnnotations.Schema;

namespace FinalExam.Database.Entities
{
    public class UserAddress
    {
        public int Id { get; set; }
        //public int UserAddressId { get; set; }

        [ForeignKey("UserLogin")]
        public int? UserLoginId { get; set; }
        public UserLogin UserLogin { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public int ApartmentNumber { get; set; }

    }
}
