using RestApisWithAspNet.Data.VO;
using System.Collections.Generic;

namespace RestApisWithAspNet.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}