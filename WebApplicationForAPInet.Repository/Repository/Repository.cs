using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationForAPInet.Data.Models;

namespace WebApplicationForAPInet.Repository.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;
        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        public void Delete(string FileId)
        {
            //var file = _applicationDbContext.File.FindAsync(FileId);
            //if (file == null)
            //{
            //    return NotFound();
            //}

            //_applicationDbContext.File.Remove(file);
            // _applicationDbContext.SaveChangesAsync();

            //return NoContent();
        }

        public T Get(string FileId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
