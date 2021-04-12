using DotNetNote.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNote.Angular.Controllers
{
    public class BuyerTestController : Controller
    {
        private IBuyerRepository _buyerRepository;

        public BuyerTestController(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }
        public IActionResult Index()
        {
            var buyers = _buyerRepository.GetBuyers();
            return View(buyers);
        }

        public IActionResult Details(string buyerId)
        {
            var buyer = _buyerRepository.GetBuyer(buyerId);
            return View(buyer);
        }
    }
}
