using AutoMapper;

namespace AppKeep.Service.Mapping
{
    public interface IAutoMapperService
    {
        IMapper Mapper { get; }
    }
}