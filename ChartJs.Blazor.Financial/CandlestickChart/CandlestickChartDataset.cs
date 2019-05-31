using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.Financial.Common;

namespace ChartJs.Blazor.Financial.CandlestickChart
{
    public class CandlestickChartDataset
    {
        // public string Type { get; set; } = ChartTypeFactory.CreateCandlestick().ToString();

        /// <summary>
        /// The label for the dataset which appears in the legend and tooltips.
        /// </summary>
        public string Label { get; set; } = "";

        /// <summary>
        /// The color of the candlestick in the dataset.
        /// </summary>
        /// <value></value>

        public CandlestickColor Color { get; set; }

        /// <summary>
        /// The border color of the candlestick border in the dataset.
        /// </summary>
        public CandlestickColor BorderColor { get; set; }

        public List<Candlestick> Data { get; set; }
    }
}