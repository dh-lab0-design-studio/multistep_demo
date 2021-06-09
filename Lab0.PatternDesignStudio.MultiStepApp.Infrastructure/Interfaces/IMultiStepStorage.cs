namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces
{
    public interface IMultiStepStorage
    {
        T LoadFromDocumentStateStore<T>(string documentId, string section);
        void SaveToDocumentStateStore<T>(string documentId, string section, T documentState);
    }
}