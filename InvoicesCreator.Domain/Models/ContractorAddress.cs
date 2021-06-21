using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class ContractorAddress : BaseAddress
    {
        [NotMapped]
        public Contractor Contractor { get; set; }

        [Display(Name = "ID Konrtahenta")]
        public int ContractorId { get; set; }
    }
}
