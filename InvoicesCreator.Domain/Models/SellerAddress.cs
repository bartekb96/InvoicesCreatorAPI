using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class SellerAddress : BaseAddress
    {
        [NotMapped]
        public Seller Seller { get; set; }


        [Display(Name = "ID Faktury")]
        public int SellerId { get; set; }
    }
}
