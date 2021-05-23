using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using FactoryManager.View;
using FactoryManager.View.GridView;

namespace FactoryManager.ViewService
{
    public class DockingFormHelper : IDockingFormHelper
    {
        public List<AppForm> GetAllForms()
        {
            List<AppForm> appForms = new List<AppForm>();
            Type formType = typeof(Form);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (formType.IsAssignableFrom(type)
                    && type.Name != "MainForm" 
                    && type.Name != "MessageDialog"
                    && type.Name != "NotificationDialog"
                    && type.Name != "LoadingScreen")
                {
                    appForms.Add(new AppForm { Id = type.FullName, Name = type.Name });
                }
            return appForms;
        }

        public void RegisterAllForms()
        {
            var appForms = GetAllForms();
            MainForm.FormList.DataSource = appForms;
            MainForm.FormList.ValueMember = "Id";
            MainForm.FormList.DisplayMember = "Name";
        }

        public bool CheckIfFormIsAlreadyOpened(string formName)
        {
            bool isOpened= false;
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name == formName)
                {
                    isOpened = true;
                }
                else
                {
                    isOpened = false;
                }
            }
            return isOpened;
        }

        public void CloseAllOpenForms(string formName)
        {
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name != "Login" && form.Name != "MainForm" && form.Name != "LoadingScreen" && form.Name != formName)
                {
                    form.Close();
                }
            }
        }

        public void OpenDockingForm()
        {
            if (MainForm.FormList.SelectedItem is AppForm appForm)
            {
                Type objectType = Type.GetType(appForm.Id);
                if (objectType != null)
                {
                    if (Activator.CreateInstance(objectType) is Form form)
                    {
                        form.TopLevel = false;
                        form.Dock = DockStyle.Fill;
                        MainForm.DockingPanel.Controls.Clear();
                        MainForm.DockingPanel.Controls.Add(form);
                        form.Show();
                    }
                }
            }
        }
    }
}
