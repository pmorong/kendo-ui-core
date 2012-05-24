namespace Kendo.Mvc.UI
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines a generic Chart axis.
    /// </summary>
    public interface IChartAxis
    {
        /// <summary>
        /// The axis major ticks configuration.
        /// </summary>
        ChartAxisTicks MajorTicks { get; set; }

        /// <summary>
        /// The axis minor ticks configuration.
        /// </summary>
        ChartAxisTicks MinorTicks { get; set; }

        /// <summary>
        /// The major grid lines configuration.
        /// </summary>
        ChartLine MajorGridLines { get; set; }

        /// <summary>
        /// The minor grid lines configuration.
        /// </summary>
        ChartLine MinorGridLines { get; set; }

        /// <summary>
        /// The axis line configuration.
        /// </summary>
        ChartLine Line { get; set; }

        /// <summary>
        /// The values at which perpendicular axes cross this axis.
        /// </summary>
        IEnumerable<double> AxisCrossingValues { get; set; }

        /// <summary>
        /// The axis labels.
        /// </summary>
        ChartAxisLabels Labels { get; set; }

        /// <summary>
        /// The axis plot bands.
        /// </summary>
        IList<ChartPlotBand> PlotBands { get; set; }

        /// <summary>
        /// The axis title.
        /// </summary>
        ChartAxisTitle Title { get; set; }

        /// <summary>
        /// The axis name. Leave empty to use the "primary" default value.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The color for all axis elements. Can be overriden by individual settings.
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// A value indicating if the axis labels should be rendered in reverse.
        /// </summary>
        bool? Reverse { get; set; }

        /// <summary>
        /// Gets the axis serializer.
        /// </summary>
        IChartSerializer CreateSerializer();
    }
}
