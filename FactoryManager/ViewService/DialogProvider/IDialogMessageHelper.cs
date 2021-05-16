namespace FactoryManager.ViewService.DialogProvider
{
    public interface IDialogMessageHelper
    {
        void AskToCloseApplication();
        void AskToShutdownSystem();
        void AskToLockDesktop();
    }
}