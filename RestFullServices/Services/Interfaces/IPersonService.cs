using Domain;

namespace Services
{
    public interface IPersonService : IService<Person>
    {
        Task<ICollection<Person>> GetPersonsByPersonType(int personType);
    }
}