using Exam40Moldakhulov.Mediator;

namespace Exam40Moldakhulov.Modules
{
    public class ModuleB : IModule
    {
        private IMediator mediator;

        public ModuleB(IMediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterModule(this);
        }

        public void Receive(string message)
        {
            Console.WriteLine("ModuleB received: " + message);
        }
    }
}