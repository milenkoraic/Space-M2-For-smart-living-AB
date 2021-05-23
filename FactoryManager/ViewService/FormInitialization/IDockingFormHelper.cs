using System.Collections.Generic;
using System.Windows.Forms;

namespace FactoryManager.ViewService
{
    public interface IDockingFormHelper
    {
        List<AppForm> GetAllForms();
        void RegisterAllForms();
        bool CheckIfFormIsAlreadyOpened(string formName);
        void CloseAllOpenForms(string formName);
        void OpenDockingForm();
    }
}