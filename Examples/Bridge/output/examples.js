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

            var lineChart = new Chart(canvas, { type: "radar", data: { yLabels: [""], labels: ["Eating", "Drinking", "Sleeping", "Designing", "Coding", "Cycling", "Running"], datasets: [{ label: "Today", data: [65, 59, 90, 81, 56, 55, 40], pointRadius: 10, pointHoverRadius: 5, backgroundColor: "rgba(0, 100, 255, 0.4)", pointHoverBackgroundColor: "blue" }, { label: "Yesterday", data: [28, 48, 40, 19, 96, 27, 100], pointRadius: 10, pointHoverRadius: 5, backgroundColor: "rgba(0, 255, 100, 0.4)", pointHoverBackgroundColor: "green" }] } });


            window.setInterval(function () {
                var fstDataset = lineChart.data.datasets[0];
                fstDataset.data = System.Linq.Enumerable.from(Examples.App.random(7)).toArray();

                var sndDataset = lineChart.data.datasets[1];
                sndDataset.data = System.Linq.Enumerable.from(Examples.App.random(7)).toArray();

                lineChart.update();

            }, 2000);

        }
    });
});
