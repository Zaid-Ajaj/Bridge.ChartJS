### Intro
This library helps you utilize [Chart.js](http://www.chartjs.org/) library in your Bridge.NET project in a type-safe way.

### Installation
Copy and paste the contents of [Generated.ChartJS.cs](https://github.com/Zaid-Ajaj/Bridge.ChartJS/blob/master/Bridge.ChartJS/Generated.ChartJS.cs) to your project and thats it! 

Eample:

Include Chart.js in your html page
```html
<script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.4.0/Chart.min.js"></script>
```

Define a canvas
```html
<div style="width: 500px; height: 400px;">
     <canvas id="chartCanvas"></canvas>
</div>
```

```csharp
// App.cs
var canvas = Document.GetElementById("chartCanvas") as HTMLCanvasElement;
var radarChart = new Chart(canvas, new ChartConfig
{
    Type = ChartType.Radar,
    Data = new DataConfig
    {
        Labels = new [] { "Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running" },
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
```

Will generate 

![untitled](https://cloud.githubusercontent.com/assets/13316248/20636915/ec212524-b376-11e6-9675-d56bbf2d6ba8.png)
