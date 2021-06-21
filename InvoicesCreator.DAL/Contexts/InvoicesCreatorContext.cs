using InvoicesCreator.Application.Interfaces;
using InvoicesCreator.Domain;
using InvoicesCreator.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesCreator.DAL.Contexts
{
    public partial class InvoicesCreatorContext : DbContext, IInvoicesCreatorContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InvoicesCreatorContext(DbContextOptions<InvoicesCreatorContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Invoice>().HasOne(i => i.Contractor).WithOne(c => c.Invoice).HasForeignKey<Contractor>(c => c.InvoiceId);
            //modelBuilder.Entity<Invoice>().HasOne(i => i.Seller).WithOne(s => s.Invoice).HasForeignKey<Seller>(s => s.InvoiceId);

            modelBuilder.Entity<Seller>().HasOne(i => i.Invoice).WithOne(s => s.Seller).HasForeignKey<Invoice>(s => s.SellerID);
            modelBuilder.Entity<Contractor>().HasOne(i => i.Invoice).WithOne(s => s.Contractor).HasForeignKey<Invoice>(s => s.ContractorID);
            
            modelBuilder.Entity<Seller>().HasOne(s => s.User).WithOne(u => u.Seller).HasForeignKey<User>(u => u.SellerID);

            modelBuilder.Entity<Contractor>().HasOne(c => c.Address).WithOne(a => a.Contractor).HasForeignKey<ContractorAddress>(a => a.ContractorId).OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<Seller>().HasOne(c => c.Address).WithOne(a => a.Seller).HasForeignKey<SellerAddress>(a => a.SellerId).OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<InvoicePosition>().HasOne(p => p.Invoice).WithMany(i => i.Positions).OnDelete(DeleteBehavior.ClientCascade);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ContractorAddress> ContractorAddresses { get; set; }
        public DbSet<SellerAddress> SellerAddresses { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<InvoicePosition> InvoicePositions { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }

        public async Task<int> SaveChanges()
        {
            OnBeforeSaving();
            return await base.SaveChangesAsync();
        }
    }
}
