using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DCA_Calculator.Models
{
    public class Transaction
    {
        [Key]
        public string TransactionId { get; set; }

        [DisplayName("Coin quantity")]
        [Range(0, int.MaxValue)]
        public Decimal CoinQuantity { get; set; }

        [DisplayName("Total cost")]
        [Range(0, int.MaxValue)]
        public Decimal TotalCost { get; set; }

        [DisplayName("Date of purchase")]
        public DateTime Date { get; set; }

        [Required]
        public string BagId { get; set; }
        [NotMapped]
        public virtual DCABag DCABag { get; set; }

        [NotMapped]
        public double AvgBuy
        {
            get
            {
                return (double)Math.Round(this.TotalCost / CoinQuantity, 2);
            }
        }

        public Transaction()
        {
            this.TransactionId = Guid.NewGuid().ToString();
            this.Date = DateTime.Now;
        }
    }
}
