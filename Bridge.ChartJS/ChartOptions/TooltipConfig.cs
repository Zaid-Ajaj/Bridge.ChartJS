using Bridge.Html5;
using System;

namespace Bridge.ChartJS
{

    using Color = Union<string, CanvasGradient, CanvasPattern, string[], CanvasGradient[], CanvasPattern[]>;

    using TooltipCallback = Action<TooltipItem[], DataConfig>;

    using Strings = Union<string, string[]>;

    [ObjectLiteral]
    public class TooltipConfig
    {
        /// <summary>
        /// Are tooltips enabled
        /// </summary>
        public bool Enabled = true;
        /// <summary>
        /// Sets which elements appear in the tooltip. 
        /// </summary>
        public IntersectionMode Mode = IntersectionMode.Nearest;
        /// <summary>
        /// if true, the tooltip mode applies only when the mouse position intersects with an element. If false, the mode will be applied at all times.
        /// </summary>
        public bool Intersect = true;
        /// <summary>
        /// The mode for positioning the tooltip. 'average' mode will place the tooltip at the average position of the items displayed in the tooltip. 'nearest' will place the tooltip at the position of the element closest to the event position. New modes can be defined by adding functions to the Chart.Tooltip.positioners map.
        /// </summary>
        public string Position = "average";
        /// <summary>
        /// Allows sorting of tooltip items. Must implement at minimum a function that can be passed to Array.prototype.sort. This function can also accept a third parameter that is the data object passed to the chart
        /// </summary>
        public object ItemSort;
        /// <summary>
        /// Allows filtering of tooltip items. Must implement at minimum a function that can be passed to Array.prototype.filter. This function can also accept a second parameter that is the data object passed to the chart.
        /// </summary>
        public object Filter;
        /// <summary>
        /// Background color of the tooltip
        /// </summary>
        public Color BackgroundColor = "rgba(0,0,0,0.8)";
        /// <summary>
        /// Font family for tooltip title inherited from global font family
        /// </summary>
        public string TitleFontFamily;
        /// <summary>
        /// Font size for tooltip title inherited from global font size
        /// </summary>
        public int TitleFontSize = 12;

        public string TitleFontStyle;

        public Color TitleFontColor;

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public int TitleSpacing = 2;
        /// <summary>
        /// Margin to add on bottom of title section
        /// </summary>
        public int TitleMarginBottom = 6;

        public string BodyFontFamily;

        public int BodyFontSize = 12;

        public string BodyFontStyle;

        public Color BodyFontColor;

        public int BodySpacing = 2;

        public string FooterFontFamily;

        public int FooterFontSize = 12;

        public string FooterFontStyle;

        public Color FooterFontColor;

        public int FooterSpacing = 2;

        /// <summary>
        /// Padding to add on left and right of tooltip
        /// </summary>
        public int XPadding = 6;

        /// <summary>
        /// Padding to add on top and bottom of tooltip
        /// </summary>
        public int YPadding = 6;

        /// <summary>
        /// Size, in px, of the tooltip arrow
        /// </summary>
        public int CaretSize = 5;

        /// <summary>
        /// Radius of tooltip corner curves
        /// </summary>
        public int CornerRadius = 6;

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip
        /// </summary>
        public Color MultiKeyBackground;

        /// <summary>
        /// if true, color boxes are shown in the tooltip
        /// </summary>
        public bool DisplayColors;

        public TooltipCallbacks Callbacks;
    }


    [ObjectLiteral]
    public class TooltipCallbacks
    {
        /// <summary>
        /// Text to render before the title
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> BeforeTitle;
        /// <summary>
        /// Text to render as the title
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> Title;
        /// <summary>
        /// Text to render after the title
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> AfterTitle;
        /// <summary>
        /// Text to render before the body section
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> BeforeBody;
        /// <summary>
        /// Text to render before an individual label
        /// </summary>
        public Func<TooltipItem, DataConfig, Strings> BeforeLabel;
        /// <summary>
        /// Text to render for an individual item in the tooltip
        /// </summary>
        public Func<TooltipItem, DataConfig, Strings> Label;
        /// <summary>
        /// Returns the colors to render for the tooltip item. Return as an object containing two parameters: borderColor and backgroundColor.
        /// </summary>
        public Func<TooltipItem, Chart, LabelColorObject> LabelColor;
        /// <summary>
        /// Text to render after an individual label
        /// </summary>
        public Func<TooltipItem, DataConfig, Strings> AfterLabel;
        /// <summary>
        /// Text to render after the body section
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> AfterBody;
        /// <summary>
        /// Text to render before the footer section
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> BeforeFooter;
        /// <summary>
        /// Text to render as the footer
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> Footer;
        /// <summary>
        /// Text to render after the footer section
        /// </summary>
        public Func<TooltipItem[], DataConfig, Strings> AfterFooter;
        /// <summary>
        /// List of matching point informations
        /// </summary>
        public Func<TooltipItem[], Strings> DataPoints;


    }


    [ObjectLiteral]
    public class LabelColorObject
    {
        public Color BorderColor;
        public Color BackgroundColor;
    }


    [ObjectLiteral]
    public class TooltipItem
    {
        /// <summary>
        /// X Value of the tooltip as a string
        /// </summary>
        public string xLabel;
        /// <summary>
        /// Y value of the tooltip as a string
        /// </summary>
        public string yLabel;
        /// <summary>
        /// Index of the dataset the item comes from
        /// </summary>
        public int DatasetIndex;
        /// <summary>
        /// Index of this data item in the dataset
        /// </summary>
        public int Index;
        /// <summary>
        /// X position of matching point
        /// </summary>
        public int x;
        /// <summary>
        /// Y position of matching point
        /// </summary>
        public int y;
    }
}