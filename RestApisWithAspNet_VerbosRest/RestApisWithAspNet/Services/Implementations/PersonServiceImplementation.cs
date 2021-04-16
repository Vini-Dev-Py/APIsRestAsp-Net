using RestApisWithAspNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace RestApisWithAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {

        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }

            return people;
        }

        public Person FindByID(long id)
        {
            return new Person
            {
                
            };
        }

        public Person Update(Person person)
        {
            return person;
        }
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrimentAndGet(),
                FirstName = "Vinicius",
                LastName = "Batista",
                Address = "Sumaré - São Paulo - Brasil",
                Gender = "Male"
            };
        }

        private long IncrimentAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
