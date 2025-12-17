using Exam40Moldakhulov.Mediator;
using Exam40Moldakhulov.Modules;

class Program
{
    static void Main()
    {
        IMediator mediator = new ModuleMediator("Config/scenarios.json");

        var moduleA = new ModuleA(mediator);
        var moduleB = new ModuleB(mediator);

        mediator.Send("Hello from config scenario, Dear Professor Evgeniy. I sincerely hope that my work meets all the criteria and has been done correctly. " +
            "I would like to return to the scholarship program next semester. Have a wonderful day! Best regards Emir", moduleA);
    }
}