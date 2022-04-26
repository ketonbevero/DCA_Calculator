using BLL.Interfaces;
using DCA_Calculator.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace DCA_Calculator.Controllers
{
    public class HomeController : Controller
    {
        private IBagLogic bagLogic;
        private IPortfolioLogic portfolioLogic;
        private ITransactionLogic transactionLogic;

        public HomeController(IBagLogic bagLogic, IPortfolioLogic portfolioLogic, ITransactionLogic transactionLogic)
        {
            this.bagLogic = bagLogic;
            this.portfolioLogic = portfolioLogic;
            this.transactionLogic = transactionLogic;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddDCA()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddDCA(DCABag bag)
        {
            if (!ModelState.IsValid)
            {
                return View(bag);
            }

            this.bagLogic.Create(bag);
            return RedirectToAction(nameof(ListBags));
        }

        public IActionResult EditBag(string uid)
        {
            var bagToUpdate = this.bagLogic.GetOne(uid);

            return View(bagToUpdate);
        }

        [HttpPost]
        public IActionResult EditBag(DCABag bag)
        {
            if (!ModelState.IsValid)
            {
                return View(bag);
            }
            else
            {
                this.bagLogic.Update(bag.BagId, bag.Name);
                return RedirectToAction(nameof(ListBags));
            }
        }

        public IActionResult CloseBag(string uid)
        {
            var bag = this.bagLogic.GetOne(uid);
            bool result = this.transactionLogic.DeleteSelectedBagTransactions(uid);
            if (result)
            {
                this.bagLogic.Delete(uid);
            }

            return RedirectToAction("ListBags");
        }

        public IActionResult ShowBag(string uid)
        {
            var bag = this.bagLogic.GetOne(uid);

            ViewData["selectedBag"] = bag;
            ViewData["avgBuy"] = JsonConvert.SerializeObject(bag.Transactions.OrderByDescending(y => y.Date).Select(x => (int)x.AvgBuy).ToArray());
            ViewData["tCount"] = JsonConvert.SerializeObject(Enumerable.Range(1, bag.Transactions.Count).ToArray());
            
            return View("CreateTransaction");
        }

        [HttpPost]
        public IActionResult AddTransactionToBag(Transaction transaction)
        {
            if (!ModelState.IsValid)
            {
                return View("ListBags");
            }

            string bagId = transaction.BagId;

            this.transactionLogic.Create(transaction);
            var bag = this.bagLogic.GetOne(bagId);
            bag.Transactions.Add(transaction);
            this.bagLogic.Update(bagId, bag);

            return RedirectToAction("ShowBag", "Home", new { uid = bagId });
        }

        //[Authorize]
        public IActionResult ListBags()
        {
            var portfolios = this.portfolioLogic.GetAll()?.Select(y => new SelectListItem { Value = y.PortfolioId, Text = y.Name });

            var model = new BagsAndPortfoliosViewModel
            {
                Bags = this.bagLogic.GetAll(),
                PortfolioNames = new SelectList(portfolios, "Value", "Text")
            };

            ModelState.Remove("SelectedBagId");

            return View(model);
        }


        [HttpGet]
        public IActionResult AddPortfolio()
        {
            ViewData["allPortfolios"] = this.portfolioLogic.GetAll();
            
            return View("ShowPortfolios");
        }


        [HttpPost]
        public IActionResult AddPortfolio(Portfolio portfolio)
        {
            if (!ModelState.IsValid)
            {
                return View(portfolio);
            }

            this.portfolioLogic.Create(portfolio);

            return RedirectToAction(nameof(AddPortfolio));
        }

        public IActionResult DeletePortfolio(string uid)
        {
            var portfolio = this.portfolioLogic.GetOne(uid);
            if (portfolio != null)
            {
                var bagsIncluded = this.bagLogic.GetAll().Where(x => x.PortfolioId == uid);
                if (bagsIncluded != null && bagsIncluded.Count() > 0)
                {
                    foreach (var includedBag in bagsIncluded)
                    {
                        this.bagLogic.DeletePortfolioFromBag(includedBag.BagId);
                    }
                }

                this.portfolioLogic.Delete(uid);
            }

            return RedirectToAction(nameof(AddPortfolio));
        }

        [HttpPost]
        public IActionResult AddBagToPortfolio(BagsAndPortfoliosViewModel BagportfolioVM)
        {
            if (!ModelState.IsValid)
            {
                return View("ListBags"); 
            }

            
            string bagId = BagportfolioVM.SelectedBagId;
            string portfolioId = BagportfolioVM.SelectedPortfolioId;

            var portfolio = this.portfolioLogic.GetOne(portfolioId);
            var bag = this.bagLogic.GetOne(bagId);

            portfolio.Bags.Add(bag);
            this.portfolioLogic.Update(portfolioId, portfolio);

            bag.PortfolioId = portfolioId;
            this.bagLogic.Update(bag.BagId, bag);
            
            return RedirectToAction(nameof(ListBags));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
