﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Ocelot.Middleware;
using Ocelot.DependencyInjection;

namespace ApiGateway
{
	public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

		public static IWebHostBuilder CreateWebHostBuilder(string[] args)
		=>	WebHost.CreateDefaultBuilder(args)
				.ConfigureAppConfiguration((host, config) =>
				{
					config.AddJsonFile("ocelot.json");
				})
				.UseStartup<Startup>();
    }
}
