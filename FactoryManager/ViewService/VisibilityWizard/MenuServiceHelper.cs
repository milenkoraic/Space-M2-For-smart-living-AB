using System.Windows.Forms;


namespace FactoryManager.ViewService.DialogProvider
{
    public class MenuServiceHelper : IMenuServiceHelper
    {
        public void HideSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == true)
                subMenu.Visible = false;
            if (subMenu.Visible == true)
                subMenu.Visible = false;
        }

        public void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubmenu(subMenu);
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
    }
}
