using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationForAPInet5.Models;

namespace WebApplicationForAPInet5.Data
{
    public class WebApplicationForAPInet5Context : DbContext
    {
        public WebApplicationForAPInet5Context (DbContextOptions<WebApplicationForAPInet5Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationForAPInet5.Models.File> File { get; set; }
    }
}
