using System;
using System.Globalization;
using FactoryManager.AppService.ConfigurationReader;
using FactoryManager.ViewModels.MainForm;

namespace FactoryManager.AppService.DateTimeCounting
{
    public class CurrentDateTimeHelper : ICurrentDateTimeHelper
    {
        public string GetCurrentDate()
        {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            return currentDate;
        }

        public string GetCurrentTime()
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            return currentTime;
        }

        public string GetCurrentDay()
        {
            string currentDay = DateTime.Now.ToString("dddddddddd").ToUpper();
            return currentDay;
        }

        public string GetCurrentWeek()
        {
            DateTime time = DateTime.Now;

            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);

            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday).ToString();
        }

        public MainFormViewModel GetAllDateTimeValues()
        {
            MainFormViewModel mainFormVM = new MainFormViewModel
            {
                CurrentDate = GetCurrentDate(),
                CurrentTime = GetCurrentTime(),
                CurrentDay = GetCurrentDay(),
                WeekNumber = GetCurrentWeek()
            };

            return mainFormVM;
        }

        private static IConfigurationReader _configurationReader;
        public string GetCopyrightYear()
        {
            _configurationReader = (IConfigurationReader)Program.ServiceProvider.GetService(typeof(IConfigurationReader));

            var copyright = _configurationReader.GetAppCopyright();
            string copyrightYear = copyright.Substring(copyright.Length - 4);

            string currentYear = DateTime.Now.ToString("yyyy");
            if (currentYear == copyrightYear)
            {
                return null;
            }
            else
            {
                return "- " + currentYear;
            }
        }
    }
}
