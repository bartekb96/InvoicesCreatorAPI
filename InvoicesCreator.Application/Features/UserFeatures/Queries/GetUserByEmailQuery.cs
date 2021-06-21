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

namespace InvoicesCreator.Application.Features.UserFeatures.Queries
{
    public class GetUserByEmailQuery : IRequest<User>
    {
        public string UserEmail { get; set; }

        public class GetUserByEmailQueryHandler : IRequestHandler<GetUserByEmailQuery, User>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext; 

            public GetUserByEmailQueryHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<User> Handle(GetUserByEmailQuery command, CancellationToken token)
            {
                var user = await _invoicesCreatorContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Email == command.UserEmail);

                if (user == null)
                {
                    return null;
                }

                return user;
            }
        }
    }
}
