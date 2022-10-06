using RestWithASPNETUdemy.Controllers.Data.Converter.Contract;
using RestWithASPNETUdemy.Controllers.Data.VO;
using RestWithASPNETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parser(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate
            };
        }

        public BookVO Parser(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author,
                Price = origin.Price,
                LaunchDate = origin.LaunchDate                
            };
        }

        public List<BookVO> Parser(List<Book> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parser(item)).ToList();
        }

        public List<Book> Parser(List<BookVO> origin)
        {
            return origin.Select(item => Parser(item)).ToList();
        }
    }
}
