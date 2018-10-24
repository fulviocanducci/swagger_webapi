using Microsoft.EntityFrameworkCore;

namespace WebAppiSwagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class DatabaseContext: DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public DatabaseContext()
            :base()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=myDataBase;User Id=sa;Password=senha; ");
        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<Phone> Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<User> User { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}