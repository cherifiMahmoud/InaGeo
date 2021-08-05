using AutoMapper;
using InaGeo.Application.Contracts;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InaGeo.Application.Features.Versions.Queries.GetVersionList
{
    public class GetVersionListQueryHandler : IRequestHandler<GetVersionListQuery, List<GetVersionListViewModel>>
    {
        private readonly IVersionRespository _versionRespository;
        private readonly IMapper _mapper;

        public GetVersionListQueryHandler(IVersionRespository versionRespository, IMapper mapper)
        {
            _versionRespository = versionRespository;
            _mapper = mapper;
        }

        public async Task<List<GetVersionListViewModel>> Handle(GetVersionListQuery request, CancellationToken cancellationToken)
        {
            var allVersion = await _versionRespository.GetAllVersionAsync(true);
            return _mapper.Map<List<GetVersionListViewModel>>(allVersion);
        }
    }
}
