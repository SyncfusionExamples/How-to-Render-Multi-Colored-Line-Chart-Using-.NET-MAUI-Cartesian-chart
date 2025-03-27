# How to Render Multi-Colored Line Chart Using .NET MAUI Cartesian chart
This article explains how to render a multi-colored line chart in .NET MAUI [SfCartesianChart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). You can use the [PaletteBrushes](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartSeries.html#Syncfusion_Maui_Toolkit_Charts_ChartSeries_PaletteBrushes) property to apply different colors to the line series, allowing you to achieve a visually distinct multi-colored line. 

Additionally, the chart also supports the [PaletteBrushes](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.SfCartesianChart.html#Syncfusion_Maui_Toolkit_Charts_SfCartesianChart_PaletteBrushes) property, which can be used to apply custom palette brushes to the chart

By following these steps, you can create a multi-colored line series in SfCartesianChart

**Step 1: Define the ViewModel with Custom Brushes**

In the ViewModel, create a list of brushes that will be used to color different segments of the line series.

**[C#]**
```
public class RainfallViewModel
{
    public ObservableCollection<RainfallData> Data { get; set; }

    public List<Brush> CustomBrushes { get; set; }

    public RainfallViewModel()
    {
        . . .
        CustomBrushes = new List<Brush>
        {
            new SolidColorBrush(Color.FromRgb(255, 167, 38)),  
            new SolidColorBrush(Color.FromRgb(255, 167, 38)),
            new SolidColorBrush(Color.FromRgb(255, 167, 38)),
            new SolidColorBrush(Color.FromRgb(255, 167, 38)),
            new SolidColorBrush(Color.FromRgb(233, 30, 99)),  
            new SolidColorBrush(Color.FromRgb(233, 30, 99)),
            new SolidColorBrush(Color.FromRgb(233, 30, 99)),
            new SolidColorBrush(Color.FromRgb(233, 30, 99)),
            new SolidColorBrush(Color.FromRgb(33, 150, 243)),  
            new SolidColorBrush(Color.FromRgb(33, 150, 243)),
            new SolidColorBrush(Color.FromRgb(33, 150, 243)),
            new SolidColorBrush(Color.FromRgb(33, 150, 243)),
            new SolidColorBrush(Color.FromRgb(0, 188, 212)),   
            new SolidColorBrush(Color.FromRgb(0, 188, 212)),
            new SolidColorBrush(Color.FromRgb(0, 188, 212)),
            new SolidColorBrush(Color.FromRgb(0, 188, 212)),
            new SolidColorBrush(Color.FromRgb(76, 175, 80)), 
            new SolidColorBrush(Color.FromRgb(76, 175, 80)),
            new SolidColorBrush(Color.FromRgb(76, 175, 80)),
            new SolidColorBrush(Color.FromRgb(76, 175, 80)),
        };
    }
}
```

**Step 2:  Applying PaletteBrushes to the Series**

Set the CustomBrushes collection to the [PaletteBrushes](https://help.syncfusion.com/cr/maui-toolkit/Syncfusion.Maui.Toolkit.Charts.ChartSeries.html#Syncfusion_Maui_Toolkit_Charts_ChartSeries_PaletteBrushes) property of the Line series. 
**[XAML]**
```
<chart:SfCartesianChart>
    . . .
    <chart:LineSeries ItemsSource="{Binding Data}"
                      XBindingPath="Year"
                      YBindingPath="Rainfall"
                      PaletteBrushes="{Binding CustomBrushes}">
    </chart:LineSeries>
</chart:SfCartesianChart>
```
**[C#]**
```
SfCartesianChart chart = new SfCartesianChart();
. . .
LineSeries series = new LineSeries()
{
    ItemsSource = new ViewModel().Data,
    XBindingPath = "Year",
    YBindingPath = "Rainfall",
    PaletteBrushes = new ViewModel().CustomBrushes
};

chart.Series.Add(series);
this.Content = chart;
```
**Output**
 ![MultiColoredLineChart.png](https://support.syncfusion.com/kb/agent/attachment/article/19737/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM3ODY5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.HKkmE6oUup9D4987Qbt4qhPPfM416GeeBeXXuzbGdQU)

**Troubleshooting**

Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For more details, refer to the KB on [how to Render Multi-Colored Line Chart Using .NET MAUI Cartesian chart]().