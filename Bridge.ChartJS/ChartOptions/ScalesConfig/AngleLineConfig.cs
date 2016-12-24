using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Number = Union<int, double>;
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class AngleLineConfig
    {
        /// <summary>
        /// If true, angle lines are shown.
        /// </summary>
        public bool Display;
        /// <summary>
        /// Color of angled lines
        /// </summary>
        public Color Color;
        /// <summary>
        /// Width of angled lines
        /// </summary>
        public Number LineWidth;
    }
}