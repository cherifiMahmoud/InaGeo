using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InaGeo.Domain
{
    public class Module
    {
        public Guid idModule { get; set; }
        public string name { get; set; }
        public List<Version> Versions  { get; set; }
    }
}
