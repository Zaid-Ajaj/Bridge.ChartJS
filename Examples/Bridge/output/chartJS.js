﻿Bridge.assembly("Bridge.ChartJS", function ($asm, globals) {
    "use strict";

    Bridge.define("ChartJS.ChartType", {
        $kind: "enum",
        statics: {
            line: "line",
            bar: "bar",
            horizontalBar: "horizontalBar",
            radar: "radar",
            bubble: "bubble",
            pie: "pie",
            doughnut: "doughnut",
            polarArea: "polarArea"
        },
        $utype: System.String
    });

    Bridge.define("ChartJS.Extensions");

    Bridge.define("ChartJS.IntersectionMode", {
        $kind: "enum",
        statics: {
            /**
             * Finds all of the items that intersect the point
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 0
             * @type ChartJS.IntersectionMode
             */
            point: "point",
            /**
             * Gets the item that is nearest to the point. The nearest item is determined based on the distance to the center of the chart item (point, bar). If 2 or more items are at the same distance, the one with the smallest area is used. If intersect is true, this is only triggered when the mouse position intersects an item in the graph. This is very useful for combo charts where points are hidden behind bars.
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 1
             * @type ChartJS.IntersectionMode
             */
            nearest: "nearest",
            /**
             * Finds item at the same index. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index.
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 2
             * @type ChartJS.IntersectionMode
             */
            index: "index",
            /**
             * Finds items in the same dataset. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index.
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 3
             * @type ChartJS.IntersectionMode
             */
            dataset: "dataset",
            /**
             * Returns all items that would intersect based on the X coordinate of the position only. Would be useful for a vertical cursor implementation. Note that this only applies to cartesian charts
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 4
             * @type ChartJS.IntersectionMode
             */
            x: "x",
            /**
             * Returns all items that would intersect based on the Y coordinate of the position. This would be useful for a horizontal cursor implementation. Note that this only applies to cartesian charts.
             *
             * @static
             * @public
             * @memberof ChartJS.IntersectionMode
             * @constant
             * @default 5
             * @type ChartJS.IntersectionMode
             */
            y: "y"
        },
        $utype: System.String
    });

    Bridge.define("ChartJS.PointSyles", {
        $kind: "enum",
        statics: {
            circle: "circle",
            triangle: "triangle",
            rect: "rect",
            rectRot: "rectRot",
            cross: "cross",
            crossRot: "crossRot",
            star: "star",
            line: "line",
            dash: "dash"
        },
        $utype: System.String
    });

    Bridge.define("ChartJS.Position", {
        $kind: "enum",
        statics: {
            top: "top",
            left: "left",
            right: "right",
            bottom: "bottom"
        },
        $utype: System.String
    });
});
