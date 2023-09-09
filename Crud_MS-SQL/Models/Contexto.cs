using Microsoft.EntityFrameworkCore;

namespace Crud_MS_SQL.Models;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Cliente> Cliente { get; set; }
}
