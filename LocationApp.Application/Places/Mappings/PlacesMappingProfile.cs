using AutoMapper;
using LocationApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Application.Places.Mappings
{
    public class PlacesMappingProfile : Profile
    {
        public PlacesMappingProfile()
        {
            //CreateMap<Place, PlaceDto>().ReverseMap();
            //CreateMap<Place, AddPlaceDto>().ReverseMap();

            CreateMap<PlaceDto, Place>().ReverseMap();
            CreateMap<AddPlaceDto, Place>().ReverseMap();
        }
    }
}
