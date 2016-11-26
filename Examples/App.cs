using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bridge.ChartJS;
using Bridge.Html5;

namespace Examples
{
    public class App
    {
        static IEnumerable<int> Random(int count)
        {
            var random = new Random();
            for (int i = 1; i <= count; i++)
                yield return random.Next(1, 100);
        }

        public static void Main()
        {
            var canvas = Document.GetElementById("chartCanvas") as HTMLCanvasElement;

            var lineChart = new Chart(canvas, new ChartConfig
            {
                Type = ChartType.Radar,
                Data = new DataConfig
                {
                    Labels = new string[] { "Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running" },
                    Datasets = new Dataset[]
                    {
                        new RadarDataset
                        {
                            Label = "Today",
                            Data = new int[] { 65, 59, 90, 81, 56, 55, 40 },
                            PointRadius = 10,
                            PointHoverRadius = 5,
                            BackgroundColor = "rgba(0, 100, 255, 0.4)",
                            PointHoverBackgroundColor = "blue",
                        },
                        new RadarDataset
                        {
                            Label = "Yesterday",
                            Data = new int [] { 28, 48, 40, 19, 96, 27, 100 },
                            PointRadius = 10,
                            PointHoverRadius = 5,
                            BackgroundColor = "rgba(0, 255, 100, 0.4)",
                            PointHoverBackgroundColor = "green"
                        }
                    }
                }
            });


            Window.SetInterval(() =>
            {
                var fstDataset = lineChart.Data.Datasets[0].As<RadarDataset>();
                fstDataset.Data = Random(7).ToArray();

                var sndDataset = lineChart.Data.Datasets[1].As<RadarDataset>();
                sndDataset.Data = Random(7).ToArray();

                lineChart.Update();

            }, 2000);

        }
    }
}
