using GGiftCards.BusinessLayer.Repository;
using GiftCards.BusinessLayer.Interface;
using GiftCards.BusinessLayer.Services;
using GiftCards.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace GiftCards.Tests
{
   public class BoundaryTests
    {
        private IPlaceOrderServices _services;
        // private IAdminServices _adminservices;

        public readonly Mock<IPlaceOrderRepository> service = new Mock<IPlaceOrderRepository>();

        public BoundaryTests()
        {
            _services = new PlaceOrderServices(service.Object);
            //   _adminservices = new AdminServices(services.Object);

        }
        Random random = new Random();

        [Fact]
        public void Boundary_Testfor_ValidId()
        {
            //Action
            Buyer buyer = new Buyer()
            {
                Id = random.Next(1, 300000),
                FirstName = "ddd",
                LastName = "ddd",
                Email = "ff@gmail.com",
                PhoneNumber = 123456779,
                Address = "Delhi"
            };          //Assert
            Assert.InRange(buyer.Id, 1, 300000);

        }

        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            Buyer buyer = new Buyer()
            {
                Id = random.Next(1, 100),
                FirstName = "ddd",
                LastName = "ddd",
                Email = "abcf@gmail.com",
                PhoneNumber = 123456779,
                Address = "Delhi"
            };

            bool isEmail = Regex.IsMatch(buyer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

    }
}
