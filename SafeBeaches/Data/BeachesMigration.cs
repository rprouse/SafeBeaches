using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Spatial;
using System.Linq;
using SafeBeaches.Models;

namespace SafeBeaches.Data
{
    public class BeachesMigration : DbMigrationsConfiguration<BeachesContext>
    {
        public BeachesMigration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }

        #region Overrides of DbMigrationsConfiguration<BeachesContext>

        /// <summary>
        /// Runs after upgrading to the latest migration to allow seed data to be updated.
        /// </summary>
        /// <remarks>
        /// Note that the database may already contain seed data when this method runs. This means that
        ///             implementations of this method must check whether or not seed data is present and/or up-to-date
        ///             and then only make changes if necessary and in a non-destructive way. The
        ///             <see cref="M:System.Data.Entity.Migrations.DbSetMigrationsExtensions.AddOrUpdate``1(System.Data.Entity.IDbSet{``0},``0[])"/>
        ///             can be used to help with this, but for seeding large amounts of data it may be necessary to do less
        ///             granular checks if performance is an issue.
        ///             If the <see cref="T:System.Data.Entity.MigrateDatabaseToLatestVersion`2"/> database
        ///             initializer is being used, then this method will be called each time that the initializer runs.
        ///             If one of the <see cref="T:System.Data.Entity.DropCreateDatabaseAlways`1"/>, <see cref="T:System.Data.Entity.DropCreateDatabaseIfModelChanges`1"/>,
        ///             or <see cref="T:System.Data.Entity.CreateDatabaseIfNotExists`1"/> initializers is being used, then this method will not be
        ///             called and the Seed method defined in the initializer should be used instead.
        /// </remarks>
        /// <param name="context">Context to be used for updating seed data. </param>
        protected override void Seed( BeachesContext context )
        {
            base.Seed( context );

#if DEBUG
            if ( !context.WaterBodies.Any() )
            {
                var body = new WaterBody
                {
                    Name = "Lake Ontario",
                    Beaches =
                        new List<Beach>
                        {
                            new Beach
                            {
                                Name = "Beach Boulevard",
                                Location = DbGeography.FromText( "POINT(43.277482 -79.780652)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            },
                            new Beach
                            {
                                Name = "Van Wagners",
                                Location = DbGeography.FromText( "POINT(43.259482 -79.765117)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            },
                            new Beach
                            {
                                Name = "Confederation Park",
                                Location = DbGeography.FromText( "POINT(43.250981 -79.754903)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            },
                        }
                };
                context.WaterBodies.Add( body );

                body = new WaterBody
                {
                    Name = "Hamilton Harbour",
                    Beaches =
                        new List<Beach>
                        {
                            new Beach
                            {
                                Name = "Bayfront Park Beach",
                                Location = DbGeography.FromText( "POINT(43.271584 -79.874634)" ),
                                Safe = false,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = false},
                                    }
                            },
                            new Beach
                            {
                                Name = "Pier 4 Beach",
                                Location = DbGeography.FromText( "POINT(43.273646 -79.867682)" ),
                                Safe = false,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = false},
                                    }
                            }
                        }
                };
                context.WaterBodies.Add( body );

                body = new WaterBody
                {
                    Name = "Christie Reservoir",
                    Beaches =
                        new List<Beach>
                        {
                            new Beach
                            {
                                Name = "Christie Conservation",
                                Location = DbGeography.FromText( "POINT(43.280835 -80.022795)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            }
                        }
                };
                context.WaterBodies.Add( body );

                body = new WaterBody
                {
                    Name = "Lake Niapenco",
                    Beaches =
                        new List<Beach>
                        {
                            new Beach
                            {
                                Name = "Binbrook Conservation",
                                Location = DbGeography.FromText( "POINT(43.101739 -79.833129)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = false},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            }
                        }
                };
                context.WaterBodies.Add( body );

                body = new WaterBody
                {
                    Name = "Valens Reservoir",
                    Beaches =
                        new List<Beach>
                        {
                            new Beach
                            {
                                Name = "Valens Conservation",
                                Location = DbGeography.FromText( "POINT(43.383655 -80.139379)" ),
                                Safe = true,
                                LastReadingDate = new DateTime( 2014, 09, 10 ),
                                Readings =
                                    new List<Reading>
                                    {
                                        new Reading {Date = new DateTime( 2014, 06, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 07, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 08, 10 ), Safe = true},
                                        new Reading {Date = new DateTime( 2014, 09, 10 ), Safe = true},
                                    }
                            }
                        }
                };
                context.WaterBodies.Add( body );
            }
            try
            {
                context.SaveChanges();
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception );
            }
#endif
        }

        #endregion
    }
}