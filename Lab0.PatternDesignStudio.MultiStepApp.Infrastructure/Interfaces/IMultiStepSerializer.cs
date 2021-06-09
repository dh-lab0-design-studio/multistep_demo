namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces
{
    public interface IMultiStepSerializer
    {
        string ToStateSerialized<T>(T state);
        T ToStateDeserialized<T>(string state);
    }
}