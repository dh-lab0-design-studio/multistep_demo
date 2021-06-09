using Lab0.PatternDesignStudio.MultiStepApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.PatternDesignStudio.MultiStepApp.Controllers
{
    
    public class MultiStepAppController : Controller
    {
        
        [HttpGet("msa/{documentId}/{step?}", Name = "MultiStepDispatcher")]
        public IActionResult DocumentStepRouter(string documentId, string? step)
        {
            var stepView = "Index";
            if (step != null)
            {
                stepView = step;
            }
            return View(stepView, new DocumentViewModel()
            {
                Step = stepView,
                DocumentId = documentId
            });
        }
    }
}