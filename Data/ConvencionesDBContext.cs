using Microsoft.EntityFrameworkCore;

namespace ConvencionesWebApi.Data
{
    public class ConvencionesDBContext : DbContext
    {
        public ConvencionesDBContext(DbContextOptions<ConvencionesDBContext> options) : base(options)
        {

        }
        public DbSet<tblEntrada> tblEntrada { get; set;}
    }
}
