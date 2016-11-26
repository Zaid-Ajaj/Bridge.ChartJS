using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Number = Union<int, double>;
    using NumberOrNumbers = Union<int, double, int[], double[]>;

    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    public class BarDataset : Dataset
    {
        public Union<int[], double[], decimal[]> Data;
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips
        /// </summary>
        public string Label;
        /// <summary>
        /// The ID of the x axis to plot this dataset on
        /// </summary>
        [Name("xAxisID")]
        public string XAxisId;
        /// <summary>
        /// The ID of the y axis to plot this dataset on
        /// </summary>
        [Name("yAxisID")]
        public string YAxisId;
        /// <summary>
        /// The fill color under the line
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'
        /// </summary>
        public Union<string, string[]> BorderSkipped;

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
        public Number HoverBorderWidth;
    }
}