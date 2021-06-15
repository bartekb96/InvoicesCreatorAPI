using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain;
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
    public class DeleteInvoiceCommand : IRequest<Invoice>
    {
        public int InvoiceId { get; set; }
        public class DeleteInvoiceCommandHandler : IRequestHandler<DeleteInvoiceCommand, Invoice>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;
            public DeleteInvoiceCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Invoice> Handle(DeleteInvoiceCommand command, CancellationToken token)
            {
                var invoiceToDelete = await _invoicesCreatorContext.Invoices.FirstOrDefaultAsync(i => i.Id == command.InvoiceId); //sprawdzić czy filtr z false tu działa
                if(invoiceToDelete == null)
                {
                    return default;
                }

                _invoicesCreatorContext.Invoices.Remove(invoiceToDelete);
                await _invoicesCreatorContext.SaveChanges();
                return invoiceToDelete;
            }
        }
    }
}
