using System.Collections.Generic;

namespace Curso_RestWithASP_NET5.Data.Converter.Contract
{
    interface IParser<O, D>
    {
        D Parse(O origin);

        List<D> Parse(List<O> origins);
    }
}
