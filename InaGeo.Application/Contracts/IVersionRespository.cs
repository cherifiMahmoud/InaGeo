using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Version = InaGeo.Domain.Version;

namespace InaGeo.Application.Contracts
{
    public interface IVersionRespository : IAsyncRespository<Version>
    {
        Task<IReadOnlyList<Version>> GetAllVersionAsync(bool includeSoftware);
        Task<Version> GetVersionByIdAsync(Guid IdVersion, bool includeSoftware); 
    }
}
