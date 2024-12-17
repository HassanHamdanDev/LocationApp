using LocationApp.Domain.Entities;
using LocationApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Application.Places
{
    public interface IPlacesService
    {
        Task<List<PlaceDto>> GetPlacesAsync();
        Task<Result> AddPlaceAsync(AddPlaceDto dto);
    }
}
