using System.Windows.Forms;
using FactoryManager.AppService.CommandPrompt;
using FactoryManager.View.AppDialog;

namespace FactoryManager.ViewService.DialogProvider
{
    public class DialogMessageHelper : IDialogMessageHelper
    {
        public ICommandPromptHelper _commandPromptHelper;
        public void AskToCloseApplication()
        {
            string result = MessageDialog.ShowBox("Do you really want to exit the program?", "APPLICATION EXIT");
            if (result.Equals("1"))
            {
                Application.Exit();
            }
        }
        public  void AskToShutdownSystem()
        {
            string result = MessageDialog.ShowBox("Do you really want to shutdown your computer?", "SYSTEM SHUTDOWN");
            if (result.Equals("1"))
            {
                _commandPromptHelper = (ICommandPromptHelper)Program.ServiceProvider.GetService(typeof(ICommandPromptHelper));
                _commandPromptHelper.Execute(1,"shutdown /s");
            }
        }

        public void AskToLockDesktop()
        {
            string result = MessageDialog.ShowBox("Do you really want to lock your desktop?", "DESKTOP LOCK");
            if (result.Equals("1"))
            {
                _commandPromptHelper = (ICommandPromptHelper)Program.ServiceProvider.GetService(typeof(ICommandPromptHelper));
                _commandPromptHelper.Execute(1,"rundll32.exe user32.dll,LockWorkStation");
            }
        }
    }
}
