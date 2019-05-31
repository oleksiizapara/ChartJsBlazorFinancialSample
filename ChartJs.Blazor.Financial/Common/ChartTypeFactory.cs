using System;
using System.Reflection;
using ChartJs.Blazor.ChartJS.Common;

namespace ChartJs.Blazor.Financial.Common
{
    public static class ChartTypeFactory
    {
        public static ChartTypes CreateCandlestick() =>
         Construct<ChartTypes>(
             new Type[] { typeof(string) },
             new object[] { "candlestick" }
         );

        public static ChartTypes CreateOhlc() =>
        Construct<ChartTypes>(
            new Type[] { typeof(string) },
            new object[] { "ohlc" }
        );

        public static T Construct<T>(Type[] paramTypes, object[] paramValues)
        {
            Type t = typeof(T);

            ConstructorInfo ci = t.GetConstructor(
                BindingFlags.Instance | BindingFlags.NonPublic,
                null, paramTypes, null);

            return (T)ci.Invoke(paramValues);
        }
    }
}