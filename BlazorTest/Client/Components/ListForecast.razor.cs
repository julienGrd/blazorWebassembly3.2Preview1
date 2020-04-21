﻿using BlazorTest.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Components
{
    public partial class ListForecast
    {
        [Parameter]
        public IEnumerable<WeatherForecast> Items { get; set; }

        protected override void OnAfterRender(bool firstRender)
        {
            Console.WriteLine("ListForecast onAfterRender");
            base.OnAfterRender(firstRender);
        }
    }
}