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

namespace InvoicesCreator.Application.Features.SellerFeatures.Queries
{
    public class GetSellerByIdQuery : IRequest<Seller>
    {
        public int SellerId { get; set; }

        public class GetSellerByIdQueryHandler : IRequestHandler<GetSellerByIdQuery, Seller>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public GetSellerByIdQueryHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Seller> Handle(GetSellerByIdQuery command, CancellationToken token)
            {
                var seller = await _invoicesCreatorContext.Sellers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == command.SellerId);

                if (seller == null)
                {
                    return null;
                }

                return seller;
            }
        }
    }
}
