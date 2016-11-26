using Bridge.Html5;
using System;

namespace Bridge.ChartJS
{
    [ObjectLiteral]
    public class LegendConfig
    {
        /// <summary>
        /// Is the legend displayed, default is true
        /// </summary>
        public bool Display = true;
        /// <summary>
        /// Position of the legend. 
        /// </summary>
        public Position Position = Position.Top;
        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes)
        /// </summary>
        public bool FullWidth = true;
        /// <summary>
        /// Legend will show datasets in reverse order
        /// </summary>
        public bool Reverse = false;
        /// <summary>
        /// A callback that is called when a 'click' event is registered on top of a label item
        /// </summary>
        public Action<Event, object> OnClick;
        /// <summary>
        /// A callback that is called when a 'mousemove' event is registered on top of a label item
        /// </summary>
        public Action<Event, object> OnHover;
        /// <summary>
        /// label configuration of legend
        /// </summary>
        public LegendLabelConfig Labels;

    }
}