using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Features.ContractorFeatures.Commands
{
    public class CreateContractorCommand : IRequest<Contractor>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string NIP { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string LocalNumber { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public class CreateContractorCommandHandler : IRequestHandler<CreateContractorCommand, Contractor>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public CreateContractorCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Contractor> Handle(CreateContractorCommand command, CancellationToken token)
            {
                var contractor = new Contractor();
                contractor.Address = new ContractorAddress();

                contractor.Email = command.Email;
                contractor.FirstName = command.FirstName;
                contractor.NIP = command.NIP;
                contractor.Phone = command.Phone;
                contractor.SecondName = command.SecondName;

                contractor.Address.City = command.City;
                contractor.Address.Country = command.Country;
                contractor.Address.HouseNumber = command.HouseNumber;
                contractor.Address.LocalNumber = command.LocalNumber;
                contractor.Address.PostCode = command.PostCode;
                contractor.Address.Street = command.Street;

                var result = await _invoicesCreatorContext.Contractors.AddAsync(contractor);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
