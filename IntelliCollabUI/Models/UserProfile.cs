using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IntelliCollabUI.Models
{
    public class UserProfile
    {
        public int? UserId { get; set; }
        public string RegistrationNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public long? MobileNo { get; set; }
        public byte?[] Image { get; set; }
        public string ImageType { get; set; }
        public string DummyRegs { get; set; }
    }
}