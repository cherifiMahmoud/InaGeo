using AutoMapper;
using InaGeo.Application.Features.Versions.Commands.CreateVersion;
using InaGeo.Application.Features.Versions.Commands.DeleteVersion;
using InaGeo.Application.Features.Versions.Commands.UpdateVersion;
using InaGeo.Application.Features.Versions.Queries.GetVersionList;
using Version = InaGeo.Domain.Version;

namespace InaGeo.Application.Profiles
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Version, GetVersionListViewModel>().ReverseMap();
            CreateMap<Version, CreateVersionCommand>().ReverseMap();
            CreateMap<Version, UpdateVersionCommand>().ReverseMap();
            CreateMap<Version, DeleteVersionCommand>().ReverseMap();
        }
    }
}
