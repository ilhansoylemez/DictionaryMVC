using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        void Instert(T P);
        void Delete(T P);
        void Update(T P);

        List<T> List(Expression<Func<T, bool>> filter);
    }
}
