using RestWithASPNETUdemy.Controllers.Data.Converter.Implementations;
using RestWithASPNETUdemy.Controllers.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public List<PersonVO> FindAll()
        {
            return _converter.Parser(_repository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parser(_repository.FindById(id));
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parser(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parser(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parser(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parser(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
