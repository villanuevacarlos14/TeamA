using AppKeep.Data;
using AppKeep.Domain;
using AutoMapper;

namespace AppKeep.Service.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Machine, MachineEntity>();
            CreateMap<MachineEntity, Machine>();

            CreateMap<MachinePart, MachinePartEntity>();
            CreateMap<MachinePartEntity, MachinePart>();

            CreateMap<UserMachine, UserMachineEntity>();
            CreateMap<UserMachineEntity, UserMachine>();

            CreateMap<User, UserEntity>();
            CreateMap<UserEntity, User>();

            CreateMap<UpkeepProfile, UpkeepProfileEntity>();
            CreateMap<UpkeepProfileEntity, UpkeepProfile>();

            CreateMap<UpkeepTemplate, UpkeepTemplateEntity>();
            CreateMap<UpkeepTemplateEntity, UpkeepTemplate>();

            CreateMap<UpkeepTemplateDetail, UpkeepTemplateDetailEntity>();
            CreateMap<UpkeepTemplateDetailEntity, UpkeepTemplateDetail>();

            CreateMap<MyPlanItem, MyPlanEntity>();
            CreateMap<MyPlanEntity, MyPlanItem>();
        }
    }
}