using AutoMapper;
using InvoicesCreator.Domain.Models;
using InvoicesCreator.RestAPI.Contracts.v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesCreator.RestAPI.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<User, UserResponse>();
            CreateMap<Invoice, InvoiceResponse>();
            CreateMap<Contractor, ContractorResponse>();
            CreateMap<Seller, SellerResponse>();
            CreateMap<SellerAddress, AddressResponse>();
            CreateMap<ContractorAddress, AddressResponse>();
            CreateMap<InvoicePosition, PositionsResponse>();
        }
    }
}
