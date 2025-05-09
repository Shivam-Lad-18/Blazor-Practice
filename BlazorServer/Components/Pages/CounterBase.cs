﻿using Microsoft.AspNetCore.Components;

namespace BlazorServer.Components.Pages
{
    public class CounterBase : ComponentBase
    {
        protected int currentCount = 0;
        protected void IncrementCount()
        {
            currentCount++;
        }
        public int CurrentCount => currentCount;
    }
}
