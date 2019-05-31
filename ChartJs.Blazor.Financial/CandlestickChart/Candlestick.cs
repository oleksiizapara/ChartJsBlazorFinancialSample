namespace ChartJs.Blazor.Financial.CandlestickChart
{

    // t: date.valueOf(),
    // o: open,
    // h: high,
    // l: low,
    // c: close
    public class Candlestick
    {
        public decimal T { get; set; }
        public decimal O { get; set; }
        public decimal H { get; set; }
        public decimal L { get; set; }
        public decimal C { get; set; }
    }
}