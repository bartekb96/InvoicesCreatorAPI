using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.DAL.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.DAL.Extentions
{
    public static class DependencyInjection
    {
        public static void AddDAL(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<InvoicesCreatorContext>(options => options.UseSqlServer(configuration.GetConnectionString("InvoicesCreatorConnectionString"),b => b.MigrationsAssembly(typeof(InvoicesCreatorContext).Assembly.FullName)));

            services.AddScoped<IInvoicesCreatorContext>(provider => provider.GetService<InvoicesCreatorContext>());
        }
    }
}
