using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Domain.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DateCreated { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime DateLastEdited { get; set; }
        
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string CreatedById { get; set; }
        
        [ScaffoldColumn(false)]
        [StringLength(255)]
        public string LastEditedById { get; set; }
        
        [ScaffoldColumn(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
