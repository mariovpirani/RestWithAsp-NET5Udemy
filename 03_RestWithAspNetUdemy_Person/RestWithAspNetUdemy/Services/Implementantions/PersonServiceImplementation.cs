using RestWithAspNetUdemy.Model;

namespace RestWithAspNetUdemy.Services.Implementantions
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }


        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }
        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Mario",
                LastName = "Veiga",
                Address = "Endereço",
                Gender = "Male"
            };
        }

        public Person FindByName(string name)
        {
            throw new NotImplementedException();
        }
        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Mario",
                LastName = "Veiga",
                Address = "Endereço",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Person FindByID(long id)
        {
            throw new NotImplementedException();
        }
    }
}
