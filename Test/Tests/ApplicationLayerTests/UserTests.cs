using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models;
using Xunit;

namespace Test.Tests.ApplicationLayerTests
{
    public class UserTests
    {
        [Fact]
        public void ShouldCreateNewUser()
        {
            User ExpectedUser = new User
            {
                UserName = "Bartek",
                Email = "testowy@mail.com",
                Password = "A94A8FE5CCB19BA61C4C0873D391E987982FBBD3",
                UserType = 1,
                SellerID = null
            };

            User ActualUser = 
        }
    }
}
