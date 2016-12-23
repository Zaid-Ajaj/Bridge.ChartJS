using Bridge;
using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class PointConfig
    {
        /// <summary>
        /// Default point radius
        /// </summary>
        public int Radius;
        /// <summary>
        /// Default point style
        /// </summary>
        public PointSyles PointStyle;
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
        /// Extra radius added to point radius for hit detection
        /// </summary>
        public int HitRadius;
        /// <summary>
        /// Default point radius when hovered
        /// </summary>
        public int HoverRadius;
        /// <summary>
        /// Default stroke width when hovered
        /// </summary>
        public int HoverBorderWidth;

    }
}
