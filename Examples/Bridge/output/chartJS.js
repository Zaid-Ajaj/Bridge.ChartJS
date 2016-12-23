Bridge.assembly("Bridge.ChartJS", function ($asm, globals) {
    "use strict";

    Bridge.define("ChartJS.AnimationConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.AnimationDetails", {
        $literal: true
    });

    Bridge.define("ChartJS.AnimationObject", {
        $literal: true
    });

    /** @namespace ChartJS */

    /**
     * Arcs are used in the polar area, doughnut and pie charts
     *
     * @public
     * @class ChartJS.ArcConfig
     */
    Bridge.define("ChartJS.ArcConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.Dataset", {
        $literal: true
    });

    Bridge.define("ChartJS.BorderSkippedPattern", {
        $kind: "enum",
        statics: {
            top: "top",
            bottom: "bottom",
            left: "left",
            right: "right"
        },
        $utype: System.String
    });

    Bridge.define("ChartJS.BubbleDataPoint", {
        $literal: true
    });

    Bridge.define("ChartJS.ChartConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.ChartOptions", {
        $literal: true
    });

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

    Bridge.define("ChartJS.DataConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.Defaults", {
        $literal: true
    });

    Bridge.define("ChartJS.ElementConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.Extensions");

    Bridge.define("ChartJS.HoverConfig", {
        $literal: true
    });

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

    Bridge.define("ChartJS.LabelColorObject", {
        $literal: true
    });

    Bridge.define("ChartJS.LayoutConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.LayoutPadding", {
        $literal: true
    });

    Bridge.define("ChartJS.LegendConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.LegendLabelConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.LineConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.LineDataPoint", {
        $literal: true
    });

    Bridge.define("ChartJS.PointConfig", {
        $literal: true
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

    Bridge.define("ChartJS.RectangleConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.ScaleConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.ScaleType", {
        $kind: "enum",
        statics: {
            category: "category",
            linear: "linear",
            logarithmic: "logarithmic",
            time: "time",
            radialLinear: "radialLinear"
        },
        $utype: System.String
    });

    Bridge.define("ChartJS.TitleConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.TooltipCallbacks", {
        $literal: true
    });

    Bridge.define("ChartJS.TooltipConfig", {
        $literal: true
    });

    Bridge.define("ChartJS.TooltipItem", {
        $literal: true
    });

    Bridge.define("ChartJS.BarDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });

    Bridge.define("ChartJS.BubbleDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });

    Bridge.define("ChartJS.LineDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });

    Bridge.define("ChartJS.PieOrDoughnutDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });

    Bridge.define("ChartJS.PolarAreaDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });

    Bridge.define("ChartJS.RadarDataset", {
        inherits: [ChartJS.Dataset],
        $literal: true
    });
});
