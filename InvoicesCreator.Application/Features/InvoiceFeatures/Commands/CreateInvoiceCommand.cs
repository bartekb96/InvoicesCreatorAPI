using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain.Enums;
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
    public class CreateInvoiceCommand : IRequest<Invoice>
    {
        public int UserId { get; set; }
        public ContractorData Contractor { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public InvoiceTypeEnum InvoiceType { get; set; }

        public class Position
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

        public class ContractorData
        {
            public string FirstName { get; set; }

            public string SecondName { get; set; }

            public string CompanyName { get; set; }

            public string NIP { get; set; }

            public string Email { get; set; }

            public string Phone { get; set; }

            public Address Address { get; set; }
        }

        public class Address
        {
            public string Street { get; set; }

            public string HouseNumber { get; set; }

            public string LocalNumber { get; set; }

            public string PostCode { get; set; }

            public string City { get; set; }

            public string Country { get; set; }
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
                var user = await _invoicesCreatorContext.Users.FirstOrDefaultAsync(u => u.Id == command.UserId);

                if(user == null)
                {
                    return null;
                }

                var seller = await _invoicesCreatorContext.Sellers.FirstOrDefaultAsync(s => s.Id == user.SellerID);
                invoiceToAdd.SellerID = seller.Id;

                Domain.Models.ContractorAddress contractorAddress = new ContractorAddress{
                    Street = command.Contractor.Address.Street,
                    HouseNumber = command.Contractor.Address.HouseNumber,
                    LocalNumber = command.Contractor.Address.LocalNumber,
                    PostCode = command.Contractor.Address.PostCode,
                    City = command.Contractor.Address.City,
                    Country = command.Contractor.Address.Country
                };

                invoiceToAdd.Contractor = new Domain.Models.Contractor{
                    FirstName = command.Contractor.FirstName,
                    SecondName = command.Contractor.SecondName,
                    NIP = command.Contractor.NIP,
                    Email = command.Contractor.Email,
                    Phone = command.Contractor.Phone,
                    Address = contractorAddress
                };

                invoiceToAdd.Positions = new List<InvoicePosition>();
                foreach (var position in command.Positions)
                {
                    invoiceToAdd.Positions.Add(new InvoicePosition{
                        Name = position.Name,
                        Quantity = position.Quantity,
                        Unit = position.Unit,
                        BruttoPrice = position.BruttoPrice,
                        NettoPrice = position.NettoPrice,
                        TaxLevel = position.TaxLevel,
                        TotalBrutto = position.Quantity * position.BruttoPrice,
                        TotalNetto = position.Quantity *  position.NettoPrice
                    });
                }

                invoiceToAdd.TotalBrutto = invoiceToAdd.Positions.Sum(p => p.TotalBrutto);
                invoiceToAdd.TotalNetto = invoiceToAdd.Positions.Sum(p => p.TotalNetto);
                invoiceToAdd.Type = command.InvoiceType;

                var now = DateTime.Now;
                var StartDate = new DateTime(now.Year, now.Month, 1);
                int currentPeriodInvoicesCount = 0;
                string invoiceNumber = "";

                switch (invoiceToAdd.Type)
                {
                    case InvoiceTypeEnum.Zaliczkowa:
                        currentPeriodInvoicesCount = _invoicesCreatorContext.Invoices.Where(i => i.Type == InvoiceTypeEnum.Zaliczkowa && i.DateCreated >= StartDate).ToList().Count();
                        invoiceNumber = $"FZ/{currentPeriodInvoicesCount + 1}/{now.Month}/{now.Year}";
                        break;
                    case InvoiceTypeEnum.Koncowa:
                        currentPeriodInvoicesCount = _invoicesCreatorContext.Invoices.Where(i => i.Type == InvoiceTypeEnum.Koncowa && i.DateCreated >= StartDate).ToList().Count();
                        invoiceNumber = $"FZ/{currentPeriodInvoicesCount + 1}/{now.Month}/{now.Year}";
                        break;
                }

                invoiceToAdd.InvoiceNumber = invoiceNumber;

                var result = await _invoicesCreatorContext.Invoices.AddAsync(invoiceToAdd);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
