using SpeedyAirModels;
using Newtonsoft.Json; 

namespace Reader
{
    public class ReadData
    {
        /// <summary>
        /// Create Flight Data
        /// </summary>
        /// <returns>List of Flight Details to be printed</returns>
        public static List<FlightDetails> CreateFlightDetails()
        {
            return new List<FlightDetails>
            {
                new FlightDetails(1, "YUL", "YYZ", 1, 20),
                new FlightDetails(2, "YUL", "YYC", 1, 20),
                new FlightDetails(3, "YUL", "YVR", 1, 20),
                new FlightDetails(4, "YUL", "YYZ", 2, 20),
                new FlightDetails(5, "YUL", "YYC", 2, 20),
                new FlightDetails(6, "YUL", "YVR", 2, 20)
            };
        }

        /// <summary>
        /// Read order data from Json
        /// </summary>
        /// <returns></returns>
        public static List<OrdersInfo> ReadOrderDataFromJson()
        {
            List<OrdersInfo> lstOrder= new List<OrdersInfo>();
            Dictionary<string,dynamic> dictData = new Dictionary<string, dynamic>();
            string jsonFlightOrderData = File.ReadAllText("coding-assigment-orders.json");
            dictData = !string.IsNullOrEmpty(jsonFlightOrderData) ? JsonConvert.DeserializeObject<Dictionary<string,dynamic>>(jsonFlightOrderData) ?? new Dictionary<string, dynamic>() : new Dictionary<string, dynamic>();
            if(dictData!=null)
            {
                foreach(var record in dictData)
                {
                    lstOrder.Add(
                        new OrdersInfo(record.Key,(string)record.Value.destination)
                    );
                }
            }
            return lstOrder;
        }
    }
}