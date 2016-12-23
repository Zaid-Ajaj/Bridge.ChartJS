using Bridge.Html5;

namespace Bridge.ChartJS
{
    using Number = Union<int, double>;
    using NumberOrNumbers = Union<int, double, int[], double[]>;

    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    [ObjectLiteral]
    [External]
    public class RadarDataset : Dataset
    {
        public Union<int[], double[], decimal[]> Data;
        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips
        /// </summary>
        public string Label;
        /// <summary>
        /// If true, fill the area under the line
        /// </summary>
        public bool Fill;
        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. This option is ignored if monotone cubic interpolation is used. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public Number LineTension;
        /// <summary>
        /// Algorithm used to interpolate a smooth curve from the discrete data points. Options are 'default' and 'monotone'. The 'default' algorithm uses a custom weighted cubic interpolation, which produces pleasant curves for all types of datasets. The 'monotone' algorithm is more suited to y = f(x) datasets : it preserves monotonicity (or piecewise monotonicity) of the dataset being interpolated, and ensures local extremums (if any) stay at input data points. If left untouched (undefined), the global options.elements.line.cubicInterpolationMode property is used.
        /// </summary>
        public string CubicInterpolationMode;
        /// <summary>
        /// The fill color under the line
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// The color of the line.
        /// </summary>
        public Color BorderColor;
        /// <summary>
        /// Cap style of the line
        /// </summary>
        public string BorderCapStyle;
        /// <summary>
        /// Length and spacing of dashes. 
        /// </summary>
        public NumberOrNumbers BorderDash;
        /// <summary>
        /// Offset for line dashes
        /// </summary>
        public Number BorderDashOffset;
        /// <summary>
        /// Line joint style
        /// </summary>
        public string BorderJoinStyle;
        /// <summary>
        /// The border color for points.
        /// </summary>
        public Color PointBorderColor;
        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events
        /// </summary>
        public NumberOrNumbers HitRadius;
        /// <summary>
        /// The fill color for points
        /// </summary>
        public Color PointBackgroundColor;
        /// <summary>
        /// The width of the point border in pixels
        /// </summary>
        public Color PointBorderWidth;
        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered. 
        /// </summary>
        public Number PointRadius;
        /// <summary>
        /// The radius of the point when hovered
        /// </summary>
        public Number PointHoverRadius;
        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events
        /// </summary>
        public Number PointHitRadius;
        /// <summary>
        /// Point background color when hovered
        /// </summary>
        public Color PointHoverBackgroundColor;
        /// <summary>
        /// Point border color when hovered
        /// </summary>
        public Color PointHoverBorderColor;
        /// <summary>
        /// Border width of point when hovered
        /// </summary>
        public Number PointHoverBorderWidth;
        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage. 
        /// </summary>
        public Union<PointSyles, PointSyles[]> PointStyle;
        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'. If the option is an image, that image is drawn on the canvas using drawImage. 
        /// </summary>
        [Name("pointStyle")]
        public Union<ImageData, ImageData[]> PointSyleAsImage;
    }
}