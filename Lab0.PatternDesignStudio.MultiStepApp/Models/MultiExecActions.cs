using System;
using System.Collections.Generic;
using Lab0.PatternDesignStudio.MultiStepApp.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Lab0.PatternDesignStudio.MultiStepApp.Models
{
    public class MultiExecActions
    {
        public static Dictionary<string, Func<string, string, IActionResult>> ActionsCanBeExecuted = new()
        {
            {
                MultiStepActions.CreateSession,
                (documentId,step ) => new RedirectToRouteResult("MultiStepDispatcher", new {documentId, step = string.Empty})
            }
        };
    }
}