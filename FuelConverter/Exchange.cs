using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FuelConverter
{
    internal class Exchange
    {
        async static Task<string> GetCurrentExchange()
        {
            string res = "";

            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                res = await response.Content.ReadAsStringAsync();
            }

            return res;
        }

        public async static Task<double> Convert(double uah)
        {
            var res = await Exchange.GetCurrentExchange();
            var exchangeRates = JsonSerializer.Deserialize<List<ExchangeRate>>(res);

            var usdExchange = exchangeRates.Find(rate => rate.ccy == "USD");
            if (usdExchange != null)
            {
                try
                {
                    string salePriceString = usdExchange.sale.Trim();
                    if (double.TryParse(salePriceString, NumberStyles.Float, CultureInfo.InvariantCulture, out double usdSalePrice))
                    {
                        double convertedValue = uah / usdSalePrice;
                        convertedValue = Math.Round(convertedValue, 2);
                        return convertedValue;
                    }
                    else
                    {
                        return 0.0;
                    }
                }
                catch (Exception e)
                {
                    return 0.0;
                }
            }
            else
            {
                return 0.0;
            }
        }



    }

    public class ExchangeRate
    {
        public string ccy { get; set; }
        public string base_ccy { get; set; }
        public string buy { get; set; }
        public string sale { get; set; }
    }


}
