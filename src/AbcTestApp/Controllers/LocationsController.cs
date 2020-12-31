using AbcTestApp.Application.Interfaces;
using AbcTestApp.SharedModel.Locations;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbcTestApp.Web.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ILocationService _service;

        public LocationsController(ILocationService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index() => View(_service.GetLocationList());

        [HttpGet]
        public IActionResult Details(int id) => View(_service.FillEditModel(id));

        [HttpGet]
        public IActionResult Create() => View(_service.FillModel());

        [HttpPost]
        public IActionResult Create(NewLocationModel model)
        {
            if (!ModelState.IsValid)
            {
                var loc = _service.FillModel();
                model.Cities = loc.Cities;
                return View(model);
            }

            var location = _service.Save(model);

            if (location == null)
            {
                ViewData["ErrorOnAdding"] = "Something went wrong, please try later!";
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(_service.FillEditModel(id));

        [HttpPost]
        public IActionResult Edit(EditLocationModel model)
        {
            if (!ModelState.IsValid)
            {
                var loc = _service.FillModel();
                model.Cities = loc.Cities;
                return View(model);
            }

            _service.Edit(model);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            //some check to add here
            _service.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
