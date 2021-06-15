using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Features.InvoiceFeatures.Commands
{
    public class CreateInvoiceCommand : IRequest<Invoice>
    {
        public Invoice Invoice { get; set; }
        public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, Invoice>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public CreateInvoiceCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Invoice> Handle(CreateInvoiceCommand command, CancellationToken token)
            {
                var result = await _invoicesCreatorContext.Invoices.AddAsync(command.Invoice);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
