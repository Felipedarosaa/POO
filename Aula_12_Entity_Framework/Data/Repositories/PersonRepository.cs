using Aula_12_Entity_Framework.Domain;
using Aula_12_Entity_Framework.Domain.Interfaces;
using Aula_12_Entity_Framework.Interfaces;

namespace Aula_12_Entity_Framework.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext context;
        public PersonRepository(DataContext context)
        {
            this.context = context;
        }

        // ----------------------------- //

        public IList<Person> GetAll()
        {
            return context.People.ToList();
        }

        public void Save(Person entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public bool Delete(int entityId)
        {
            var person = GetById(entityId);
            context.Remove(person);
            return true;
        }

        public Person GetById(int entityId)
        {
            return context.People.SingleOrDefault(x => x.id == entityId);
        }

        public void Update(Person entity)
        {
            throw new NotImplementedException();
        }

        Person IBaseRepository<Person>.GetById(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}