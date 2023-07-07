using Aula_12_Entity_Framework;
using Aula_12_Entity_Framework.Data.Repositories;
using Aula_12_Entity_Framework.Domain;

class Program
{
    public static void Main(string[] args)
    {
        // Create
        var db = new DataContext();
        var personRepository = new PersonRepository(db);

        // Inserindo Pessoas
        Console.WriteLine($"Inserting a new person");
        var person = new Person() { id = 3, name = "Endriw", address = "Rua tal 3", phone = "(51) 9 9999-9999" };
        personRepository.Save(person);


        // Listando todas as Pessoas registradas
        Console.WriteLine($"Listing people");
        var people = personRepository.GetAll();

        foreach (var item in people)
        {
            Console.WriteLine($"(Id: {item.id} | Nome: {item.name} | Telefone: {item.phone})");
        }


        Console.WriteLine("");


        // Mostrar pessoas pelo Id
        var personFind = personRepository.GetById(1);
        Console.WriteLine($"(Id: {personFind.id} | Nome: {personFind.name} | Telefone: {personFind.phone})");


        Console.WriteLine("");

        // Delete Pessoas pelo Id
        Console.WriteLine("Delete person id: 3");
        personRepository.Delete(3);

        void listPeople()
        {
            var people = personRepository.GetAll();

            foreach (var item in people)
            {
                Console.WriteLine($"(Id: {item.id}) | Nome: {item.name} | Fone: {item.phone}\n");
            }


        }
    }
}