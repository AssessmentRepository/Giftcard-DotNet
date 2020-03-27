using GiftCards.DataLayer;
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiftCards.BusinessLayer.Repository
{
    public class ViewOrderRepository : IViewOrderRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public ViewOrderRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }
        public Task<Buyer> ViewGiftCard()
        {
            throw new NotImplementedException();

        }
    }
}
