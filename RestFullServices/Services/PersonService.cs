using Domain;
using Repositories;

namespace Services
{
    public class PersonService : Service<Person>, IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository personRepository) : base(personRepository)
        {
            this.personRepository = personRepository;
        }

        public async Task<ICollection<Person>> GetPersonsByPersonType(int personType)
        {
            try
            {
                var result = await personRepository.GetPersonsByPersonType(personType);
                return result;
            }
            catch
            {
                throw;
            }
        }

    }
}
