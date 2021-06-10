using System;
using System.IO;
using Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces;
using Lab0.PatternDesignStudio.MultiStepApp.Utilities;

namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Core
{
    
    
    public class MsaFlatFileStorage : IMultiStepStorage
    {
        private readonly IMultiStepSerializer _serializer;
        private readonly string _baseDirectory = OperatingSystemUtilities.DirectoriesBelowCurrent("MultiStepStorage");

        private static string SessionSection(string sessionId, string section) =>
            Path.Combine(
                OperatingSystemUtilities.CreateDirectoryIfNotExists(
                    OperatingSystemUtilities.DirectoriesBelowCurrent("MultiStepStorage", sessionId)
                    ), $"{section}.json");

        public MsaFlatFileStorage(IMultiStepSerializer serializer)
        {
            _serializer = serializer;
            OperatingSystemUtilities.CreateDirectoryIfNotExists(_baseDirectory);
        }

        public T LoadFromDocumentStateStore<T>(string documentId, string section) => 
            _serializer.ToStateDeserialized<T>(File.ReadAllText(SessionSection(documentId, section)));

        public void SaveToDocumentStateStore<T>(string documentId, string section, T documentState) => 
            File.WriteAllText(SessionSection(documentId,section), _serializer.ToStateSerialized(documentState));
    }
}