using AppKeep.Data;
using AppKeep.Data.Repository;
using AppKeep.Service;
using Autofac;

namespace AppKeep.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = ConfigureContainer();
            var application = container.Resolve<ApplicationLogic>();

            application.Run(args); // Pass runtime data to application here
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ApplicationLogic>().AsSelf();
            builder.RegisterType<AppKeepContext>().AsSelf().InstancePerDependency();
            builder.RegisterType<MachineService>().As<IMachineService>().InstancePerDependency();
            builder.RegisterType<MachineRepository>().As<IMachineRepository>().InstancePerDependency();
            return builder.Build();
        }
    }

    public class ApplicationLogic
    {
        private readonly IMachineService _machineService;

        public ApplicationLogic(
            IMachineService machineService)
        {
            _machineService = machineService;
        }

        public void Run(string[] args)
        {
            var machinesTask = _machineService.GetAllMachinesAsync();

            foreach (var machine in machinesTask.Result)
            {
                System.Console.WriteLine($"MachineId: {machine.MachineId}, Name: {machine.Name}");
            }
        }
    }
}
