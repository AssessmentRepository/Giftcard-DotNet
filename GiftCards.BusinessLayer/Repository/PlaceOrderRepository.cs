using Dapper;
using GGiftCards.BusinessLayer.Repository;
using GiftCards.DataLayer;
using GiftCards.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GiftCards.BusinessLayer.Repository
{
    public class PlaceOrderRepository : IPlaceOrderRepository
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public PlaceOrderRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;

        }

        public async Task<IEnumerable<Buyer>> GetAllBuyerAsync()
        {
            try
            {
                var connection = await _dbConnectionFactory.CreateConnectionAsync();
                return await connection.QueryAsync<Buyer>("select * from Buyer");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public async Task<Buyer> PlaceOrderAsync(Buyer Buyer)
        {
            try
            {

                var connection = await _dbConnectionFactory.CreateConnectionAsync();
                //await _dbConnectionFactory.SetupAsync();
                await connection.ExecuteAsync("Insert into Buyer (Id, FirstName, LastName, phoneNumber, Email, Address) VALUES (@id, @firstName,@lastName,@phoneNumber,@email,@address)", new { id = Buyer.Id, firstName = Buyer.FirstName, lastName = Buyer.LastName, phoneNumber = Buyer.PhoneNumber, email = Buyer.Email, address = Buyer.Address});
                return Buyer;
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
