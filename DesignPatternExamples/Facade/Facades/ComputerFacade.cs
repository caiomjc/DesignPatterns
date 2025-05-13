using Facade.Classes;

namespace Facade.Facades
{
    public class ComputerFacade
    {
        private CPU _cpu;
        private Memory _memory;
        private Disk _disk;

        public ComputerFacade()
        {
            _cpu = new CPU();
            _memory = new Memory();
            _disk = new Disk();
        }

        public void StartComputer()
        {
            _cpu.Start();
            _memory.Load();
            _disk.Read();
            Console.WriteLine("Computer started via Facade");
        }
    }
}
