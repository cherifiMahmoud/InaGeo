using MediatR;
using System;

namespace InaGeo.Application.Features.Versions.Commands.DeleteVersion
{
    public class DeleteVersionCommand : IRequest
    {
        public Guid IdVersion { get; set; }
    }
}
