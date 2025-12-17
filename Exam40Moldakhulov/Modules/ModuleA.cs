using Exam40Moldakhulov.Mediator;

namespace Exam40Moldakhulov.Modules
{
    public class ModuleA : IModule
    {
        private IMediator mediator;

        public ModuleA(IMediator mediator)
        {
            this.mediator = mediator;
            mediator.RegisterModule(this);
        }

        public void Receive(string message)
        {
            Console.WriteLine("ModuleA received: " + message);
        }
    }
}