using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.Financial.Common;

namespace ChartJs.Blazor.Financial.CandlestickChart
{
    public class CandlestickChartConfig : ChartConfigBase<CandlestickChartOptions, CandlestickChartData>
    {
        public CandlestickChartConfig() : base(ChartTypeFactory.CreateCandlestick()) { }
    }
}