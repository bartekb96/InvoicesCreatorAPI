using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public class Address
    {
        public string Street { get; set; }

        public string HouseNumber { get; set; }

        public string LocalNumber { get; set; }

        public string PostCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
