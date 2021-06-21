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

namespace InvoicesCreator.Application.Features.UserFeatures.Commands
{
    public class CreateNewUserCommand : IRequest<User>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserEnum UserType { get; set; }
        public int SellerID { get; set; }

        public class CreateNewUserCommandHandler : IRequestHandler<CreateNewUserCommand, User>
        {
            private readonly IInvoicesCreatorContext _invoicesCreatorContext;
            private readonly ICrypthography _cryptography;

            public CreateNewUserCommandHandler(IInvoicesCreatorContext invoicesCreatorContext, ICrypthography cryptography)
            {
                _invoicesCreatorContext = invoicesCreatorContext;
                _cryptography = cryptography;
            }

            public async Task<User> Handle(CreateNewUserCommand command, CancellationToken token)
            {
                var user = new User();
                user.UserName = command.UserName;
                user.Email = command.Email;
                user.Password = _cryptography.Encrypt(command.Password); //zahashowane hasło
                user.UserType = command.UserType;

                if (command.SellerID > 0)
                {
                    var seller = await _invoicesCreatorContext.Sellers.FirstOrDefaultAsync(s => s.Id == command.SellerID);

                    if (seller != null)
                    {
                        user.Seller = seller;
                    }
                    else
                        user.SellerID = null;
                }
                else
                    user.SellerID = null;

                var result = await _invoicesCreatorContext.Users.AddAsync(user);
                await _invoicesCreatorContext.SaveChanges();
                return result.Entity;
            }
        }
    }
}
