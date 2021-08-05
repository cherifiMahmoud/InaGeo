using System;

namespace InaGeo.Application.Features.Versions.Queries.GetVersionList
{
    public class GetVersionListViewModel
    {
        public Guid IdVersion { get; set; }
        public string Name { get; set; }
        public SoftwareDTO Software { get; set; }
    }
}
