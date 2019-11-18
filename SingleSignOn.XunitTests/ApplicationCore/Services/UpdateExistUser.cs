using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SingleSignOn.XunitTests.ApplicationCore.Services
{
    internal class PrimeService
    {
        internal bool IsPrime(int v)
        {
            throw new NotImplementedException();
        }
        public class UpdateExistUser
    {
        public class PrimeService_IsPrimeShould
        {
            private readonly PrimeService _primeService;

            public PrimeService_IsPrimeShould()
            {
                _primeService = new PrimeService();
            }

            public bool IsPrime(int candidate)
            {
                if (candidate == 1)
                {
                    return false;
                }
                throw new NotImplementedException("Please create a test first.");
            }

            [Fact]
            public void IsPrime_InputIs1_ReturnFalse()
            {
                var result = _primeService.IsPrime(1);

                Assert.True(result, "1 should not be prime");
            }
        }
        [Fact]
        public void UpdateUser()
        {
            var username = "Adam Smith";
            var user = new DeleteExistUser()
            {
                UserName = username
            };

            Assert.Equal(username, user.UserName);

        }

        [Fact]
        public void UpdateUser_false()
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
}
