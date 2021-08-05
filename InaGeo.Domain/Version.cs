using System;

namespace InaGeo.Domain
{
    public class Version
    {
        public long VersionId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Software Software { get; set; }
        public long SoftwareId { get; set; }
    }
}
