using FactoryManager.ViewModels.MainForm;

namespace FactoryManager.AppService.DateTimeCounting
{
    public interface ICurrentDateTimeHelper
    {
        string GetCopyrightYear();
        string GetCurrentDate();
        string GetCurrentDay();
        string GetCurrentTime();
        string GetCurrentWeek();
        MainFormViewModel GetAllDateTimeValues();
    }
}