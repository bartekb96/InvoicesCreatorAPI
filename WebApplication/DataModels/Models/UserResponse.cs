using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public class UserResponse
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        public int UserType { get; set; }

        public int? SellerID { get; set; }
    }
}
