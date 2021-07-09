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
    public class GetInvoiceByIdQuery : IRequest<Invoice>
    {
        public int InvoiceId { get; set; }
        public class GetInvoiceByIdQueryCommandHandler : IRequestHandler<GetInvoiceByIdQuery, Invoice>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public GetInvoiceByIdQueryCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Invoice> Handle(GetInvoiceByIdQuery command, CancellationToken token)
            {
                var invoice = await _invoicesCreatorContext.Invoices.AsNoTracking().Where(i => i.Id == command.InvoiceId)
                    .Include(i => i.Seller).ThenInclude(s => s.Address)
                    .Include(i => i.Contractor).ThenInclude(c => c.Address)
                    .Include(i => i.Positions)
                    .FirstOrDefaultAsync();

                if(invoice == null)
                {
                    return null;
                }

                return invoice;
            }
        }
    }
}
