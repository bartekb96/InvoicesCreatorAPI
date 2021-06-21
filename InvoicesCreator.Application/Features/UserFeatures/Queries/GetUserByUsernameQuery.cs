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
    public class GetUserByUsernameQuery : IRequest<User>
    {
        public string UserName { get; set; }

        public class GetUserByUsernameQueryHandler : IRequestHandler<GetUserByUsernameQuery, User>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            public GetUserByUsernameQueryHandler(IInvoicesCreatorContext invoicesCreatorContext)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
            }

            public async Task<User> Handle(GetUserByUsernameQuery command, CancellationToken token)
            {
                var user = await _invoicesCreatorContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.UserName == command.UserName);

                if (user == null)
                {
                    return null;
                }

                return user;
            }
        }
    }
}
