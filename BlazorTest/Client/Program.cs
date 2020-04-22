﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using BlazorTest.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Net.Http;

namespace BlazorTest.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
