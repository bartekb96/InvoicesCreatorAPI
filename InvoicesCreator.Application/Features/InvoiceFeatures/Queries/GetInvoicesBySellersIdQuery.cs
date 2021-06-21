using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Features.InvoiceFeatures.Queries
{
    public class GetInvoicesBySellersIdQuery : IRequest<IEnumerable<Invoice>>
    {
        public int SellersID { get; set; }
        public class GetInvoiceBySellersIdQueryCommandHandler : IRequestHandler<GetInvoicesBySellersIdQuery, IEnumerable<Invoice>>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public GetInvoiceBySellersIdQueryCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<IEnumerable<Invoice>> Handle(GetInvoicesBySellersIdQuery command, CancellationToken token)
            {
                var invoices = await _invoicesCreatorContext.Invoices
                    .AsNoTracking()
                    .Where(i => i.Seller.Id == command.SellersID)
                    .Include(i => i.Seller)
                    .ThenInclude(i => i.Address)
                    .Include(i => i.Contractor)
                    .ThenInclude(i => i.Address)
                    .Include(i => i.Positions)
                    .ToListAsync();
                
                if (invoices == null)
                {
                    return null;
                }

                return invoices.AsReadOnly();
            }
        }
    }
}
