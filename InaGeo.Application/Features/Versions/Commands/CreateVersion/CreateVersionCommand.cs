using MediatR;
using System;

namespace InaGeo.Application.Features.Versions.Commands.CreateVersion
{
    public class CreateVersionCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public Guid idSoftware { get; set; }
    }
}
