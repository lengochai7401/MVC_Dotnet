using Microsoft.EntityFrameworkCore;

namespace MVC_DotNet.Models
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Student> Students { get; set; }
    }
}