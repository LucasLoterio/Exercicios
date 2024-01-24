using Microsoft.EntityFrameworkCore;

namespace Autenticacao.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options)
                :base(options)
        { 
        }

       public DbSet<Models.User> usuarios{ get; set; }
    }
}
