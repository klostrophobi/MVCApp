using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;

namespace MVCApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var compList = new List<Computer>
            {
                new Computer() {
                    CompID = 1,
                    CompName ="Monster Abra A5",
                    CompRAMName ="Kingston HyperX",
                    CompRAMSize=8,
                    CompGPUName="Nvidia GeForce GTX1050",
                    CompGPUSize=6
                },
                new Computer() {
                    CompID = 2,
                    CompName ="Monster Abra A7",
                    CompRAMName ="Kingston HyperX",
                    CompRAMSize=16,
                    CompGPUName="Nvidia GeForce GTX1070",
                    CompGPUSize=6
                },
                new Computer() {
                    CompID = 3,
                    CompName ="Monster Tulpar T7",
                    CompRAMName ="Kingston HyperX",
                    CompRAMSize=32,
                    CompGPUName="Nvidia GeForce GTX2070",
                    CompGPUSize=8
                }
            };

            return View(compList);
        }

        [HttpGet]
        public IActionResult About()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
