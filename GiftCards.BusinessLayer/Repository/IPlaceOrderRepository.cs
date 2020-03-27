
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GGiftCards.BusinessLayer.Repository
{
   public interface IPlaceOrderRepository
    {
        Task<Buyer> PlaceOrderAsync(Buyer Buyer);
        Task<IEnumerable<Buyer>> GetAllBuyerAsync();

    }
}
