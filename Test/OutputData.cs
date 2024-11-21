using SpeedyAirModels;

namespace OutputClass
{
    public class OutputData
    {
        /// <summary>
        /// Method to Print the Flight Details as per User Story 1
        /// </summary>
        /// <param name="lstFlightDetails">List of Flight Details to be printed</param>
        public static void PrintFlightDetails(List<FlightDetails> lstFlightDetails)
        {
            Console.WriteLine("Flight Schedules:");
            foreach (var flight in lstFlightDetails)
            {
                Console.WriteLine("Flight: "+flight.FlightNumber+", departure: " + flight.DepartureCity+", arrival: "+flight.ArrivalCity+", day: "+flight.Day);
            }
        }

        /// <summary>
        /// Print Order Assignment data
        /// </summary>
        /// <param name="listTupleAssignment">List of Tuple Assignment</param>
        public static void PrintOrderProcessingInformation(List<Tuple<OrdersInfo,FlightDetails?>> listTupleAssignment)
        {
            Console.WriteLine("\nOrder Assignment Details:");
            foreach (var orderAssign in listTupleAssignment)
            {
                if(orderAssign !=null && orderAssign.Item1 != null && orderAssign.Item2 != null)
                {
                    Console.WriteLine("order: " + orderAssign.Item1.OrderNumber + ", flightNumber: "+ orderAssign.Item2.FlightNumber +", departure: "+ orderAssign.Item2.DepartureCity + ", arrival:" + orderAssign.Item2.ArrivalCity + ", day:" + orderAssign.Item2.Day);
                }
                else if (orderAssign !=null && orderAssign.Item1 != null)
                {
                    Console.WriteLine("order: " + orderAssign.Item1.OrderNumber + ", flightNumber: not scheduled");
                }
                else
                {
                    Console.WriteLine("order: order is null hence no assignment needed");
                }
            }
        }
    }
}