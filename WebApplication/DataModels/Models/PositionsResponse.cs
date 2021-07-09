using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.DataModels.Models
{
    public class PositionsResponse
    {
        public string Name { get; set; }

        public decimal Quantity { get; set; }

        public string Unit { get; set; }

        public decimal BruttoPrice { get; set; }

        public decimal NettoPrice { get; set; }

        public decimal TaxLevel { get; set; }

        public decimal TotalBrutto { get; set; }

        public decimal TotalNetto { get; set; }
    }
}
