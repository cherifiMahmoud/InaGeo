using System;

namespace InaGeo.Application.Features.Versions.Queries.GetVersionList
{
    public class GetVersionListViewModel
    {
        public long VersionId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public SoftwareDTO Software { get; set; }
    }
}