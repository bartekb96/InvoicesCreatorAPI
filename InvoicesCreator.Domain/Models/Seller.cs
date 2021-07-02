using InvoicesCreator.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class Seller : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Imie")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Nazwisko")]
        public string SecondName { get; set; }

        [Required]
        [StringLength(32)]
        [Display(Name = "NIP")]
        public string NIP { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(32)]
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        [NotMapped]
        public List<Invoice> Invoices { get; set; }

        [Required]
        public SellerAddress Address { get; set; }

        [NotMapped]
        public User User { get; set; }
    }
}
