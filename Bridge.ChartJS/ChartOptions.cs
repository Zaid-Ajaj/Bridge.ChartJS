using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    public class ChartOptions
    {
        /// <summary>
        /// Resizes the chart canvas when its container does.
        /// </summary>
        public bool Responsive = true;
        /// <summary>
        /// Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        public int ResponsiveAnimationDuration = 0;
        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing
        /// </summary>
        public bool MaintainAspectRatio = true;

        /// <summary>
        /// Events that the chart should listen to for tooltips and hovering
        /// </summary>
        public string[] Event = new string[] { "mousemove", "mouseout", "click", "touchstart", "touchmove", "touchend" };
        /// <summary>
        /// Called if the event is of type 'mouseup' or 'click'. Called in the context of the chart and passed an array of active elements
        /// </summary>
        public Action OnClick;
        /// <summary>
        /// Function to generate a legend. Receives the chart object to generate a legend from. Default implementation returns an HTML string.
        /// </summary>
        public Func<Chart, string> LegendCallback;

        public Action<Chart, object> OnResize;
        /// <summary>
        /// Legend configuration
        /// </summary>
        public LegendConfig Legend;
        /// <summary>
        /// Title configuration
        /// </summary>
        public TitleConfig Title;
        /// <summary>
        /// Layout config
        /// </summary>
        public LayoutConfig Layout;
        /// <summary>
        /// Tooltip config
        /// </summary>
        public TooltipConfig Tooltips;
        /// <summary>
        /// Hover configuration 
        /// </summary>
        public HoverConfig Hover;

    }
}