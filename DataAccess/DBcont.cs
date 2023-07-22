using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DBcont:DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}