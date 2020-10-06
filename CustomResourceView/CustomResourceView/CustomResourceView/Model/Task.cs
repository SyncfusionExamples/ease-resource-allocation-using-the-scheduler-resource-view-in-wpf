using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CustomResourceView
{
    public class Task : NotificationObject
    {
        DateTime from, to;
        string title;
        bool isAllDay;
        Brush color;
        private ObservableCollection<object> assignees;
        private string discription;

        public DateTime From
        {
            get { return from; }
            set
            {
                from = value;
                RaisePropertyChanged("From");
            }
        }

        public DateTime To
        {
            get { return to; }
            set
            {
                to = value;
                RaisePropertyChanged("To");
            }
        }

        public bool IsAllDay
        {
            get { return isAllDay; }
            set
            {
                isAllDay = value;
                RaisePropertyChanged("IsAllDay");
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged("Title");
            }
        }

        public string Description
        {
            get { return discription; }
            set
            {
                discription = value;
                RaisePropertyChanged("Description");
            }
        }
       
        public Brush Color
        {
            get { return color; }
            set
            {
                color = value;
                RaisePropertyChanged("Color");
            }
        }

        public ObservableCollection<object> Assignees
        {
            get { return assignees; }
            set
            {
                assignees = value;
                this.RaisePropertyChanged("Assignees");
            }
        }
    }
}
