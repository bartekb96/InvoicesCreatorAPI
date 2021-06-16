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

namespace InvoicesCreator.Application.Features.ContractorFeatures.Queries
{
    public class GetContractorByIdQuery : IRequest<Contractor>
    {
        public int ContractorId { get; set; }

        public class GetContractorByIdQueryHandler : IRequestHandler<GetContractorByIdQuery, Contractor>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public GetContractorByIdQueryHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<Contractor> Handle(GetContractorByIdQuery command, CancellationToken token)
            {
                var contractor = await _invoicesCreatorContext.Contractors.FirstOrDefaultAsync(c => c.Id == command.ContractorId);

                if (contractor == null)
                {
                    return null;
                }

                return contractor;
            }
        }
    }
}
