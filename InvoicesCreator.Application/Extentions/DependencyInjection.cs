using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Application.Tools;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Extentions
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddSingleton<ICrypthography, CryptographyTool>();
        }
    }
}
