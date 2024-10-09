using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Personal_Financial_Dashboard.Data
{
    public class PFDAuthDbContext :IdentityDbContext
    {
        public PFDAuthDbContext(DbContextOptions<PFDAuthDbContext> options) : base(options)
        {
            
        }
    }
}
