using InvoicesCreator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain
{
    public class InvoicePosition : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Ilosc")]
        public decimal Quantity { get; set; }

        [Required]
        [Display(Name = "Jednostka Miary")]
        public UnitEnum Unit { get; set; }

        [Required]
        [Display(Name = "Cena Brutto")]
        public decimal BruttoPrice { get; set; }

        [Required]
        [Display(Name = "Cena Netto")]
        public decimal NettoPrice { get; set; }

        [Required]
        [Display(Name = "VAT")]
        public decimal TaxLevel { get; set; }

        [Required]
        [Display(Name = "Wartość Brutto")]
        public decimal TotalBrutto { get; set; }

        [Required]
        [Display(Name = "Wartość Netto")]
        public decimal TotalNetto { get; set; }

        [NotMapped]
        public Invoice Invoice { get; set; }

        //[Required]
        //[Display(Name = "ID Faktury")]
        //public int InvoiceId { get; set; }
    }
}
