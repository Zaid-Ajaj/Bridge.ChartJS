using Bridge;
using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;
    using Number = Union<int, double>;

    [ObjectLiteral]
    [External]
    public class LineConfig
    {
        /// <summary>
        /// Default bezier curve tension. Set to 0 for no bezier curves.
        /// </summary>
        public Number Tension;
        /// <summary>
        /// Default line fill color
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// Default line stroke width
        /// </summary>
        public int BorderWidth;

        /// <summary>
        /// Default line stroke color
        /// </summary>
        public Color BorderColor;
        /// <summary>
        /// Default line cap style
        /// </summary>
        public string BorderCapStyle;
        /// <summary>
        /// Default line dash
        /// </summary>
        public int[] BorderDash;
        /// <summary>
        /// Default line dash offset
        /// </summary>
        public double BorderDashOffset;
        /// <summary>
        /// Default line join style
        /// </summary>
        public string BorderJoinStyle;
        /// <summary>
        /// If true, bezier control points are kept inside the chart. If false, no restriction is enforced.
        /// </summary>
        public bool CapBezierPoints;
        /// <summary>
        /// If true, the fill is assumed to be to zero. String values are 'zero', 'top', and 'bottom' to fill to different locations. If false, no fill is added
        /// </summary>
        public Union<string, bool> Fill;
        /// <summary>
        /// If true, the line is shown as a stepped line and 'tension' will be ignored
        /// </summary>
        public bool Stepped;
    }
}
