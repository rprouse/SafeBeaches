using System.Data.Entity;
using SafeBeaches.Models;

namespace SafeBeaches.Data
{
    public class BeachesContext : DbContext
    {
        public BeachesContext() : base("DefaultConnection")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;

            //Database.SetInitializer( new DropCreateDatabaseAlways<BeachesContext>() );
            Database.SetInitializer( new MigrateDatabaseToLatestVersion<BeachesContext, BeachesMigration>() );
        }

        public DbSet<Beach> Beaches { get; set; }
        public DbSet<Reading> Readings { get; set; }
    }
}
