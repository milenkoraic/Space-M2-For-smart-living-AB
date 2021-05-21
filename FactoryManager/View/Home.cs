using FactoryManager.AppService.DateTimeCounting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FactoryManager.View
{
    public partial class Home : Form
    {
        private readonly ICurrentDateTimeHelper _currentDateTimeHelper;
        public Home()
        {
            _currentDateTimeHelper = (ICurrentDateTimeHelper)Program.ServiceProvider.GetService(typeof(ICurrentDateTimeHelper));
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            var dateTime = _currentDateTimeHelper.GetAllDateTimeValues();
            TimeLabel.Text = dateTime.CurrentDay + ", " + dateTime.CurrentTime;
        }
    }
}
