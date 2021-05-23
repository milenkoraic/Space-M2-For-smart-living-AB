using System;
using System.Windows.Forms;
using FactoryManager.AppService.ApplicationLogger;
using FactoryManager.AppService.CommandPrompt;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.AppService.DateTimeCounting;
using FactoryManager.AppService.SystemInspection;
using FactoryManager.View;
using FactoryManager.ViewService;
using FactoryManager.ViewService.DialogProvider;
using Microsoft.Extensions.DependencyInjection;

namespace FactoryManager
{
    static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
     
        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IOperatingSystemHelper, OperatingSystemHelper>();
            services.AddSingleton<IConfigurationReader, ConfigurationReader>();
            services.AddSingleton<ILogHelper, LogHelper>();
            services.AddSingleton<ICommandPromptHelper, CommandPromptHelper>();
            services.AddSingleton<ICurrentDateTimeHelper, CurrentDateTimeHelper>();
            services.AddSingleton<IDockingFormHelper, DockingFormHelper>();
            services.AddSingleton<IDialogMessageHelper, DialogMessageHelper>();
            ServiceProvider = services.BuildServiceProvider();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConfigureServices();
            Application.Run(new Login());
        }
    }
}
