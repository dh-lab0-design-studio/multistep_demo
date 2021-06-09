namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Models
{
    public class MultiStepState
    {
        public string SessionId { get; }
        public string PreviousState { get; private init; } = "";
        public string CurrentState { get; private init; } = "";

        public MultiStepState SetNextState(string nextState) =>
            new(SessionId)
            {
                PreviousState = CurrentState,
                CurrentState = nextState
            };


        public MultiStepState(string sessionId)
        {
            SessionId = sessionId;
        }
    }
}