namespace Bridge.ChartJS
{
    [ObjectLiteral]
    [External]
    public class TimeConfig
    {
        public DiplayFormatConfig DisplayFormats;
        /// <summary>
        /// If true and the unit is set to 'week', iso weekdays will be used.
        /// </summary>
        public bool IsoWeekday;
        /// <summary>
        /// The moment js format string to use for the tooltip.
        /// </summary>
        public bool TooltipFormat;
        /// <summary>
        /// If defined, will force the unit to be a certain type. See Time Units section below for details.
        /// </summary>
        public TimeUnit Unit;
        /// <summary>
        /// The minimum display format to be used for a time unit
        /// </summary>
        public TimeUnit MinUnit;
        /// <summary>
        /// The number of units between grid lines.
        /// </summary>
        public Union<int, double> UnitStepSize;
        /// <summary>
        /// If defined, dates will be rounded to the start of this unit. See Time Units below for the allowed units.
        /// </summary>
        public string Round;
    }

    [Enum(Emit.StringName)]
    public enum TimeUnit
    {
        Millisecond,
        Second,
        Minute,
        Hour,
        Day,
        Week,
        Month,
        Quarter,
        Year
    }
}