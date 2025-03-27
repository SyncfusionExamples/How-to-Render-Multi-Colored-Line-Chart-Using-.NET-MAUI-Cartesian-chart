using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColoredLineChart
{
    public class RainfallViewModel
    {
        public ObservableCollection<RainfallData> Data { get; set; }
        public List<Brush> CustomBrushes { get; set; }

        public RainfallViewModel()
        {
            Data = new ObservableCollection<RainfallData>
            {
                new RainfallData { Year = 2001, Rainfall = 400 },
                new RainfallData { Year = 2002, Rainfall = 380 },
                new RainfallData { Year = 2003, Rainfall = 500 },
                new RainfallData { Year = 2004, Rainfall = 420 },
                new RainfallData { Year = 2005, Rainfall = 460 },
                new RainfallData { Year = 2006, Rainfall = 410 },
                new RainfallData { Year = 2007, Rainfall = 530 },
                new RainfallData { Year = 2008, Rainfall = 470 },
                new RainfallData { Year = 2009, Rainfall = 480 },
                new RainfallData { Year = 2010, Rainfall = 390 },
                new RainfallData { Year = 2011, Rainfall = 510 },
                new RainfallData { Year = 2012, Rainfall = 440 },
                new RainfallData { Year = 2013, Rainfall = 500 },
                new RainfallData { Year = 2014, Rainfall = 430 },
                new RainfallData { Year = 2015, Rainfall = 540 },
                new RainfallData { Year = 2016, Rainfall = 460 },
                new RainfallData { Year = 2017, Rainfall = 470 },
                new RainfallData { Year = 2018, Rainfall = 400 },
                new RainfallData { Year = 2019, Rainfall = 520 },
                new RainfallData { Year = 2020, Rainfall = 450 },
            };

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
}
