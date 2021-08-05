using InaGeo.Application.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InaGeo.Application.Features.Versions.Commands.DeleteVersion
{
    public class DeleteVersionCommandHandler : IRequestHandler<DeleteVersionCommand>
    {
        private readonly IVersionRespository _versionRpository;

        public DeleteVersionCommandHandler(IVersionRespository versionRespository)
        {
            _versionRpository = versionRespository;
        }

        public async Task<Unit> Handle(DeleteVersionCommand request, CancellationToken cancellationToken)
        {
            var version = await _versionRpository.GetByIdAsync(request.IdVersion);

            await _versionRpository.DeleteAsync(version);

            return Unit.Value;
        }
    }
}
