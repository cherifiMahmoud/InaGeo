using System;
using System.Collections.Generic;

namespace InaGeo.Domain
{
    public class Software
    {
        public long SoftwareId { get; set; }
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public List<Version> Versions { get; set; }
    }
}