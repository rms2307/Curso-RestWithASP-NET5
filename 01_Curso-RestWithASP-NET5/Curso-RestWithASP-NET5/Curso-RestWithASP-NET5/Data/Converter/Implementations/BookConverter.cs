using Curso_RestWithASP_NET5.Data.Converter.Contract;
using Curso_RestWithASP_NET5.Data.VO;
using Curso_RestWithASP_NET5.Model;
using System.Collections.Generic;
using System.Linq;

namespace Curso_RestWithASP_NET5.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null) return null;
            return new Book
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author                
            };
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null) return null;
            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                Author = origin.Author
            };
        }

        public List<Book> Parse(List<BookVO> origins)
        {
            if (origins == null) return null;
            return origins.Select(item => Parse(item)).ToList();
        }

        public List<BookVO> Parse(List<Book> origins)
        {
            if (origins == null) return null;
            return origins.Select(item => Parse(item)).ToList();
        }
    }
}
