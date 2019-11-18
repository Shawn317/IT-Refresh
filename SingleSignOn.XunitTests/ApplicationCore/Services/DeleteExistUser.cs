using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SingleSignOn.XunitTests.ApplicationCore.Services
{

    public class ExistUser
    {
        //public long UserId { get; set; }
        public string UserName { get; set; }

        //public long password { get; set; }
    }
    public class DeleteExistUser:ExistUser
    {
    
        [Fact]
        public void DeleteUser()
        {
            var username = "Adam Smith";
            var user = new DeleteExistUser()
            {
                UserName = username
            };

            Assert.Equal(username,user.UserName);
                
        }

        [Fact]
        public void DeleteUser_false()
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
