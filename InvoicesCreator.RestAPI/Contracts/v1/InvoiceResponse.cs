using InvoicesCreator.Domain.Enums;
using InvoicesCreator.RestAPI.Controllers.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestAPI.Contracts.v1
{
    public class InvoiceResponse
    {
        public string InvoiceNumber { get; set; }

        public SellerResponse Seller { get; set; }

        public ContractorResponse Contractor { get; set; }

        public List<PositionsResponse> Positions { get; set; }

        public decimal TotalBrutto { get; set; }

        public decimal TotalNetto { get; set; }

        public InvoiceTypeEnum Type { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
