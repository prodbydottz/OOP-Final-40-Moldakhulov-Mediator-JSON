using System.Text.Json;
using Exam40Moldakhulov.Modules;

namespace Exam40Moldakhulov.Mediator
{
    public class ModuleMediator : IMediator
    {
        private List<IModule> modules = new();
        private List<Scenario> scenarios;

        public ModuleMediator(string configPath)
        {
            var json = File.ReadAllText(configPath);
            var wrapper = JsonSerializer.Deserialize<ScenarioWrapper>(json);
            scenarios = wrapper.Scenarios;
        }

        public void RegisterModule(IModule module)
        {
            modules.Add(module);
        }

        public void Send(string message, IModule sender)
        {
            var senderName = sender.GetType().Name;

            var scenario = scenarios
                .FirstOrDefault(s => s.Sender == senderName);

            if (scenario == null)
                return;

            foreach (var module in modules)
            {
                if (scenario.Receivers.Contains(module.GetType().Name))
                {
                    module.Receive(message);
                }
            }
        }
    }

    public class ScenarioWrapper
    {
        public List<Scenario> Scenarios { get; set; }
    }
}
