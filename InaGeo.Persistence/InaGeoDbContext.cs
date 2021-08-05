using InaGeo.Domain;
using Microsoft.EntityFrameworkCore;

namespace InaGeo.Persistence
{
    public class InaGeoDbContext : DbContext
    {
        public InaGeoDbContext(DbContextOptions<InaGeoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Version> Versions { get; set; }
        public DbSet<Software> Softwares { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //var softwareGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            //var versionGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");

            //modelBuilder.Entity<Software>().HasData(new Software
            //{
            //    IdSoftware = softwareGuid,
            //    Name = "Pharmex"
            //});

            //modelBuilder.Entity<Version>().HasData(new Version
            //{
            //    IdVersion = versionGuid,
            //    Name = "V1",
            //    idSoftware = softwareGuid
            //});
        }
    }
}
