# Ease resource allocation using the scheduler resource view in wpf

You can easily manage and allocate the resources in a calendar view by controlling the project tasks, time sheets, and employee’s availability in a manual approach by using scheduler resource view.

**Resource Grouping**

You can allocate the tasks to the employees either by date basis with the available resource or resource basis with the available dates by using the [ResourceGroupType](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceGroupType) API in [Scheduler](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html) class. 

**Resource sharing**

You are free to assign as many resources as you wish to a task by assigning the Id of the resources in [ResourceIdCollection](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html#Syncfusion_UI_Xaml_Scheduler_ScheduleAppointment_ResourceIdCollection) API of the [ScheduleAppointment](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.ScheduleAppointment.html) class.

**Data binding**

You can create custom resource model with required field and it can be mapped to the equivalent properties in the [ResourceMapping](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceMapping) API in scheduler class. 

**Task reassignment**

You can easily create, edit or delete the task dynamically using build in [editor](https://help.syncfusion.com/wpf/scheduler/appointment-editing) support, [drag and drop](https://help.syncfusion.com/wpf/scheduler/appointment-drag-and-drop) support and appointment [resizing](https://help.syncfusion.com/wpf/scheduler/appointment-editing#appointment-resizing) support in Scheduler control.

**Resource availability**

You can easy manage and track the absence and unavailability of the resources by using the [SpecialTimeRegions](https://help.syncfusion.com/wpf/scheduler/daysview#special-time-regions) support,


``` c#
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
```

``` c# 
SpecialTimeRegion timeRegion = new SpecialTimeRegion();
timeRegion.Text = "Casual leave"
timeRegion.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(2).Day, 0, 0, 0);
timeRegion.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(3).Day, 0, 0, 0);
timeRegion.Background = new SolidColorBrush(Color.FromRgb(245, 245, 245));
timeRegion.ResourceIdCollection = new ObservableCollection<object>() { "1" };
scheduler.DaysViewSettings.SpecialTimeRegions = new ObservableCollection<SpecialTimeRegion>() { timeRegion };
```

``` xml   
        <syncfusion:SfScheduler ViewType="WorkWeek"
                                ResourceGroupType="Resource"
                                ItemsSource="{Binding Tasks}">
            <syncfusion:SfScheduler.ResourceMapping>
                <syncfusion:ResourceMapping 
                    Id="ID" 
                    Name="Name" 
                    Background="BackgroundBrush" 
                    Foreground="ForegroundBrush"/>
            </syncfusion:SfScheduler.ResourceMapping>
            <syncfusion:SfScheduler.ResourceCollection>
                <local:SchedulerResourceCollection>
                    <local:Employee Name="Sophia" ID="1" ForegroundBrush="White" BackgroundBrush="#9d65c9" />
                    <local:Employee Name="Kinsley Elena" ID="2" ForegroundBrush="White" BackgroundBrush="#f08a5d" />
                    <local:Employee Name="Adeline Ruby" ID="3" ForegroundBrush="White" BackgroundBrush="#679b9b" />
                </local:SchedulerResourceCollection>
            </syncfusion:SfScheduler.ResourceCollection>
        </syncfusion:SfScheduler>
```

**Output**

![SchedulerResourceView](https://github.com/SyncfusionExamples/ease-resource-allocation-using-the-scheduler-resource-view-in-wpf/blob/main/ResourceView/ScreenShot/wpf-scheduler-resource-availability.png)

**Customization**

Scheduler resource view allows you to create different colors or even different views for resource view by using data templates and data-template selector support with [ResourceHeaderTemplate](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplate) and [ResourceHeaderTemplateSelector](https://help.syncfusion.com/cr/wpf/Syncfusion.UI.Xaml.Scheduler.SfScheduler.html#Syncfusion_UI_Xaml_Scheduler_SfScheduler_ResourceHeaderTemplateSelector) APIs in scheduler class.

``` xml   
            <syncfusion:SfScheduler.ResourceHeaderTemplate>
                <DataTemplate>
                    <Grid Background="Transparent">
                        <StackPanel VerticalAlignment="Center" Orientation="Vertical">
                            <Border CornerRadius="36" Height="72" Width="72" BorderThickness="4" BorderBrush="{Binding BackgroundBrush}">
                                <Border CornerRadius="36" Height="64" Width="64" BorderThickness="4" BorderBrush="Transparent">
                                    <Image HorizontalAlignment="Center" VerticalAlignment="Center"
                                   Width="55"
                                   Height="55"
                                   Source="{Binding ImageSource}" />
                                </Border>
                            </Border>
                            <TextBlock HorizontalAlignment="Center"
                               VerticalAlignment="Center"
                               FontSize="15"
                               Text="{Binding Name}"/>
                            <TextBlock HorizontalAlignment="Center"
                               VerticalAlignment="Center"
                               FontSize="15"
                               Text="{Binding Designation}"/>
                        </StackPanel>
                    </Grid>
                </DataTemplate>
            </syncfusion:SfScheduler.ResourceHeaderTemplate>
```

**Output**

![SchedulerTemplatedResourceView](https://github.com/SyncfusionExamples/ease-resource-allocation-using-the-scheduler-resource-view-in-wpf/blob/main/CustomResourceView/ScreenShot/wpf-scheduler-custom-resource-view.png)
