using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace CustomResourceView
{
    public class SchedulerBehavior : Behavior<SfScheduler>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            this.AssociatedObject.DisplayDate = DateTime.Now.Date.AddHours(9);
            this.AssociatedObject.DaysViewSettings.ResourceHeaderSize = 120;

            var currentDate = DateTime.Now;
            var casualLeave = new SpecialTimeRegion();
            casualLeave.Text = "Casual leave";
            casualLeave.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(2).Day, 0, 0, 0);
            casualLeave.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(2).Day, 23, 59, 0);
            casualLeave.Background = new SolidColorBrush(Color.FromRgb(245, 245, 245));
            casualLeave.Foreground = new SolidColorBrush(Colors.Black);
            casualLeave.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=1";
            casualLeave.ResourceIdCollection = new ObservableCollection<object>() { "1" };

            var generalPermission = new SpecialTimeRegion();
            generalPermission.Text = "General permission";
            generalPermission.Foreground = new SolidColorBrush(Colors.Black);
            generalPermission.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(1).Day, 11, 0, 0);
            generalPermission.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(1).Day, 13, 0, 0);
            generalPermission.Background = new SolidColorBrush(Color.FromRgb(245, 245, 245));
            generalPermission.ResourceIdCollection = new ObservableCollection<object>() { "2" };
            generalPermission.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=1";

            this.AssociatedObject.DaysViewSettings.SpecialTimeRegions = new ObservableCollection<SpecialTimeRegion>() { casualLeave, generalPermission };
        }
    }
}