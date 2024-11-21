using SpeedyAirModels;

namespace ProcessingManager{

    public class OrderProcessingManager
    {
        /// <summary>
        /// Assign Orders To Flights
        /// </summary>
        /// <param name="lstFlightData">List Flight Data</param>
        /// <param name="lstOrderInfo">List Order Info</param>
        /// <returns>List of Tuple of OrderInfo and FlightDetails</returns>
        public static List<Tuple<OrdersInfo,FlightDetails?>>  AssignOrdersToFlights(List<FlightDetails> lstFlightData, List<OrdersInfo> lstOrderInfo)
        {
            List<Tuple<OrdersInfo,FlightDetails?>> listTupleAssignment = new List<Tuple<OrdersInfo, FlightDetails?>>();
            if(lstFlightData != null && lstOrderInfo != null && lstFlightData.Count > 0 && lstOrderInfo.Count > 0)
            {
                foreach(var order in lstOrderInfo)
                {
                    bool flightAssigned = false;
                    foreach(var flight in lstFlightData)
                    {
                        if(order.OrderDestination == flight.ArrivalCity && flight.FlightBoxCapacity > 0)
                        {
                            listTupleAssignment.Add(new Tuple<OrdersInfo, FlightDetails?>(order,flight));
                            flight.FlightBoxCapacity = flight.FlightBoxCapacity - 1;
                            flightAssigned = true;
                            break;
                        }
                    }
                    if(!flightAssigned)
                    {
                        listTupleAssignment.Add(new Tuple<OrdersInfo, FlightDetails?>(order,null));
                    }
                }
            }
            return listTupleAssignment;
        }
    }
}