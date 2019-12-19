using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonSample.Dtos;

namespace PersonSample.Services.Impl
{
    public class PersonApiService : IPersonApiService
    {
        private int id = 1;
        private IList<PersonDto> persons;

        public PersonApiService()
        {
            persons = new List<PersonDto>()
            {
                new PersonDto { Id = id++, FirstName = "Maya", LastName = "Mullen", ImageUrl="https://images.unsplash.com/photo-1549068106-b024baf5062d?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=60" },
                new PersonDto { Id = id++, FirstName = "Sybill", LastName = "Robinson", ImageUrl="https://images.unsplash.com/photo-1544005313-94ddf0286df2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=60" },
                new PersonDto { Id = id++, FirstName = "Tarik", LastName = "Stark", ImageUrl="https://images.unsplash.com/photo-1543852786-1cf6624b9987?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=934&q=80" },
                new PersonDto { Id = id++, FirstName = "Ryder", LastName = "Hester" },
                new PersonDto { Id = id++, FirstName = "Dai", LastName = "Hart" },
                new PersonDto { Id = id++, FirstName = "Noelle", LastName = "Villarreal" },
                new PersonDto { Id = id++, FirstName = "Hanna", LastName = "Shannon" },
                new PersonDto { Id = id++, FirstName = "Tyrone", LastName = "Stevens" },
                new PersonDto { Id = id++, FirstName = "Lacota", LastName = "Mays" },
                new PersonDto { Id = id++, FirstName = "Byron", LastName = "Stewart" }
            };
        }

        public Task<IEnumerable<PersonDto>> GetAll()
            => Task.FromResult(persons.AsEnumerable());

        public Task<PersonDto> GetById(int id)
            => Task.FromResult(persons.Where(p => p.Id == id).FirstOrDefault());

        public Task Save(PersonDto dto)
        {
            int index = persons.IndexOf(dto);
            if (index != -1)
            {
                persons[index] = dto;
            }
            else
            {
                dto.Id = id++;
                persons.Add(dto);
            }

            return Task.CompletedTask;
        }
    }
}
