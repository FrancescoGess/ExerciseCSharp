using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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
            List<Person> people = peopleService.GetPeople();
            return View();
        }

      
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}