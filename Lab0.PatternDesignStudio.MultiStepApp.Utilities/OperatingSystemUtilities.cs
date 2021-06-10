using System;
using System.Collections.Generic;
using System.IO;

namespace Lab0.PatternDesignStudio.MultiStepApp.Utilities
{
    public class OperatingSystemUtilities
    {
        public OperatingSystemUtilities()
        {
        }

        public static string DirectoriesBelowCurrent(params string[] dirs)
        {
            var dirsToCombind = new List<string>()
            {
                Environment.CurrentDirectory
            };
            dirsToCombind.AddRange(dirs);
            return Path.Combine(dirsToCombind.ToArray());
        }
        public static string CreateDirectoryIfNotExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            return directory;
        }
    }
}