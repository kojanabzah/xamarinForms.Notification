using LocalNotifications.Plugin;
using LocalNotifications.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notification
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public void WordNotif(object sender, EventArgs e)
        {
            var notification = new LocalNotification
            {
                Text = "Hello Plugin",
                Title = "Nbation Plugin",
                Id = 2,
                NotifyTime = DateTime.Now.AddSeconds(2)
            };

            var notifier = CrossLocalNotifications.CreateLocalNotifier();
            notifier.Notify(notification);
        }

    }
}
