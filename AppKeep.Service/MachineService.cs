using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Domain;
using AppKeep.Service.Mapping;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppKeep.Service
{
    public class MachineService : IMachineService, IAutoMapperService
    {
        private readonly IMachineRepository _machineRepository;

        public IMapper Mapper
        {
            get { return ObjectMapper.Mapper; }
        }

        public MachineService(IMachineRepository machineRepository)
        {
            _machineRepository = machineRepository;
        }

        public async Task<Machine> AddMachineAsync(Machine machine)
        {
            var machineEntity = Mapper.Map<MachineEntity>(machine);

            machineEntity = await _machineRepository.AddAsync(machineEntity);

            machine = Mapper.Map<Machine>(machineEntity);

            return machine;
        }

        public async Task<List<Machine>> GetAllMachinesAsync()
        {
            var machineEntities = await _machineRepository.GetAll().ToListAsync();

            return Mapper.Map<List<Machine>>(machineEntities);
        }

        public async Task<Machine> GetMachineByIdAsync(int id)
        {
            var machineEntity = await _machineRepository.GetAsync(id);

            var machine = Mapper.Map<Machine>(machineEntity);

            return machine;
        }

        public async Task<Machine> UpdateMachineAsync(Machine machine)
        {
            var machineEntity = Mapper.Map<MachineEntity>(machine);

            machineEntity = await _machineRepository.UpdateAsync(machineEntity);

            machine = Mapper.Map<Machine>(machineEntity);

            return machine;
        }

        public async Task<IEnumerable<Machine>> SearchMachine(string searchValue)
        {
            var searchedMachines = await _machineRepository.GetAll()
                .Where(x=> x.Name.ToLower().Contains(searchValue.ToLower()))
                .ToListAsync();
            return Mapper.Map<IEnumerable<Machine>>(searchedMachines);
        }
    }
}