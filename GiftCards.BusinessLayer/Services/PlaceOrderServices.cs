using GGiftCards.BusinessLayer.Repository;
using GiftCards.BusinessLayer.Interface;
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiftCards.BusinessLayer.Services
{
    public class PlaceOrderServices : IPlaceOrderServices
    {
        private readonly IPlaceOrderRepository _PlaceOrderRepository;
        //  private readonly MockContext _context;


        public PlaceOrderServices(IPlaceOrderRepository PlaceOrderRepository)
        {

            _PlaceOrderRepository = PlaceOrderRepository;

        }

        public async Task<IEnumerable<Buyer>> GetAllBuyerAsync()
        {
            try
            {
                var buyer = await _PlaceOrderRepository.GetAllBuyerAsync();
                return buyer;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Buyer> PlaceOrderAsync(Buyer buyer)
        {
            {
                try
                {

                    var Buyer = await _PlaceOrderRepository.PlaceOrderAsync(buyer);
                    return Buyer;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
            }
        }
    }
}
