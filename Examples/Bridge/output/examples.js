/**
 * @version 1.0.0.0
 * @copyright Copyright ©  2016
 * @compiler Bridge.NET 15.4.0
 */
Bridge.assembly("Examples", function ($asm, globals) {
    "use strict";

    Bridge.define("Examples.App", {
        statics: {
            random: function (count) {
                var $yield = [];
                var random = new System.Random.ctor();
                for (var i = 1; i <= count; i = (i + 1) | 0) {
                    $yield.push(random.next$2(1, 100));
                }
                return System.Array.toEnumerable($yield);
            }
        },
        $main: function () {
            var canvas = Bridge.as(document.getElementById("chartCanvas"), HTMLCanvasElement);

            var radarChart = new Chart(canvas, { type: "radar", data: { labels: ["Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running"], datasets: [{ label: "Today", data: [65, 59, 90, 81, 56, 55, 40], pointRadius: 10, pointHoverRadius: 5, backgroundColor: "rgba(0, 100, 255, 0.4)", pointHoverBackgroundColor: "blue" }, { label: "Yesterday", data: [28, 48, 40, 19, 96, 27, 100], pointRadius: 10, pointHoverRadius: 5, backgroundColor: "rgba(0, 255, 100, 0.4)", pointHoverBackgroundColor: "green" }] } });


            //Window.SetInterval(() =>
            //{
            //    var fstDataset = radarChart.Data.Datasets[0].As<RadarDataset>();
            //    fstDataset.Data = Random(7).ToArray();

            //    var sndDataset = radarChart.Data.Datasets[1].As<RadarDataset>();
            //    sndDataset.Data = Random(7).ToArray();

            //    radarChart.Update();

            //}, 2000);

        }
    });
});
