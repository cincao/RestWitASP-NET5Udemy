using RestWithASPNETUdemy.Controllers.Data.Converter.Contract;
using RestWithASPNETUdemy.Controllers.Data.VO;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers.Data.Converter.Implementations
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parser(PersonVO origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                FistName = origin.FistName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public PersonVO Parser(Person origin)
        {
            if (origin == null) return null;
            return new PersonVO
            {
                Id = origin.Id,
                FistName = origin.FistName,
                LastName = origin.LastName,
                Address = origin.Address,
                Gender = origin.Gender
            };
        }

        public List<PersonVO> Parser(List<Person> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parser(item)).ToList();
        }

        public List<Person> Parser(List<PersonVO> origin)
        {
            return origin.Select(item => Parser(item)).ToList();
        }
    }
}
