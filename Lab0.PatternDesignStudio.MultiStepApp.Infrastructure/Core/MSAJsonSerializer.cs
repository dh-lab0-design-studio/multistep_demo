using System.Text.Json;
using Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces;

namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Core
{
    public class MsaJsonSerializer : IMultiStepSerializer
    {
        public string ToStateSerialized<T>(T state) => JsonSerializer.Serialize(state);

        public T ToStateDeserialized<T>(string state) => JsonSerializer.Deserialize<T>(state);
    }
}