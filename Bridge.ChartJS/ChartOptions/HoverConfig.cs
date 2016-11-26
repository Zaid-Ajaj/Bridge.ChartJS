using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    public class HoverConfig
    {
        /// <summary>
        /// Sets which elements appear in the tooltip
        /// </summary>
        public IntersectionMode Mode;

        /// <summary>
        /// if true, the hover mode only applies when the mouse position intersects an item on the chart
        /// </summary>
        public bool Intersect;

        /// <summary>
        /// Duration in milliseconds it takes to animate hover style changes
        /// </summary>
        public int AnimationDuration;

        /// <summary>
        /// Called when any of the events fire. Called in the context of the chart and passed an array of active elements (bars, points, etc)
        /// </summary>
        public Action<object[]> OnHover;
    }


    [Enum(Emit.StringName)]
    public enum IntersectionMode
    {
        /// <summary>
        /// Finds all of the items that intersect the point
        /// </summary>
        Point,
        /// <summary>
        /// Gets the item that is nearest to the point. The nearest item is determined based on the distance to the center of the chart item (point, bar). If 2 or more items are at the same distance, the one with the smallest area is used. If intersect is true, this is only triggered when the mouse position intersects an item in the graph. This is very useful for combo charts where points are hidden behind bars.
        /// </summary>
        Nearest,
        /// <summary>
        /// Finds item at the same index. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index. 
        /// </summary>
        Index,
        /// <summary>
        /// Finds items in the same dataset. If the intersect setting is true, the first intersecting item is used to determine the index in the data. If intersect false the nearest item is used to determine the index.
        /// </summary>
        Dataset,
        /// <summary>
        /// Returns all items that would intersect based on the X coordinate of the position only. Would be useful for a vertical cursor implementation. Note that this only applies to cartesian charts
        /// </summary>
        X,
        /// <summary>
        /// Returns all items that would intersect based on the Y coordinate of the position. This would be useful for a horizontal cursor implementation. Note that this only applies to cartesian charts.
        /// </summary>
        Y
    }
}