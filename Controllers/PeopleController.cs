using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ExerciseCSharp.Models.Services.Application;
using ExerciseCSharp.Models.ViewModels;


// using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ExerciseCSharp.Controllers
{
    public class PeopleController : Controller
    {


        public IActionResult Index()
        {
            var peopleService = new PeopleService();
            List<PeopleViewModel> people = peopleService.GetPeople();
            return View(people);
        }

      
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}