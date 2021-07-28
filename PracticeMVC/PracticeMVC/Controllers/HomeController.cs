using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticeMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository;


        //
        public HomeController(ILogger<HomeController> logger, IStudentRepository studentRepository) //Constructor injection
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }        
       
        
        public IActionResult Index() //Action ko name ra view ko name same huna parxa
        {
            var model = _studentRepository.GetAllStudents();
            return View(model);
        }


        [HttpGet]        

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            return View();
        }

        [HttpGet]

        public IActionResult Edit()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
