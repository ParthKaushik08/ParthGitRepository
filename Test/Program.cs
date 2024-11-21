using System;
using System.Collections.Generic;
using SpeedyAirModels;
using ProcessingManager;
using Reader;
using OutputClass;


namespace SpeedyAir
{    
    class Program
    {
        /// <summary>
        /// Main method to start the execution of the program
        /// </summary>
        static void Main()
        {
            List<FlightDetails> listFlightDetails = new List<FlightDetails>();
            List<OrdersInfo> lstOrderInfo = new List<OrdersInfo>();
            List<Tuple<OrdersInfo,FlightDetails?>>  lstTupAssignmentInfo = new List<Tuple<OrdersInfo, FlightDetails?>>();
            try
            {
                listFlightDetails =  ReadData.CreateFlightDetails();
                OutputData.PrintFlightDetails(listFlightDetails);
                lstOrderInfo = ReadData.ReadOrderDataFromJson();
                lstTupAssignmentInfo = OrderProcessingManager.AssignOrdersToFlights(listFlightDetails,lstOrderInfo);
                OutputData.PrintOrderProcessingInformation(lstTupAssignmentInfo);
                Console.WriteLine("\nOrder processing completed successfully!");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}