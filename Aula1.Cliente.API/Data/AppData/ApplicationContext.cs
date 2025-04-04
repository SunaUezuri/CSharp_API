using Aula1.Cliente.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula1.Cliente.API.Data.AppData
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        public DbSet<ClienteEntity> Cliente { get; set; }
    }
}
