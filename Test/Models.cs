namespace SpeedyAirModels
{
    /// <summary>
    /// Flight Details class to maintain flight information
    /// </summary>
    public class FlightDetails
    {
        public int FlightNumber { get; }
        public string DepartureCity { get; }
        public string ArrivalCity { get; }
        public int Day { get; }
        public int FlightBoxCapacity { get; set;}

        public FlightDetails(int flightNumber, string departureCity, string arrivalCity, int day, int flightBoxCapacity)
        {
            FlightNumber = flightNumber;
            DepartureCity = departureCity;
            ArrivalCity = arrivalCity;
            Day = day;
            FlightBoxCapacity = flightBoxCapacity;
        }
    }

    /// <summary>
    /// Orders Info class to maintain order information
    /// </summary>
    public class OrdersInfo
    {
        public string OrderNumber { get; }
        public string OrderDestination { get; }

        public OrdersInfo(string orderNumber, string orderDestination)
        {
            OrderNumber = orderNumber;
            OrderDestination = orderDestination;
        }
    }
}