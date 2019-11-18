using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Xunit;

namespace SingleSignOn.XunitTests.ApplicationCore.Services
{
    public class AddNewUser
    {
        public class NewUser
        {
            [Required]
            public long UserId { get; set; }
            public string UserName { get; set; }
            public long password { get; set; }
        }
        [Fact]
        public void ReturnFalse()
        {
            var result = new ExistUser();
            var _AIsPrime = result.Equals(1);
     
            Assert.False(_AIsPrime, "Is Not Prime.");
        }
        [Fact]
        public void AddUser()
        {
            var username = "Adam Smith";
            var user = new DeleteExistUser()
            {
                UserName = username
            };

            Assert.Equal(username, user.UserName);

        }

        [Fact]
        public void AddUser_false()
        {
            var username = "Bod Smith";
            var user = new DeleteExistUser()
            {
                UserName = username
            };

            Assert.True("Bod Smith" == user.UserName);
        }
    }
}
