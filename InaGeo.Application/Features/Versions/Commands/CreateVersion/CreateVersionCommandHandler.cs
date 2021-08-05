using AutoMapper;
using InaGeo.Application.Contracts;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Version = InaGeo.Domain.Version;

namespace InaGeo.Application.Features.Versions.Commands.CreateVersion
{
    public class CreateVersionCommandHandler : IRequestHandler<CreateVersionCommand, Guid>
    {
        private readonly IVersionRespository _versionRepository;
        private readonly IMapper _mapper;

        public CreateVersionCommandHandler(IVersionRespository versionRespository, IMapper mapper)
        {
            _versionRepository = versionRespository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateVersionCommand request, CancellationToken cancellationToken)
        {
            Version version = _mapper.Map<Version>(request);

            CreateCommandValidator validator = new CreateCommandValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                throw new Exception("Version n'est pas valider");
            }

            version = await _versionRepository.AddAsync(version);

            return version.IdVersion;

        }
    }
}
