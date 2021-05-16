using System.Collections.Generic;
using System.Windows.Forms;

namespace FactoryManager.AppService.FormInitialization
{
    public interface IFormInitializationHelper
    {
        List<AppForm> GetAllForms();
        void RegisterAllForms();
        void CloseAllOpenForms(string formName);
        void OpenDockingForm(Form parentForm);
        void OpenIndependentForm(Form parentForm);
        bool CheckIfFormIsAlreadyOpened(string formName);
    }
}