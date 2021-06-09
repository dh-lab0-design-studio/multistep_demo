using System;
using Lab0.PatternDesignStudio.MultiStepApp.Infrastructure;
using Lab0.PatternDesignStudio.MultiStepApp.Models;
using Lab0.PatternDesignStudio.MultiStepApp.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.PatternDesignStudio.MultiStepApp.Controllers
{
    public class HomeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(string execAction) => 
            MultiExecActions.ActionsCanBeExecuted.ContainsKey(execAction) ? 
                MultiExecActions.ActionsCanBeExecuted[execAction].Invoke(GuidExt.ToRandomString(), "") : 
                NotFound();
    }
}