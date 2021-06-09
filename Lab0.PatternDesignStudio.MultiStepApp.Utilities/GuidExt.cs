using System;

namespace Lab0.PatternDesignStudio.MultiStepApp.Utilities
{
    /// <summary>
    /// GUID Extension Methods and other random miscilanous utilities 
    /// </summary>
    public static class GuidExt
    {
        /// <summary>
        /// This function will generate a random string
        /// </summary>
        /// <returns>a Random lowercaase alphanumeric string </returns>
        public static string ToRandomString() => Guid.NewGuid().ToString("N");
    }
}
