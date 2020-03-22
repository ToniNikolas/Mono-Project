using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectMonoService.PaginatedList;
using ProjectMonoService.Strings;
using ProjectMonoMVC.ViewModels;
using ProjectMonoService.Models;
using ProjectMonoService.VehicleInterface;
using ProjectMonoService.SortFilter;
using Microsoft.EntityFrameworkCore;
using ProjectMonoService.ModelsInterface;

namespace ProjectMonoMVC.Controllers
{
    public class VehicleModelController : Controller
    {
       
        private readonly IVehicleModelService service;
        private readonly IVehicleMakeService makeService;
        private readonly IMapper mapper;

        public VehicleModelController(IVehicleModelService _service,IVehicleMakeService _makeService, IMapper _mapper)
        {
            service = _service;
           makeService = _makeService;
            mapper = _mapper;

        }


        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {

            ViewData["CurrentSort"] = sortOrder;
            ViewData["AbrvSort"] = sortOrder == Strings.AbrvAsc ? Strings.AbrvDesc : Strings.AbrvAsc;
            ViewData["NameSort"] = sortOrder == Strings.NameDesc ? Strings.NameAsc : Strings.NameDesc;
            ViewData["ModelSort"] = sortOrder == Strings.ModelAsc ? Strings.ModelDesc : Strings.ModelAsc;
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null) { pageNumber = 1; }
            else { searchString = currentFilter; }

            ViewData["CurrentFilter"] = searchString;

            Searching searching = new Searching();
            Sorting sorting = new Sorting();
            PaginatedList<IVehicleModel> paging = new PaginatedList<IVehicleModel>();

            searching.SearchingString = searchString;
            sorting.SortOrder = sortOrder;
            paging.PageNumber = pageNumber ?? 1;

            List<IVehicleModel> vehicles = await service.GetAllModels(searching, sorting, paging);
            List<VehicleModelView> items = mapper.Map<List<VehicleModelView>>(vehicles);
            PaginatedList<VehicleModelView> getPaginatedList = new PaginatedList<VehicleModelView>(items, paging.PageCount, paging.PageNumber, Strings.PageSize);
            return View(getPaginatedList);


        }

        public ActionResult Create()
        {
            ViewBag.MakeId = makeService.GetMakeList();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("MakeId,ModelName,Abrv")] VehicleModelView vehicle)
        {

            if (ModelState.IsValid)
            {
                var create = mapper.Map<IVehicleModel>(vehicle);
                await service.InsertModel(create);
                return RedirectToAction("Index");
            }
            ViewBag.MakeId = makeService.GetMakeList();
            return View(vehicle);

        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdModel(id);
            if (vehicle == null) { return NotFound(); }
            VehicleModelView getVehicle = mapper.Map<VehicleModelView>(vehicle);

            return View(getVehicle);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {
            ViewBag.MakeId = makeService.GetMakeList();
            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdModel(id);
            if (vehicle == null) { return NotFound(); }
            VehicleModelView getVehicle = mapper.Map<VehicleModelView>(vehicle);
            return View(getVehicle);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSave(
            [Bind("Id,MakeId,ModelName,Abrv")] VehicleModelView vehicle)
        {
          
            if (ModelState.IsValid)
            {
                var update = mapper.Map<IVehicleModel>(vehicle);
                await service.UpdateModel(update);
                return RedirectToAction("Index");
            }
            ViewBag.MakeId = makeService.GetMakeList();
          
            return View(vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdModel(id);
            if (vehicle == null) { return NotFound(); }
            VehicleModelView getVehicle = mapper.Map<VehicleModelView>(vehicle);

            return View(getVehicle);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null) { return BadRequest(); }

            await service.DeleteModel(id);
            return RedirectToAction("Index");

        }



    }
}