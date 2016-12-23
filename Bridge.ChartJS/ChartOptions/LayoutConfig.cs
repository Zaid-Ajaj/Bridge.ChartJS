namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class LayoutPadding
    {
        public int Left;
        public int Right;
        public int Top;
        public int Bottom;
    }
    
    [ObjectLiteral]
    [External]
    public class LayoutConfig
    {

        /// <summary>
        /// The padding to add inside the chart. If this value is a number, it is applied to all sides of the chart (left, top, right, bottom). If this value is an object, the left property defines the left padding. Similarly the right, top, and bottom properties can also be specified.
        /// </summary>
        public Union<int, LayoutPadding> Padding = 0;
    }
}