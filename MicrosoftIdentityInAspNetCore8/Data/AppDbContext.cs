using Microsoft.EntityFrameworkCore;

namespace MicrosoftIdentityInAspNetCore8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
