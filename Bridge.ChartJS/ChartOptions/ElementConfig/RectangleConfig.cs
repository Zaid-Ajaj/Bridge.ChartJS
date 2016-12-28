using Bridge;
using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class RectangleConfig
    {
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
        /// Default skipped (excluded) border for rectangle.
        /// </summary>
        public BorderSkippedPattern BorderSkipped;
    }

    [Enum(Emit.StringName)]
    [External]
    public enum BorderSkippedPattern
    {
        Top,
        Bottom,
        Left,
        Right
    }
}
