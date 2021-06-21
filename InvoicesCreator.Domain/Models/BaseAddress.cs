using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class BaseAddress : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Ulica")]
        public string Street { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Numer Domu")]
        public string HouseNumber { get; set; }

        [StringLength(255)]
        [Display(Name = "Numer Lokalu")]
        public string LocalNumber { get; set; }

        [Required]
        [StringLength(16)]
        [Display(Name = "Kod Pocztowy")]
        public string PostCode { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Miasto")]
        public string City { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Kraj")]
        public string Country { get; set; }
    }
}
