using InvoicesCreator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class User : BaseEntity
    {
        [Required]
        [StringLength(255)]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Typ Użytkowika")]
        public UserEnum UserType { get; set; }

        [Display(Name = "ID Sprzedawcy")]
        public int? SellerID { get; set; }

        [JsonIgnore]
        [Display(Name = "Sprzedawca")]
        public Seller Seller { get; set; }
    }
}
