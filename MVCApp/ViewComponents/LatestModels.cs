using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;
using System.Collections.Generic;

namespace MVCApp.ViewComponents
{
    public class LatestModels : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var latestList = new List<Computer>
            {
                new Computer{
                    CompID = 4,
                    CompName ="Casper Nirvana",
                    CompRAMName ="Kingston HyperX",
                    CompRAMSize=8,
                    CompGPUName="Nvidia GeForce GTX1050",
                    CompGPUSize=6
                }
            };

            return View(latestList);
        }
    }
}
