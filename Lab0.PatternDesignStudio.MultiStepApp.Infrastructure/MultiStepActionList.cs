using System;
using System.Collections.Generic;

namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure
{
    public class MultiStepActionList
    {
        private Dictionary<string, Func<string, string>> ActionList { get; } = new();
        
    }
}