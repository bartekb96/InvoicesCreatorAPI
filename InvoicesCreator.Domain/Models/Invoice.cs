using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain
{
    public class Invoice : BaseEntity
    {
        [Required]
        [JsonIgnore]
        [Display(Name = "Sprzedawca")]
        public Seller Seller { get; set; }

        [Required]
        [Display(Name = "Id Sprzedawcy")]
        public int SellerID { get; set; }

        [Required]
        [JsonIgnore]
        [Display(Name = "Nabywca")]
        public Contractor Contractor { get; set; }

        [Required]
        [Display(Name = "Id Nabywcy")]
        public int ContractorID { get; set; }

        [Required]
        [Display(Name = "Pozycje")]
        public List<InvoicePosition> Positions { get; set; }

        [Required]
        [Display(Name = "Wartosc Brutto")]
        public decimal TotalBrutto { get; set; }

        [Required]
        [Display(Name = "Wartosc Netto")]
        public decimal TotalNetto { get; set; }
    }
}
