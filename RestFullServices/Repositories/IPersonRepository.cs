using Data;
using Domain;

namespace Repositories
{
    public interface IPersonRepository: IRepository<Person>
    {

        Task<ICollection<Person>> GetPersonsByPersonType(int personType);

    }
}

