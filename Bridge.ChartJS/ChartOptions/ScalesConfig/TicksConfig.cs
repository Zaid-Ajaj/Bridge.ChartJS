using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;
    using Number = Union<int, double>;

    [ObjectLiteral]
    [External]
    public class TicksConfig
    {
        /// <summary>
        /// If true, automatically calculates how many labels that can be shown and hides labels accordingly. Turn it off to show all labels no matter what
        /// </summary>
        public bool AutoSkip;
        /// <summary>
        /// Padding between the ticks on the horizontal axis when autoSkip is enabled. Note: Only applicable to horizontal scales.
        /// </summary>
        public int AutoSkipPadding;
        /// <summary>
        /// If true, show the ticks.
        /// </summary>
        public bool Display;
        /// <summary>
        /// Font color for the tick labels
        /// </summary>
        public Color FontColor;
        /// <summary>
        /// Font family for the tick labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily;
        /// <summary>
        /// Font size for the tick labels.
        /// </summary>
        public int FontSize;
        /// <summary>
        /// Distance in pixels to offset the label from the centre point of the tick (in the y direction for the x axis, and the x direction for the y axis). Note: this can cause labels at the edges to be cropped by the edge of the canvas
        /// </summary>
        public int LabelOffset;
        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
        /// </summary>
        public Union<int, double, float> MaxRotation;
        /// <summary>
        /// Minimum rotation for tick labels. Note: Only applicable to horizontal scales.
        /// </summary>
        public Union<int, double, float> MinRotation;
        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        public bool Mirror;
        /// <summary>
        /// Padding between the tick label and the axis. Note: Only applicable to horizontal scales.
        /// </summary>
        public int Padding;
        /// <summary>
        /// Reverses order of tick labels.
        /// </summary>
        public bool Reverse;
        /// <summary>
        /// if true, scale will include 0 if it is not already included.
        /// </summary>
        public bool BeginAtZero;
        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public Number Min;
        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public Number Max;
        /// <summary>
        /// Maximum number of ticks and gridlines to show. If not defined, it will limit to 11 ticks but will show all gridlines.
        /// </summary>
        public int MaxTicksLimit;
        /// <summary>
        /// User defined fixed step size for the scale. If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. If not set, the ticks are labeled automatically using the nice numbers algorithm.
        /// </summary>
        public Number FixedStepSize;
        /// <summary>
        /// if defined, it can be used along with the min and the max to give a custom number of steps. See the example below.
        /// </summary>
        public Number StepSize;
        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value except for if it is lower than the maximum value.
        /// </summary>
        public Number SuggestedMax;
        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value except for if it is higher than the minimum value.
        /// </summary>
        public Number SuggestedMin;
        /// <summary>
        /// Color of label backdrops
        /// </summary>
        public Color BackdropColor;
        /// <summary>
        /// Horizontal padding of label backdrop
        /// </summary>
        [Name("backdropPaddingX")]
        public Number BackdropPaddingX;
        /// <summary>
        /// Vertical padding of label backdrop
        /// </summary>
        [Name("backdropPaddingY")]
        public Number BackdropPaddingY;
        /// <summary>
        /// If true, draw a background behind the tick labels
        /// </summary>
        public bool ShowLabelBackdrop;
    }
}