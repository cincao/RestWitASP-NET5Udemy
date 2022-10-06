using RestWithASPNETUdemy.Controllers.Data.Converter.Implementations;
using RestWithASPNETUdemy.Controllers.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _repository;

        private readonly BookConverter _converter;

        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _converter.Parser(_repository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parser(_repository.FindById(id));
        }

        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parser(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parser(bookEntity);
        }

        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parser(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parser(bookEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
