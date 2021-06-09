namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces
{
    public interface ISessionManager
    {
        public string GetMultiStepAction();
        public string GetNextStep();
        
    }
}