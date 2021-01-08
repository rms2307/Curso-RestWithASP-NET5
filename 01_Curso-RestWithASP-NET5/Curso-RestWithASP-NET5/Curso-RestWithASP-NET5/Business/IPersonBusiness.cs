using Curso_RestWithASP_NET5.Data.VO;
using Curso_RestWithASP_NET5.Model;
using System.Collections.Generic;

namespace Curso_RestWithASP_NET5.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);

    }
}
