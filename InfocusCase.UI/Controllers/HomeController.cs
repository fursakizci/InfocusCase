using InfocusCase.Business.Abstract;
using InfocusCase.Business.Constants;
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
        private IPersonTaskService _personTaskService;

        public HomeController(
            IPersonService personService,
            ITaskService taskService,
            IPersonAddressService personAddressService,
            ICityService cityService,
            IDistrictService districtService,
            IPersonTaskService personTaskService)
        {
            _personService = personService;
            _taskService = taskService;
            _personAddressService = personAddressService;
            _cityService = cityService;
            _districtService = districtService;
            _personTaskService = personTaskService;
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
            
            _personService.Add(person);
            return View(_personService.GetAll());
        }

        public IActionResult TaskListByPerson(int personId)
        {
            
            return View();
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
            locationModel.Person = _personService.GetAddress(id);
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
            
            List<City> cities = _cityService.GetAll();
            return RedirectToAction("AddressPage","Home");
        }

        [HttpGet]
        public IActionResult AssignTask(int id)
        {
            TaskModel taskModel =new TaskModel();
            taskModel.People = _personService.GetAll();
            
            taskModel.Status = new SelectList(StatusMessages.Status);
            taskModel.Task = _taskService.CheckExist(id);
            taskModel.Task.Deadline.ToString("dd/MM/yyyy");
            return View(taskModel);
        }

        public JsonResult AssignTaskToPerson(int taskId,int personId)
        {
           
            if (_personService.CheckTaskListForPerson(personId, taskId))
            {
                _personTaskService.Delete(_personTaskService.GetPersonTaskById(personId, taskId));
            }

            else 
            { 
                PersonTask personTask = new PersonTask
                {
                    Person = _personService.GetById(personId),
                    Task = _taskService.GetById(taskId) 
                };

            _personTaskService.Add(personTask);

            }

            return Json(personId);
        }

        [HttpPost]
        public IActionResult AssignTask(InfocusCase.Entity.Concrete.Task task)
        {
            TaskModel taskModel = new TaskModel();
            _taskService.Update(task);
            return RedirectToAction("TaskPage","home");
        }

        public IActionResult ShowPersonTaskList(int id)
        {
            return View(_personService.PersonTaskList(id));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
