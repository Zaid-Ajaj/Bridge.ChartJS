using Bridge.Html5;

namespace Bridge.ChartJS
{

    using Number = Union<int, double, float, byte>;

    using NumberOrNumbers = Union<int, double, int[], double[]>;

    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class BubbleDataset : Dataset
    {
        public BubbleDataPoint[] Data;
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips
        /// </summary>
        public string Label;
        /// <summary>
        /// The fill color under the line
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// The color of the line.
        /// </summary>
        public Color BorderColor;
        /// <summary>
        /// Point background color when hovered
        /// </summary>
        public Color HoverBackgroundColor;
        /// <summary>
        /// Border width of bar in pixels
        /// </summary>
        public NumberOrNumbers BorderWidth;
        /// <summary>
        /// border color when hovered
        /// </summary>
        public Color HoverBorderColor;
        /// <summary>
        /// Border width when hovered
        /// </summary>
        public NumberOrNumbers HoverBorderWidth;
        /// <summary>
        /// Additional radius to add to data radius on hover
        /// </summary>
        public NumberOrNumbers HoverRadius;
    }


    [ObjectLiteral]
    public class BubbleDataPoint
    {
        [Name("x")]
        public Number X;
        [Name("y")]
        public Number Y;
        /// <summary>
        /// Radius of the bubble
        /// </summary>
        [Name("r")]
        public Number Radius; 
    }
}