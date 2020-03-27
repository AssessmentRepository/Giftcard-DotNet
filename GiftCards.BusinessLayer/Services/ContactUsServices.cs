using GiftCards.BusinessLayer.Interface;
using GiftCards.BusinessLayer.Repository;
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiftCards.BusinessLayer.Services
{
    public class ContactUsServices : IContactUsServices
    {
        private readonly IContactUsRepository _contactRepository;

        public ContactUsServices(IContactUsRepository repository)
        {
            _contactRepository = repository;
        }

        public Task<ContactUs> ContactUs()
        {
            throw new NotImplementedException();
        }
    }
}
