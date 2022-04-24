using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationForAPInet.Data.Models;

namespace WebApplicationForAPInet.Repository.Repository
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(string FileId);
        void Insert(T entity);
        void Update(T entity);
        void Delete(string FileId);
    }
}
