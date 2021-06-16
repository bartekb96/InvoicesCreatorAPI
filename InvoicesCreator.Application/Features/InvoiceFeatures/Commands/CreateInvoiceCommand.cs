using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain;
using InvoicesCreator.Domain.Enums;
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
    public class CreateInvoiceCommand : IRequest<Invoice>
    {
        public int SellerID { get; set; }
        public int ContractorID { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public decimal TotalBrutto { get; set; }
        public decimal TotalNetto { get; set; }

        public class Position
        {
            public string Name { get; set; }
            public decimal Quantity { get; set; }
            public int Unit { get; set; }
            public decimal BruttoPrice { get; set; }
            public decimal NettoPrice { get; set; }
            public decimal TaxLevel { get; set; }
            public decimal TotalBrutto { get; set; }
            public decimal TotalNetto { get; set; }
        }

        public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, Invoice>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public CreateInvoiceCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Invoice> Handle(CreateInvoiceCommand command, CancellationToken token)
            {
                Invoice invoiceToAdd = new Invoice();
                invoiceToAdd.Seller = await _invoicesCreatorContext.Sellers.FirstOrDefaultAsync(s => s.Id == command.SellerID);
                invoiceToAdd.Contractor = await _invoicesCreatorContext.Contractors.FirstOrDefaultAsync(c => c.Id == command.ContractorID);

                invoiceToAdd.Positions = new List<InvoicePosition>();
                foreach (var position in command.Positions)
                {
                    invoiceToAdd.Positions.Add(new InvoicePosition{
                        Name = position.Name,
                        Quantity = position.Quantity,
                        Unit = (UnitEnum)position.Unit,
                        BruttoPrice = position.BruttoPrice,
                        NettoPrice = position.NettoPrice,
                        TaxLevel = position.TaxLevel,
                        TotalBrutto = position.TotalBrutto,
                        TotalNetto = position.TotalNetto
                    });
                }

                invoiceToAdd.TotalBrutto = command.TotalBrutto;
                invoiceToAdd.TotalNetto = command.TotalNetto;

                var result = await _invoicesCreatorContext.Invoices.AddAsync(invoiceToAdd);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
