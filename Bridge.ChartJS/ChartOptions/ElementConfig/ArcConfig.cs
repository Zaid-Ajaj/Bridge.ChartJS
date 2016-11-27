using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;
    /// <summary>
    /// Arcs are used in the polar area, doughnut and pie charts
    /// </summary>
    [ObjectLiteral]
    public class ArcConfig
    {
        /// <summary>
        /// Default fill color for arcs. Inherited from the global default
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// Default stroke color for arcs
        /// </summary>
        public Color BorderColor;
        /// <summary>
        /// Default stroke width for arcs
        /// </summary>
        public int BorderWidth;
    }
}