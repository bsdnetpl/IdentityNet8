using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityNet8.DB
{
    public class DBConn: IdentityDbContext
    {
        public DBConn(DbContextOptions<DBConn> options):base(options)
        {
            
        }
    }
}
