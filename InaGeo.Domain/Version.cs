using System;

namespace InaGeo.Domain
{
    public class Version
    {
        public Guid IdVersion { get; set; }
        public string Name { get; set; }
        public Software Software { get; set; }
        public Guid idSoftware { get; set; }
    }
}
