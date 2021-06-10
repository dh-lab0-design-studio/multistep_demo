using Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Models;

namespace Lab0.PatternDesignStudio.MultiStepApp.Infrastructure.Interfaces
{
    public interface IMultiStepSpecificHandler<TSectionState> where TSectionState : MultiStepSectionState
    {
        MultiStepNavigatorState Validate(TSectionState sectionState);
        
    }
    
    
}