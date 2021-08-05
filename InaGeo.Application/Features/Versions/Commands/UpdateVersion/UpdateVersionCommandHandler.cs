using MediatR;
using System.Threading;
using System.Threading.Tasks;
using InaGeo.Application.Contracts;
using Version = InaGeo.Domain.Version;
using AutoMapper;

namespace InaGeo.Application.Features.Versions.Commands.UpdateVersion
{
    public class UpdateVersionCommandHandler : IRequestHandler<UpdateVersionCommand>
    {
        private readonly IAsyncRespository<Version> _versionRepository;
        private readonly IMapper _mapper;

        public UpdateVersionCommandHandler(IAsyncRespository<Version> versionRespository, IMapper mapper)
        {
            _versionRepository = versionRespository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateVersionCommand request, CancellationToken cancellationToken)
        {
            Version version = _mapper.Map<Version>(request);

            await _versionRepository.UpdateAsync(version);

            return Unit.Value;
        }
    }
}
