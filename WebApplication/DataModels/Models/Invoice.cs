using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DataModels.Enums;

namespace WebApplication.DataModels.Models
{
    public class Invoice
    {
        public int UserID { get; set; }

        public InvoiceTypeEnum InvoiceType { get; set; }

        public Contractor Contractor { get; set; }

        public List<Position> Positions { get; set; }
    }
}
