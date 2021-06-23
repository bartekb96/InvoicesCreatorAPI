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
    public class UserLogInQuery : IRequest<User>
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public class UserLogInQueryHandler : IRequestHandler<UserLogInQuery, User>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;

            private readonly ICrypthography _cryptography;

            public UserLogInQueryHandler(IInvoicesCreatorContext invoicesCreatorContext, ICrypthography cryptography)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
                _cryptography = cryptography;
            }

            public async Task<User> Handle(UserLogInQuery command, CancellationToken token)
            {
                string encryptedPassword = _cryptography.Encrypt(command.Password);

                var user = await _invoicesCreatorContext.Users.AsNoTracking().FirstOrDefaultAsync(c => c.UserName == command.UserName && c.Password == encryptedPassword);

                if (user == null)
                {
                    return null;
                }

                return user;              
            }
        }
    }
}
