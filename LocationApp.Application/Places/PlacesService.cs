using AutoMapper;
using LocationApp.Domain.Entities;
using LocationApp.Infrastructure.Repositories;
using LocationApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Application.Places
{
    public class PlacesService : IPlacesService
    {
        private readonly IPlaceRepository _placeRepository;
        private readonly IMapper _mapper;

        public PlacesService(IPlaceRepository placeRepository, IMapper mapper)
        {
            _placeRepository = placeRepository;
            _mapper = mapper;
        }
        public async Task<Result> AddPlaceAsync(AddPlaceDto dto)
        {
            var validator = dto.IsValid();
            if (!validator.IsSuccess)
            {
                return validator;
            }

            var newPlace = _mapper.Map<Place>(dto);
            await _placeRepository.InsertAsync(newPlace);

            return Functional.Success();
        }

        public async Task<List<PlaceDto>> GetPlacesAsync()
        {
            List<Place> places = await _placeRepository.GetAllListAsync();

            var dto = _mapper.Map<List<PlaceDto>>(places);

            return dto;
        }
    }
}
