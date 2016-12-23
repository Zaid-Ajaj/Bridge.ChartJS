namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class ElementConfig
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts
        /// </summary>
        public ArcConfig Arc;
        /// <summary>
        /// Line elements are used to represent the line in a line chart
        /// </summary>
        public LineConfig Line;
        /// <summary>
        /// Point elements are used to represent the points in a line chart or a bubble chart. 
        /// </summary>
        public PointConfig Point;
        /// <summary>
        /// Rectangle elements are used to represent the bars in a bar chart
        /// </summary>
        public RectangleConfig Rectangle;
    }
}