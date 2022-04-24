using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationForAPInet.Data.EntityMapper;
using WebApplicationForAPInet.Data.Models;

namespace WebApplicationForAPInet.Repository
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FileMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<File> File { get; set; }
    }
}
