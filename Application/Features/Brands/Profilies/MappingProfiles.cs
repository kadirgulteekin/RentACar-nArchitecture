using Application.Features.Brands.Commands.Create;
using Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Profilies;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Brand, CreateBrandCommand>().ReverseMap();       
        CreateMap<Brand, CreatedBrandResponse>().ReverseMap();       
    }
}
