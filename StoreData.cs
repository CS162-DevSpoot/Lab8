using System;

namespace Ch14_Lab8
{
    public class StoreData
    {
        public DateTime Date { get; set; }
        public decimal ClosingValue { get; set; }
        public decimal OpeningValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal LowValue { get; set; }

        public StoreData(DateTime date, decimal closingValue, decimal openingValue, decimal highValue, decimal lowValue) {

            Date = date;
            ClosingValue = closingValue;
            OpeningValue = openingValue;
            HighValue = highValue;
            LowValue = lowValue;
        }
    }
}
