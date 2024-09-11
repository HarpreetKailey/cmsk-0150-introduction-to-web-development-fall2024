using Domain;
using Microsoft.EntityFrameworkCore;
using Repositories;

namespace Data
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        private readonly ApiDataContext apiDataContext;

        public PersonRepository(ApiDataContext apiDataContext) : base(apiDataContext)
        {
            this.apiDataContext = apiDataContext;
        }

        public async Task<ICollection<Person>> GetPersonsByPersonType(int personType)
        {
            return await apiDataContext.Persons.Where(x => x.PersonTypeId == personType).ToListAsync();

        }

    }
}

