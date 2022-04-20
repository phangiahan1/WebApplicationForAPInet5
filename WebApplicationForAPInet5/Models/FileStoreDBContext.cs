using Microsoft.EntityFrameworkCore;

namespace WebApplicationForAPInet5.Models
{
    public class FileStoreDBContext : DbContext
    {
        public FileStoreDBContext(DbContextOptions<FileStoreDBContext> options): base(options)
        {

        }
        public DbSet<File> Files { get; set; }
        public DbSet<Folder> Folders { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder
        //        .UseSqlServer(@"Data Source=VNMPCHAPH1\GIAHAN;Initial Catalog=dataForMyPageTraining;Integrated Security=True");
        //}
    }
}
