namespace FactoryManager.AppService.CommandPrompt
{
    public interface ICommandPromptHelper
    {
        void CheckIfProcessIsAlreadyRunning(string process);
        void KillProcess(string process);
        void Execute(int proccesType, string command);
    }
}