using InfocusCase.Business.Abstract;
using InfocusCase.Entity.Concrete;
using InfocusCase.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InfocusCase.UI.Controllers
{
    public class HomeController : Controller
    {
        private IPersonService _personService;
        private ITaskService _taskService;
        private IPersonAddressService _personAddressService;
        private ICityService _cityService;
        private IDistrictService _districtService;
        public HomeController(
            IPersonService personService,
            ITaskService taskService,
            IPersonAddressService personAddressService,
            ICityService cityService,
            IDistrictService districtService)
        {
            _personService = personService;
            _taskService = taskService;
            _personAddressService = personAddressService;
            _cityService = cityService;
            _districtService = districtService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_personService.GetAll());
        }

        [HttpPost]
        public IActionResult Index(Person person)
        {
            if(person == null)
            {
                return View(_personService.GetAll());
            }
            //TempData["personalId"] = person
            _personService.Add(person);
            return View(_personService.GetAll());
        }

        [HttpGet]
        public IActionResult TaskPage()
        {
            return View(_taskService.GetAll());
        }

        [HttpPost]
        public IActionResult TaskPage(InfocusCase.Entity.Concrete.Task task)
        {
            _taskService.Add(task);
            return View(_taskService.GetAll());
        }

        [HttpGet]
        public IActionResult AddressPage(int id)
        {
            LocationModel locationModel = new LocationModel();
            locationModel.Cities = new SelectList(_cityService.GetAll(), "Id", "CityName");
            locationModel.Districts = new SelectList(new List<District>(), "Id", "DistrictName");
            ViewData["personId"] = id;
            var targetList = _personAddressService.GetAll();
                //.Select(x => new AddressModel()
                //{
                //    CityName = _cityService.GetById(x.City.Id).CityName
                //}).ToList();
            
            //locationModel.AddressModels = _personAddressService.GetAll().
            //    Select(x => new AddressModel()
            //    {
            //        Address = x.Address,
            //        Name = x.Name,
            //        AddressType = x.AddressType,
            //        CityName = x.City.CityName,
            //        DistrictName = x.District.DistrictName
            //    }).ToList();
            return View(locationModel);
        }

        public JsonResult GetDistrictsByCity(int cityId)
        {
            return Json(_districtService.GetAll(cityId));
        }

        [HttpPost]
        public IActionResult AddressPage(AddressModel addressModel)
        {
            _personAddressService.Add(new PersonAddress
            {
                Address = addressModel.Address,
                Name = addressModel.Name,
                AddressType = addressModel.AddressType,
                City = _cityService.GetById(addressModel.CitiesDrop),
                District = _districtService.GetById(addressModel.DistrictsDrop),
                Person = _personService.GetById(addressModel.PersonalId)
            });
            List<PersonAddress> personAddresses = _personAddressService.GetAll();
            List<City> cities = _cityService.GetAll();
            return RedirectToAction("AddressPage","Home");
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
