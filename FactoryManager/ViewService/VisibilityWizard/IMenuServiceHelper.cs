using System.Windows.Forms;

namespace FactoryManager.ViewService.DialogProvider
{
    public interface IMenuServiceHelper
    {
        void HideSubmenu(Panel subMenu);
        void ShowSubmenu(Panel subMenu);
    }
}