using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class MachinePartService : IMachinePartService, IAutoMapperService
    {
        private readonly IMachinePartRepository _machinePartRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public MachinePartService(IMachinePartRepository machinePartRepository)
        {
            _machinePartRepository = machinePartRepository;
        }

        public async Task<MachinePart> AddMachinePartAsync(MachinePart machinePart)
        {
            var machinePartEntity = Mapper.Map<MachinePartEntity>(machinePart);

            machinePartEntity = await _machinePartRepository.AddAsync(machinePartEntity);

            machinePart = Mapper.Map<MachinePart>(machinePartEntity);

            return machinePart;
        }

        public async Task<List<MachinePart>> GetAllMachinePartsAsync()
        {
            var machineEntities = await _machinePartRepository.GetAll().ToListAsync();

            return Mapper.Map<List<MachinePart>>(machineEntities);
        }

        public async Task<MachinePart> GetMachinePartByIdAsync(int id)
        {
            var machinePartEntity = await _machinePartRepository.GetAsync(id);

            var machinePart = Mapper.Map<MachinePart>(machinePartEntity);

            return machinePart;
        }

        public async Task<MachinePart> UpdateMachinePartAsync(MachinePart machinePart)
        {
            var machinePartEntity = Mapper.Map<MachinePartEntity>(machinePart);

            machinePartEntity = await _machinePartRepository.UpdateAsync(machinePartEntity);

            machinePart = Mapper.Map<MachinePart>(machinePartEntity);

            return machinePart;
        }
    }
}