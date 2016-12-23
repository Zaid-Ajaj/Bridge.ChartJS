using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [Enum(Emit.StringName)]
    public enum Position
    {
        Top, Left, Right, Bottom
    }

    

    [ObjectLiteral]
    [External]
    public class TitleConfig
    {
        /// <summary>
        /// Display the title block
        /// </summary>
        public bool Display = false;
        /// <summary>
        /// Position of the title.
        /// </summary>
        public Position Position = Position.Top;
        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes)
        /// </summary>
        public bool FullWidth = true;
        /// <summary>
        /// Font size inherited from global configuration
        /// </summary>
        public int FontSize = 12;
        /// <summary>
        /// Font family inherited from global configuration
        /// </summary>
        public string FontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
        /// <summary>
        /// Font color 
        /// </summary>
        public Color FontColor = "#666";
        /// <summary>
        /// Font style, default is 'bold'
        /// </summary>
        public string FontStyle = "bold";
        /// <summary>
        /// Number of pixels to add above and below the title text
        /// </summary>
        public int Padding = 10;
        /// <summary>
        /// Title text
        /// </summary>
        public string Text = "";
    }
}