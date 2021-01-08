using Curso_RestWithASP_NET5.Data.VO;
using System.Collections.Generic;

namespace Curso_RestWithASP_NET5.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindById(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);

    }
}
