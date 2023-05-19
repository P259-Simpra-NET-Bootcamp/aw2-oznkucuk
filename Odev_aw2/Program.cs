﻿using Microsoft.AspNetCore.Hosting;

namespace Odev_aw2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Application is starting...");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
                   .ConfigureWebHostDefaults(webBuilder =>
                   {
                       webBuilder.UseStartup<Startup>();
                   });
    }
}
