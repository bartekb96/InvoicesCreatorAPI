using InvoicesCreator.Domain;
using InvoicesCreator.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.Application.Interfaces
{
    public interface IInvoicesCreatorContext
    {
        DbSet<ContractorAddress> ContractorAddresses { get; set; }
        DbSet<SellerAddress> SellerAddresses { get; set; }
        DbSet<Seller> Sellers { get; set; }
        DbSet<Contractor> Contractors { get; set; }
        DbSet<InvoicePosition> InvoicePositions { get; set; }
        DbSet<Invoice> Invoices { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChanges();
    }
}
