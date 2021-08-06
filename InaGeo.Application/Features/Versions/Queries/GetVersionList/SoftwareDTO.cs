using System;

namespace InaGeo.Application.Features.Versions.Queries.GetVersionList
{
    public class SoftwareDTO
    {
        public long SoftwareId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
    }
}