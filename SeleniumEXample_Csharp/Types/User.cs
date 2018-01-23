using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumEXample_Csharp.Types
{
    public class User
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string Address { get; private set; }
        public string PostCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string Zone { get; private set; }
        public string PhoneNumber { get; private set; }
        
        private readonly Utils.Utils _utils;

        public User()
        {
            _utils = new Utils.Utils();
            FirstName = _utils.RandomString(5);
            LastName = _utils.RandomString(5);
            Email = GetRandomEmail();
            //Password = _utils.RandomString(5);
            Password = "testtest";
            Address = "Washington st. 12 ";
            PostCode = _utils.RandomNumericString(5);
            City = "Washington";
            Country = "United States";
            Zone = "Washington";
            PhoneNumber = "+1 360" + _utils.RandomNumericString(7);

        }

        private string GetRandomEmail()
        {
            return _utils.RandomString(5) + "@gmail.com";
        }
    }
}
