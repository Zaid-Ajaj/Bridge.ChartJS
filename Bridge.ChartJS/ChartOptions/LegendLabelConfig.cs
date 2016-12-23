using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class LegendLabelConfig
    {
        /// <summary>
        /// Width of coloured box
        /// </summary>
        public int BoxWidth = 40;

        /// <summary>
        /// Font size inherited from global configuration
        /// </summary>
        public int FontSize = 12;
        /// <summary>
        /// Font style inherited from global configuration
        /// </summary>
        public string FontStyle = "normal";
        /// <summary>
        /// Font color inherited from global configuration
        /// </summary>
        public string FontColor = "#666";
        /// <summary>
        /// "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif"
        /// </summary>
        public string FontFamily = "'Helvetica Neue', 'Helvetica', 'Arial', sans-serif";
        /// <summary>
        /// Padding between rows of colored boxes
        /// </summary>
        public int Padding = 10;
        /// <summary>
        /// Generates legend items for each thing in the legend. Default implementation returns the text + styling for the color box
        /// </summary>
        public Action<Chart> GenerateLabels;
        /// <summary>
        /// Label style will match corresponding point style (size is based on fontSize, boxWidth is not used in this case).
        /// </summary>
        public bool UsePointStyle = false;
    }
}