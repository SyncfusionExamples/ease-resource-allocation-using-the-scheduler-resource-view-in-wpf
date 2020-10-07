# Ease resource allocation using the scheduler resource view in wpf

You can easily manage and allocate the resources in a calendar view by controlling the project tasks, time sheets, and employee’s availability in a manual approach by using scheduler resource view.

## Resource Grouping 
You can allocate the tasks to the employees either by date basis with the available resource or resource basis with the available dates by using the [ResourceGroupType](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceGroupType) API in [Scheduler](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html) class. 

## Resource sharing
You are free to assign as many resources as you wish to a task by assigning the Id of the resources in [ResourceIdCollection](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html#Syncfusion_UI_Xaml_Scheduler_ScheduleAppointment_ResourceIdCollection) API of the [ScheduleAppointment](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html) class.

## Data binding
You can create custom resource model with required field and it can be mapped to the equivalent properties in the [ResourceMapping](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceMapping) API in scheduler class. 

## Task reassignment
You can easily create, edit or delete the task dynamically using build in [editor](https://help.syncfusion.com/wpf/scheduler/appointment-editing) support, [drag and drop](https://help.syncfusion.com/wpf/scheduler/appointment-drag-and-drop) support and appointment [resizing](https://help.syncfusion.com/wpf/scheduler/appointment-editing#appointment-resizing) support in Scheduler control.

## Resource availability
You can easy manage and track the absence and unavailability of the resources by using the [SpecialTimeRegions](https://help.syncfusion.com/wpf/scheduler/daysview#special-time-regions) support,

{% tabs %}       
{% highlight c# %}   
{% endhighlight %}   

{% highlight xaml %}   
{% endhighlight %}   
{% endtabs %}   

{% tabs %}       
{% highlight c# %}   
/// <summary>   
/// Represents custom data properties.   
/// </summary> 
public class Employee
{
    public string Name { get; set; }
    public object ID { get; set; }
    public Brush BackgroundBrush { get; set; }
    public Brush ForegroundBrush { get; set; }
}
{% endhighlight %}   
{% endtabs %}

{% tabs %}       
{% highlight c# %}   
// Custom resource collection in the view model.
public ObservableCollection<object> Employees { get; set; }
{% endhighlight %}   
{% endtabs %}

{% tabs %}       
{% highlight c# %}  
// Adding employee details in custom resource property.
for (int i = 0; i < 3; i++)
{
    Employee employee = new Employee();
    employee.Name = nameCollection[i];
    employee.BackgroundBrush = this.colorCollection[random.Next(8)];
    employee.ID = i.ToString();
    Employees.Add(employee);
}
{% endhighlight %}   
{% endtabs %}

{% tabs %}       
{% highlight c# %}
SpecialTimeRegion timeRegion = new SpecialTimeRegion();
timeRegion.Text = "Casual leave"
timeRegion.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(2).Day, 0, 0, 0);
timeRegion.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(3).Day, 0, 0, 0);
timeRegion.Background = new SolidColorBrush(Color.FromRgb(245, 245, 245));
timeRegion.ResourceIdCollection = new ObservableCollection<object>() { "1" };
scheduler.DaysViewSettings.SpecialTimeRegions = new ObservableCollection<SpecialTimeRegion>() { timeRegion };
{% endhighlight %}   
{% endtabs %}

{% tabs %}       
{% highlight xaml %}   
        <syncfusion:SfScheduler ViewType="WorkWeek"
                                ResourceGroupType="Resource"
                                ResourceCollection="{Binding Employees}"
                                ItemsSource="{Binding Tasks}">
            <syncfusion:SfScheduler.ResourceMapping>
                <syncfusion:ResourceMapping 
                    Id="ID" 
                    Name="Name" 
                    Background="BackgroundBrush" 
                    Foreground="ForegroundBrush"/>
            </syncfusion:SfScheduler.ResourceMapping>
        </syncfusion:SfScheduler>
{% endhighlight %}   
{% endtabs %}   

## Output

![SchedulerResourceView](https://github.com/SyncfusionExamples/ease-resource-allocation-using-the-scheduler-resource-view-in-wpf/blob/main/ResourceView/ScreenShot/wpf-scheduler-resource-availability.png)

## Customization
Scheduler resource view allows you to create different colors or even different views for resource view by using data templates and data-template selector support with [ResourceHeaderTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplate) and [ResourceHeaderTemplateSelector](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplateSelector) APIs in scheduler class.

![SchedulerTemplatedResourceView](https://github.com/SyncfusionExamples/ease-resource-allocation-using-the-scheduler-resource-view-in-wpf/blob/main/CustomResourceView/ScreenShot/wpf-scheduler-custom-resource-view.png)
