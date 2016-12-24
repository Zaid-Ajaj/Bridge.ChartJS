using Bridge;
using Bridge.Html5;
using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class ScaleConfig
    {
        /// <summary>
        /// Type of scale being employed.
        /// </summary>
        public ScaleType Scale;
        /// <summary>
        /// If true, show the scale including gridlines, ticks, and labels. Overrides gridLines.display, scaleLabel.display, and ticks.display.
        /// </summary>
        public bool Display;
        /// <summary>
        /// Position of the scale
        /// </summary>
        public Position Position;
        /// <summary>
        /// The ID is used to link datasets and scale axes together. The properties datasets.xAxisID or datasets.yAxisID have to match the scale properties scales.xAxes.id or scales.yAxes.id. This is especially needed if multi-axes charts are used.
        /// </summary>
        public string Id;
        /// <summary>
        /// Callback called before the update process starts
        /// </summary>
        public Action<ScaleConfig> BeforeUpdate;
        /// <summary>
        /// Callback that runs before dimensions are set
        /// </summary>
        public Action<ScaleConfig> BeforeSetDimensions;
        /// <summary>
        /// Callback that runs after dimensions are set. 
        /// </summary>
        public Action<ScaleConfig> AfterSetDimensions;
        /// <summary>
        /// Callback that runs before data limits are determined
        /// </summary>
        public Action<ScaleConfig> BeforeDataLimits;
        /// <summary>
        /// Callback that runs after data limits are determined
        /// </summary>
        public Action<ScaleConfig> AfterDataLimits;
        /// <summary>
        /// Callback that runs before ticks are created
        /// </summary>
        public Action<ScaleConfig> BeforeBuildTicks;
        /// <summary>
        /// Callback that runs after ticks are created
        /// </summary>
        public Action<ScaleConfig> AfterBuildTicks;
        /// <summary>
        /// Callback that runs before ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        public Action<ScaleConfig> BeforeTickToLabelConversion;
        /// <summary>
        /// Callback that runs after ticks are converted into strings
        /// </summary>
        public Action<ScaleConfig> AfterTickToLabelConversion;
        /// <summary>
        /// Callback that runs before tick rotation is determined
        /// </summary>
        public Action<ScaleConfig> BeforeCalculateTickRotation;
        /// <summary>
        /// Callback that runs after tick rotation is determined
        /// </summary>
        public Action<ScaleConfig> AfterCalculateTickRotation;
        /// <summary>
        /// Callback that runs before the scale fits to the canvas
        /// </summary>
        public Action<ScaleConfig> BeforeFit;
        /// <summary>
        /// Callback that runs after the scale fits to the canvas
        /// </summary>
        public Action<ScaleConfig> AfterFit;
        /// <summary>
        /// Callback that runs at the end of the update process
        /// </summary>
        public Action<ScaleConfig> AfterUpdate;
        /// <summary>
        /// Ticks configurations
        /// </summary>
        public TicksConfig Ticks;
        /// <summary>
        /// Time configurations
        /// </summary>
        public TimeConfig Time;
        /// <summary>
        /// If true, circular arcs are used else straight lines are used. The former is used by the polar area chart and the latter by the radar chart
        /// </summary>
        public bool LineArc;
        /// <summary>
        /// Config for angle lines, The following options are used to configure angled lines that radiate from the center of the chart to the point labels. They can be found in the angleLines sub options. Note that these options only apply if lineArc is false.
        /// </summary>
        public AngleLineConfig AngleLines;

    }

    [Enum(Emit.StringName)]
    public enum ScaleType
    {
        Category,
        Linear,
        Logarithmic,
        Time,
        RadialLinear
    }
}
