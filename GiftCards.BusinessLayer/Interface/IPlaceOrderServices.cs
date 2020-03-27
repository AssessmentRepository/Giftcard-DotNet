
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiftCards.BusinessLayer.Interface
{
   public interface IPlaceOrderServices
    {
        Task<Buyer> PlaceOrderAsync(Buyer Buyer);
        Task<IEnumerable<Buyer>> GetAllBuyerAsync();
    }
}
