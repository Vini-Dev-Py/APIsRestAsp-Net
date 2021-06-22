using System.Collections.Generic;
using RestApisWithAspNet.Model;

namespace RestApisWithAspNet.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);

        Person FindByID(long id);

        List<Person> FindAll();

        Person Update(Person person);

        void Delete(long id);

        bool Exists(long id);
    }
}
