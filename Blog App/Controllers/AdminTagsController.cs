using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;
using System;
using Blog_App.Models.ViewModels;

namespace Blog_App.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        /*  (By Reading Incoming Requests)
         * 
         
        [HttpPost]
        [ActionName("Add")]
        //   The[ActionName("Add")] attribute renames the action method so that it can be accessed
        //   via the URL /AdminTags/Add even though the method name is SubmitTag.

//        Without[ActionName("Add")]:
//        - public IActionResult Add() → /AdminTags/Add ✅
//        - public IActionResult SubmitTag() → /AdminTags/SubmitTag ❌ (wrong URL)
        public IActionResult SubmitTag()
        {
            var name = Request.Form["name"];
            var dispName = Request.Form["dispName"];

            return View("Add");
            //  View("Add") explicitly specifies the view file to load(i.e., Add.cshtml)
            //    and loads the same view again
        }


        *
        */

        // (By Model Binding)
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var name = addTagRequest.Name;
            var displayName = addTagRequest.DisplayName;

            return View("Add");
        }

    }
}
