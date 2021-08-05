using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Version = InaGeo.Domain.Version;
using InaGeo.Application.Contracts;
using Microsoft.EntityFrameworkCore;

namespace InaGeo.Persistence.Repositories
{
    public class VersionRepository : BaseRepository<Version>, IVersionRespository
    {

        public VersionRepository(InaGeoDbContext inaGeoDbContext) : base(inaGeoDbContext)
        {

        }
        public async Task<IReadOnlyList<Version>> GetAllVersionAsync(bool includeSoftware)
        {
            List<Version> allVersions = new List<Version>();
            allVersions = includeSoftware ? await _dbContext.Versions.Include(x => x.Software).ToListAsync() : await _dbContext.Versions.ToListAsync();
            return allVersions;
        }

        public async Task<Version> GetVersionByIdAsync(Guid IdVersion, bool includeSoftware)
        {
            Version Version = new Version();
            Version = includeSoftware ?  await _dbContext.Versions.Include(x => x.Software).FirstOrDefaultAsync(x => x.Guid == IdVersion): await GetByIdAsync(IdVersion);
            return Version;
        }
    }
}
