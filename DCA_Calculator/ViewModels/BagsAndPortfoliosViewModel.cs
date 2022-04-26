using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCA_Calculator.Models
{
    public class BagsAndPortfoliosViewModel
    {
        [Display(Name = "Portfolio name")]
        public string SelectedPortfolioId { get; set; }

        public string SelectedBagId { get; set; }

        public IEnumerable<DCABag> Bags { get; set; }

        public IEnumerable<SelectListItem> PortfolioNames { get; set; }
    }
}
