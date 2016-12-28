using Bridge.Html5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ChartJS
{
    using Context = Union<string, HTMLElement, CanvasRenderingContext2D>;

    [External]
    public class Chart
    {
        [Template("new Chart({0}, {1})")]
        public Chart(Context ctx, ChartConfig options)
        {

        }

        /// <summary>
        /// Triggers an update of the chart. This can be safely called after replacing the entire data object. This will update all scales, legends, and then re-render the chart.
        /// </summary>
        public extern void Update();

        /// <summary>
        /// Use this to destroy any chart instances that are created. This will clean up any references stored to the chart object within Chart.js, along with any associated event listeners attached by Chart.js. This must be called before the canvas is reused for a new chart.
        /// </summary>
        public extern void Distroy();

        /// <summary>
        /// Triggers an update of the chart. This can be safely called after replacing the entire data object. This will update all scales, legends, and then re-render the chart.
        /// </summary>
        public extern void Update(int duration, bool lazy);

        /// <summary>
        /// Reset the chart to it's state before the initial animation. A new animation can then be triggered using update
        /// </summary>
        public extern void Reset();

        /// <summary>
        /// Triggers a redraw of all chart elements. Note, this does not update elements for new data. Use .update() in that case.
        /// </summary>
        /// <param name="duration">the time for the animation of the redraw in milliseconds</param>
        /// <param name="lazy">if true, the animation can be interrupted by other animations</param>
        public extern void Render(int duration, bool lazy);

        /// <summary>
        /// Use this to stop any current animation loop. This will pause the chart during any current animation frame. Call .render() to re-animate.
        /// </summary>
        public extern void Stop();

        /// <summary>
        /// Use this to manually resize the canvas element. This is run each time the canvas container is resized, but you can call this method manually if you change the size of the canvas nodes container element.
        /// </summary>
        public extern Chart Resize();

        /// <summary>
        /// Will clear the chart canvas. Used extensively internally between animation frames, but you might find it useful.
        /// </summary>
        /// <returns>this</returns>
        public extern Chart Clear();

        /// <summary>
        /// This returns a base 64 encoded string of the chart in it's current state
        /// </summary>
        /// <returns></returns>
        public extern string ToBase64Image();

        /// <summary>
        /// Returns an HTML string of a legend for that chart. The legend is generated from the legendCallback in the options.
        /// </summary>
        /// <returns></returns>
        public extern string GenerateLegend();

        /// <summary>
        /// Calling getElementAtEvent(event) on your Chart instance passing an argument of an event, or jQuery event, will return the single element at the event position. If there are multiple items within range, only the first is returned
        /// </summary>
        public extern HTMLElement GetElementAtEvent(Event ev);

        /// <summary>
        /// Looks for the element under the event point, then returns all elements at the same data index. This is used internally for 'label' mode highlighting. Calling getElementsAtEvent(event) on your Chart instance passing an argument of an event, or jQuery event, will return the point elements that are at that the same position of that event.
        /// </summary>
        public extern HTMLElement[] GetElementsAtEvent(Event ev);

        
        public DataConfig Data;

        [Template("Chart.defaults")]
        public static extern Defaults Defaults();
    }
}
