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

namespace InvoicesCreator.Application.Features.InvoiceFeatures.Commands
{
    public class UpdateInvoiceCommand : IRequest<Invoice>
    {
        public Invoice Invoice { get; set; }
        public class UpdateInvoiceCommandHandler : IRequestHandler<UpdateInvoiceCommand, Invoice>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public UpdateInvoiceCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Invoice> Handle(UpdateInvoiceCommand command, CancellationToken token)
            {
                var invoiceToUpdate = await _invoicesCreatorContext.Invoices.FirstOrDefaultAsync(i => i.Id == command.Invoice.Id);
                if(invoiceToUpdate == null)
                {
                    return default;
                }
                else
                {
                    invoiceToUpdate.Positions = command.Invoice.Positions;
                    invoiceToUpdate.Seller = command.Invoice.Seller;
                    invoiceToUpdate.TotalBrutto = command.Invoice.TotalBrutto;
                    invoiceToUpdate.TotalNetto = command.Invoice.TotalNetto;
                    invoiceToUpdate.Contractor = command.Invoice.Contractor;
                    
                    await _invoicesCreatorContext.SaveChanges();
                    return invoiceToUpdate;
                }
            }
        }
    }
}
