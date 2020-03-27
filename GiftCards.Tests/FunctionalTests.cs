using GGiftCards.BusinessLayer.Repository;
using GiftCards.BusinessLayer.Interface;
using GiftCards.BusinessLayer.Repository;
using GiftCards.BusinessLayer.Services;
using GiftCards.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GiftCards.Tests
{
 public   class FunctionalTests
    {
        private IPlaceOrderServices _placeorderservices;
        private IViewOrderServices _viworderservices;
        private IContactUsServices _contactusservices;

        public readonly Mock<IPlaceOrderRepository> placeorderservices = new Mock<IPlaceOrderRepository>();
        public readonly Mock<IViewOrderRepository> viworderservices = new Mock<IViewOrderRepository>();
        public readonly Mock<IContactUsRepository> contactusservices = new Mock<IContactUsRepository>();

        public FunctionalTests()
        {
            _placeorderservices = new PlaceOrderServices(placeorderservices.Object);
            _viworderservices = new ViewOrderServices(viworderservices.Object);
            _contactusservices = new ContactUsServices(contactusservices.Object);

        }
        [Fact]
        public async Task Placeorder()
        {
            Buyer buyer = new Buyer()
            {
                Id = 1,
                FirstName = "ddd",
                LastName = "ddd",
                Email = "ff@gmail.com",
                PhoneNumber = 123456779,
                Address = "Delhi"
            };

            placeorderservices.Setup(repos => repos.PlaceOrderAsync(buyer)).ReturnsAsync(buyer);
            var placeorder = await _placeorderservices.PlaceOrderAsync(buyer);
            Assert.Equal(buyer, placeorder);
        }

        [Fact]
        public async Task ContectUs()
        {
            ContactUs contact = new ContactUs()
            {
                Id = 1,
                PhoneNumber = 12345,
                Email = "D@gmail.com",
                Address = "aaa"
            };
            contactusservices.Setup(repos => repos.ContactUs());
            var contactus = await _contactusservices.ContactUs();
            Assert.Equal(contact, contactus);
        }


        [Fact]
        public async Task ViewGiftCard()
        {
            {
                Buyer buyer = new Buyer()
                {
                    Id = 1,
                    FirstName = "ddd",
                    LastName = "ddd",
                    Email = "ff@gmail.com",
                    PhoneNumber = 123456779,
                    Address = "Delhi",
                    GiftId = 1
                };

                viworderservices.Setup(repos => repos.ViewGiftCard());
                var view = await _viworderservices.ViewGiftCard();
                Assert.Equal(buyer, view);
            }

        }
    }
}
