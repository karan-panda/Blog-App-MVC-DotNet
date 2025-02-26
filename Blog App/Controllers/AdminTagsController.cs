using Microsoft.AspNetCore.Mvc;
using static Azure.Core.HttpHeader;
using System;
using Blog_App.Models.ViewModels;
using Blog_App.Data;
using Blog_App.Models.Domain;

namespace Blog_App.Controllers
{
    public class AdminTagsController : Controller
    {

        private readonly BlogDbContext _blogDbContext;
        // Constructor DI for BlogDbContext instance to be used in the controller as a private field _blogDbContext
        // (DI: Dependency Injection) (Constructor Injection) 
        // Constructor DI done as i cannot create an instance of BlogDbContext directly in the controller
        public AdminTagsController(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }


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
            //var name = addTagRequest.Name;
            //var displayName = addTagRequest.DisplayName;

            _blogDbContext.Tags.Add(new Tag
            {
                // Mapping the properties of the AddTagRequest instance to the Tag instance
                Name = addTagRequest.Name,
                PageTitle = addTagRequest.DisplayName
            });

            _blogDbContext.SaveChanges();
            // SaveChanges() persists the changes to the database

            return View("Add");
        }

    }
}
