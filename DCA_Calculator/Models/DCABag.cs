using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DCA_Calculator.Models
{
    public enum Fiat
    {
        HUF,
        Dollar,
        Euro
    }

    public class DCABag
    {
        [Key]
        public string BagId { get; set; }

        [DisplayName("Name of the DCA bag")]
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        [DisplayName("Coin")]
        [StringLength(10)]
        public string CryptoCoin { get; set; }

        [DisplayName("FIAT")]
        public Fiat FIAT { get; set; }

        public virtual string PortfolioId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }

        public DCABag()
        {
            this.BagId = Guid.NewGuid().ToString();
        }
    }
}
