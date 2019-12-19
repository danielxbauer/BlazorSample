using System.Collections.Generic;
using System.Threading.Tasks;
using PersonSample.Dtos;

namespace PersonSample.Services
{
    public interface IPersonApiService
    {
        Task<IEnumerable<PersonDto>> GetAll();
        Task<PersonDto> GetById(int id);
        Task Save(PersonDto dto);
    }
}
