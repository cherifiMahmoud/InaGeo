using MediatR;
using System;

namespace InaGeo.Application.Features.Versions.Commands.UpdateVersion
{
    public class UpdateVersionCommand : IRequest
    {
        public long VersionId { get; set; }
        public string Name { get; set; }
        public long SoftwareId { get; set; }
    }
}
