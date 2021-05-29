#define  DEBUG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppCore.Exceptions;
using AppCore.Services;
using ExceptionTestLab;
using Lab8;
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
            //Lab8.FirstTask.DoTask();
            
            var fileTask = new FileTask(@"Data\text.txt");
            fileTask.DoTask();


        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}