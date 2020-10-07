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
    public class SchedulerViewModel : NotificationObject
    {
        private ObservableCollection<Employee> employees;
        private ObservableCollection<Task> tasks;

        private List<string> nameCollection;
        /// <summary>
        /// color collection
        /// </summary>
        private List<Brush> colorCollection;
        public SchedulerViewModel()
        {
            this.Tasks = new ObservableCollection<Task>();
            this.CreateNameCollection();
            this.CreateColorCollection();
            this.InitializeResources();
            this.CreateTasks();
        }

        public ObservableCollection<Employee> Employees
        {
            get
            {
                return employees;
            }

            set
            {
                employees = value;
                this.RaisePropertyChanged("Employees");
            }
        }

        /// <summary>
        /// list appointment collection
        /// </summary>
        public ObservableCollection<Task> Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
                this.RaisePropertyChanged("Tasks");
            }
        }

        private void InitializeResources()
        {
            Random random = new Random();
            this.Employees = new ObservableCollection<Employee>();
            for (int i = 1; i < 4; i++)
            {
                Employee employee = new Employee();
                employee.Name = nameCollection[i];
                employee.ForegroundBrush = new SolidColorBrush(Colors.White);
                employee.BackgroundBrush = this.colorCollection[i - 1];
                employee.ID = i.ToString();
                employee.ImageSource = "/Assets/People_Circle" + i.ToString() + ".png";

                if (employee.ID.Equals("1"))
                {
                    employee.Designation = "(Team leader)";
                }
                else if (employee.ID.Equals("2"))
                {
                    employee.Designation = "(Developer)";
                }
                else
                {
                    employee.Designation = "(Tester)";
                }

                this.Employees.Add(employee);
            }
        }

        #region BookingAppointments

        /// <summary>
        /// Method for booking appointments.
        /// </summary>
        private void CreateTasks()
        {
            DateTime date = DateTime.Now.Date;

            // Appointments of first Resource.
            // Normal appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 15, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 19, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 21, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 13, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 14, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 13, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 17, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 13, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 15, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 19, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 21, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 13, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 14, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 15, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });

            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 14, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 09, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 18, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 16, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 10, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 18, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 09, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });

            //Sapnned appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 2, 11, 0, 0), To = new DateTime(date.Year, date.Month, 7, 12, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 8, 14, 0, 0), To = new DateTime(date.Year, date.Month, 15, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 16, 10, 0, 0), To = new DateTime(date.Year, date.Month, 21, 11, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 23, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 2, 6, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });

            //All day appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 5, 19, 0, 0), To = new DateTime(date.Year, date.Month, 5, 20, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 10, 14, 0, 0), To = new DateTime(date.Year, date.Month, 10, 15, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "Plan Execution", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")), Assignees = new ObservableCollection<object> { "1" } });

            // Appointments of second Resource.
            // Normal appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 11, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 14, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 20, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 13, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 12, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 16, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 12, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 20, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 13, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 12, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });

            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 15, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 10, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 13, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 16, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 19, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 17, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 11, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 19, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 09, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 11, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 16, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 19, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });

            //Sapnned appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 1, 11, 0, 0), To = new DateTime(date.Year, date.Month, 6, 12, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 7, 14, 0, 0), To = new DateTime(date.Year, date.Month, 14, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 19, 10, 0, 0), To = new DateTime(date.Year, date.Month, 26, 11, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 27, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 1, 6, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });

            //All day appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 6, 19, 0, 0), To = new DateTime(date.Year, date.Month, 6, 20, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 11, 14, 0, 0), To = new DateTime(date.Year, date.Month, 11, 15, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "Plan Execution", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")), Assignees = new ObservableCollection<object> { "2" } });

            // Appointments of third Resource.
            // Normal appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 11, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 14, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 20, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 13, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 12, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 14, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 16, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 14, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 15, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 13, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 12, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });

            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 14, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 09, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 12, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), Title = "Knowledge share", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 18, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 16, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 10, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 18, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 11, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), Title = "Performance check", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), Title = "Testing", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), Title = "Bug fix", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });

            //Sapnned appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 3, 11, 0, 0), To = new DateTime(date.Year, date.Month, 10, 12, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 13, 14, 0, 0), To = new DateTime(date.Year, date.Month, 16, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 17, 10, 0, 0), To = new DateTime(date.Year, date.Month, 25, 11, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 27, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 3, 6, 0, 0), Title = "Plan Execution", Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });

            //All day appointments.
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 5, 19, 0, 0), To = new DateTime(date.Year, date.Month, 5, 20, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 10, 14, 0, 0), To = new DateTime(date.Year, date.Month, 10, 15, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Bug fix", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "Plan Execution", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
            this.Tasks.Add(new Task() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Performance check", IsAllDay = true, Color = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")), Assignees = new ObservableCollection<object> { "3" } });
        }

        #endregion BookingAppointments

        #region Creating name collection
        private void CreateNameCollection()
        {
            this.nameCollection = new List<string>();
            this.nameCollection.Add("Sophia");
            this.nameCollection.Add("Kinsley Elena");
            this.nameCollection.Add("Adeline Ruby");
            this.nameCollection.Add("Kinsley Ruby");
            this.nameCollection.Add("Emilia");
            this.nameCollection.Add("Daniel");
            this.nameCollection.Add("Adeline Elena");
            this.nameCollection.Add("Emilia William");
            this.nameCollection.Add("James William");
            this.nameCollection.Add("Zoey Addison");
            this.nameCollection.Add("Danial William");
            this.nameCollection.Add("Stephen Addison");
            this.nameCollection.Add("Stephen");
            this.nameCollection.Add("Danial Addison");
            this.nameCollection.Add("Brooklyn");
        }
        #endregion Creating name collection


        #region creating color collection
        /// <summary>
        /// color collection
        /// </summary>
        ////creating color collection
        private void CreateColorCollection()
        {
            this.colorCollection = new List<Brush>();
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#9d65c9")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f08a5d")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#679b9b")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF1BA1E2")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFF09609")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF00ABA9")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD80073")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFA2C139")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFE671B8")));
            this.colorCollection.Add(new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF339933")));
        }

        #endregion creating color collection
    }
}
