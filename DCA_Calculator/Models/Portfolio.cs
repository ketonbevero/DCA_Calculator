using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCA_Calculator.Models
{
    public class Portfolio
    {
        [Key]
        public string PortfolioId { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Portfolio name")]
        public string Name { get; set; }

        public virtual ICollection<DCABag> Bags { get; set; }

        public bool Open { get; set; }

        public Portfolio()
        {
            this.PortfolioId = Guid.NewGuid().ToString();
            this.Open = true;
        }
    }
}
