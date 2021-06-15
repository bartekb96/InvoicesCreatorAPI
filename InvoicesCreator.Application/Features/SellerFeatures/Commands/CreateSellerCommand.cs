using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Features.SellerFeatures.Commands
{
    public class CreateSellerCommand : IRequest<Seller>
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

        public class CreateSellerCommandHandler : IRequestHandler<CreateSellerCommand, Seller>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public CreateSellerCommandHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Seller> Handle(CreateSellerCommand command, CancellationToken token)
            {
                var seller = new Seller();
                seller.Address = new SellerAddress();

                seller.Email = command.Email;
                seller.FirstName = command.FirstName;
                seller.NIP = command.NIP;
                seller.Phone = command.Phone;
                seller.SecondName = command.SecondName;

                seller.Address.City = command.City;
                seller.Address.Country = command.Country;
                seller.Address.HouseNumber = command.HouseNumber;
                seller.Address.LocalNumber = command.LocalNumber;
                seller.Address.PostCode = command.PostCode;
                seller.Address.Street = command.Street;

                var result = await _invoicesCreatorContext.Sellers.AddAsync(seller);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
