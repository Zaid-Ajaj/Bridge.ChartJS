using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class PointLabelConfig
    {
        /// <summary>
        /// Font size in pixels
        /// </summary>
        public int FontSize;
        /// <summary>
        /// Font Style to use
        /// </summary>
        public string FontStyle;
        /// <summary>
        /// Font family to render
        /// </summary>
        public string FontFamily;
        /// <summary>
        /// Font color
        /// </summary>
        public Color FontColor;
        /// <summary>
        /// Callback function to transform data label to axis label
        /// </summary>
        public dynamic Callback;
    }
}