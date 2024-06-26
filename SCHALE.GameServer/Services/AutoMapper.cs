using AutoMapper;
using SCHALE.Common.Database;

namespace SCHALE.GameServer.Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EchelonDB, EchelonDB>().ForMember(x => x.ServerId, opt => opt.Ignore());
        }
    }
}
