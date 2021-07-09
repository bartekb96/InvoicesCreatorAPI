﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public class SellerResponse
    {
        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string NIP { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public AddressResponse Address { get; set; }
    }
}