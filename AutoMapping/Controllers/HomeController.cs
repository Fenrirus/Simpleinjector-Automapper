using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AutoMapping.Models;
using AutoMapper;

namespace AutoMapping.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var cust = new List<Customer>();
            cust.Add(new Customer { LastName = "Redford", FirstName = "Robert", Id = 1 });
            cust.Add(new Customer { LastName = "Presley", FirstName = "Elvis", Id = 2 });

            var mappedCust = _mapper.Map<List<CustomerModel>>(cust);
            return View(mappedCust);
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