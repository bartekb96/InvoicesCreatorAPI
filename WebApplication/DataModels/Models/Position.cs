using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public class Position
    {
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public string Unit { get; set; }

        public decimal BruttoPrice { get; set; }

        public decimal NettoPrice { get; set; }

        public decimal TaxLevel { get; set; }
    }
}
