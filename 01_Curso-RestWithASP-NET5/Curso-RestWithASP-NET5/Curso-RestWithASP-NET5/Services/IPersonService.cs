using Curso_RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace Curso_RestWithASP_NET5.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindByIs(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

    }
}
