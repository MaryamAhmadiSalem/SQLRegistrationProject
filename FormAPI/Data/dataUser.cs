using Microsoft.EntityFrameworkCore;
using FormAPI.Model;

namespace FormAPI.Data
{
    public class dataUser : DbContext
    {
        public dataUser(DbContextOptions<dataUser> options) : base(options) { }
        public DbSet<User> Table_MyForm { get; set; }
    }
}