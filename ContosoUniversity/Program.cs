﻿// This application entry point is based on ASP.NET Core new project templates and is included
// as a starting point for app host configuration.
// This file may need updated according to the specific scenario of the application being upgraded.
// For more information on ASP.NET Core hosting, see https://docs.microsoft.com/aspnet/core/fundamentals/host/web-host

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Google.Cloud.Logging.Console;

namespace ContosoUniversity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(AddSecretConfig)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    if (webBuilder.GetSetting("ENVIRONMENT") == "Production")
                    {
                        // Configure the console logger
                        webBuilder.ConfigureLogging(loggingBuilder => loggingBuilder
                            .AddConsoleFormatter<GoogleCloudConsoleFormatter, GoogleCloudConsoleFormatterOptions>(options => options.IncludeScopes = true)
                            .AddConsole(options => options.FormatterName = nameof(GoogleCloudConsoleFormatter)));
                    }
                    webBuilder.UseStartup<Startup>();
                });

        private static void AddSecretConfig(HostBuilderContext context, 
            IConfigurationBuilder config) 
        {
            string secretsPath = context.Configuration.GetValue("SECRETS_PATH", 
                "secrets");
            
            var secretFileProvider = context.HostingEnvironment.ContentRootFileProvider
                .GetDirectoryContents(secretsPath);
            
            if (secretFileProvider.Exists)
            {
                foreach (var secret in secretFileProvider)
                {
                    if (!secret.IsDirectory && secret.Name.ToUpper().EndsWith(".JSON"))
                        config.AddJsonFile(secret.PhysicalPath, false, true);
                }
            }
        }
    }
}
