namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Models
{
    public class MultiStepNavigatorState
    {
        public string SessionId { get; }
        public string PreviousState { get; private init; } = "";
        public string CurrentState { get; private init; } = "";

        public string Message { get; private init; } = "";

        public MultiStepNavigatorState SetNextState(string nextState) =>
            new(SessionId)
            {
                PreviousState = CurrentState,
                CurrentState = nextState,
                Message = Message
            };

        public MultiStepNavigatorState SetPreviousState() =>
            new MultiStepNavigatorState(SessionId)
            {
                CurrentState = PreviousState,
                PreviousState = CurrentState,
                Message = Message
            };
        
        public MultiStepNavigatorState SetMessage(string message) =>
            new(SessionId)
            {
                PreviousState = PreviousState,
                CurrentState = CurrentState,
                Message = message
            };


        public MultiStepNavigatorState(string sessionId)
        {
            SessionId = sessionId;
        }
    }
}