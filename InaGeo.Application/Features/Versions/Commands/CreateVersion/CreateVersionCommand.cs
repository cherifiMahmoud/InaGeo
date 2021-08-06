using MediatR;
using System;

namespace InaGeo.Application.Features.Versions.Commands.CreateVersion
{
    public class CreateVersionCommand : IRequest<string>
    {
        public string Name { get; set; }
        public long SoftwareId { get; set; }
    }
}
