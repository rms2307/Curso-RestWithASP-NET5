using Curso_RestWithASP_NET5.Data.Converter.Contract;
using Curso_RestWithASP_NET5.Data.VO;
using Curso_RestWithASP_NET5.Model;
using System.Collections.Generic;
using System.Linq;

namespace Curso_RestWithASP_NET5.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;
            var array = origin.FullName.Split(" ");
            return new Person
            {
                Id = origin.Id,
                FirstName = array[0],
                LastName = array[1],
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonVO
            {
                Id = origin.Id,
                FullName = origin.FirstName + " " + origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public List<Person> Parse(List<PersonVO> origins)
        {
            if (origins == null) return null;
            return origins.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> Parse(List<Person> origins)
        {
            if (origins == null) return null;
            return origins.Select(item => Parse(item)).ToList();
        }
    }
}
