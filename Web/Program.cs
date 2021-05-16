#define  DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore.Exceptions;
using AppCore.Services;
using ExceptionTestLab;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OurAirlines.AppCore.Entities;

namespace OurAirlines.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();

            BookingService bookingService = new BookingService();
            Console.WriteLine('\n' + "--------- Exception Tests ---------" + '\n');

            try
            {
                Passenger passenger = new Passenger("Oleksandr",
                    "Joestar",
                    "Patrontest",
                    "000202060",
                    25);

                Flight flight = bookingService.GetFlightById(0);
                bookingService.BuyTicket(flight, passenger, 1);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You should not use NULL objects as arguments in BuyTicket method");
            }
            catch (PlaneSeatIdOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            //TestTasks.InvalidCastExceptionTest();
            TestTasks.ArraysExceptionTest(8);
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}