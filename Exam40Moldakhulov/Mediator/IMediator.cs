using Exam40Moldakhulov.Modules;

namespace Exam40Moldakhulov.Mediator
{
    public interface IMediator
    {
        void RegisterModule(IModule module);
        void Send(string message, IModule sender);
    }
}