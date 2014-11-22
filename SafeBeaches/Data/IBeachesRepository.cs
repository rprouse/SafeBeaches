using System;
using System.Linq;
using SafeBeaches.Models;

namespace SafeBeaches.Data
{
    public interface IBeachesRepository
    {
        IQueryable<Beach> GetBeaches();
        IQueryable<Reading> GetReadingsForBeach( int beachId );

        bool Save();
        bool AddReading( Reading reading );
    }

    public class BeachesRepository : IBeachesRepository
    {
        private readonly BeachesContext _context;

        public BeachesRepository( BeachesContext context )
        {
            _context = context;
        }

        #region Implementation of IBeachesRepository

        public IQueryable<Beach> GetBeaches()
        {
            return _context.Beaches.Include( "Readings" );
        }

        public IQueryable<Reading> GetReadingsForBeach( int beachId )
        {
            return _context.Readings.Where( r => r.BeachId == beachId );
        }

        public bool Save()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception );
                return false;
            }
        }

        public bool AddReading( Reading reading )
        {
            try
            {
                _context.Readings.Add( reading );
                return true;
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception );
                return false;
            }
        }

        #endregion
    }
}
