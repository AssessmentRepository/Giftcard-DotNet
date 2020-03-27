using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GiftCards.BusinessLayer.Interface;
using GiftCards.Entities;
using Microsoft.AspNetCore.Mvc;

namespace GiftCards.Controllers
{
    public class PlaceOrderController : Controller
    {
        public readonly IPlaceOrderServices _service;

        public PlaceOrderController(IPlaceOrderServices service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult PlaceOrder()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]


        public async Task<IActionResult> PlaceOrder(Buyer Buyer)
        {
            try
            {
                // TODO: Add insert logic here
                await _service.PlaceOrderAsync(Buyer);
                return RedirectToAction(nameof(AllBuyer));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> AllBuyer()
        {

            var Buyer = await _service.GetAllBuyerAsync();
            return View(Buyer);
        }
    }
}