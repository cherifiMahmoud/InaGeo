using MediatR;
using System;

namespace InaGeo.Application.Features.Versions.Commands.UpdateVersion
{
    public class UpdateVersionCommand : IRequest
    {
        public Guid IdVersion { get; set; }
        public string Name { get; set; }
        public Guid idSoftware { get; set; }
    }
}
