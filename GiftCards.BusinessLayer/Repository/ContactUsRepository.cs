using GiftCards.DataLayer;
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace GiftCards.BusinessLayer.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public ContactUsRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }
        public Task<ContactUs> ContactUs()
        {
            throw new NotImplementedException();
        }
    }
}
