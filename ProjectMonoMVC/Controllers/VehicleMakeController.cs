using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectMonoMVC.ViewModels;
using ProjectMonoService.Strings;
using ProjectMonoService.PaginatedList;
using Microsoft.EntityFrameworkCore;
using ProjectMonoService.Models;
using ProjectMonoService.VehicleInterface;
using ProjectMonoService.SortFilter;
using ProjectMonoService.ModelsInterface;

namespace ProjectMonoMVC.Controllers
{
   
    public class VehicleMakeController : Controller
    {
        private readonly IVehicleMakeService service;
        private readonly IMapper mapper;
      
    
        public VehicleMakeController(IVehicleMakeService _service, IMapper _mapper)
        {
            service = _service;
            mapper = _mapper;
           
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            
            ViewData["CurrentSort"] = sortOrder;
            ViewData["AbrvSort"] = sortOrder == Strings.AbrvAsc ? Strings.AbrvDesc : Strings.AbrvAsc;
            ViewData["NameSort"] = sortOrder == Strings.NameDesc ? Strings.NameAsc : Strings.NameDesc;
            ViewData["CurrentFilter"] = searchString;

            if (searchString != null) { pageNumber = 1; }
            else { searchString = currentFilter; }

            ViewData["CurrentFilter"] = searchString;
            Searching searching = new Searching();
            Sorting sorting = new Sorting();
            PaginatedList<IVehicleMake> paging = new PaginatedList<IVehicleMake>();
           
            searching.SearchingString = searchString;
            sorting.SortOrder = sortOrder;
            paging.PageNumber = pageNumber ??1;

            List<IVehicleMake> vehicles = await service.GetAllMakes(searching, sorting, paging);
            List<VehicleMakeView> items = mapper.Map<List<VehicleMakeView>>(vehicles);
            PaginatedList<VehicleMakeView> getPaginatedList = new PaginatedList<VehicleMakeView>(items, paging.PageCount, paging.PageNumber, Strings.PageSize);
            return View(getPaginatedList);

        }

       public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
        [Bind("Name,Abrv")] VehicleMakeView vehicle)
        {
          
            if (ModelState.IsValid)
                {
                  var create = mapper.Map<IVehicleMake>(vehicle);
                  await   service.InsertMake(create); 
                  return RedirectToAction("Index");
                }
           
            return View(vehicle);

        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdMake(id);
            if (vehicle == null) { return NotFound(); }
            VehicleMakeView getVehicle = mapper.Map<VehicleMakeView>(vehicle);

            return View(getVehicle);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid? id)
        {

            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdMake(id);
            if (vehicle == null) { return NotFound(); }
           
            VehicleMakeView getVehicle = mapper.Map<VehicleMakeView>(vehicle);
            return View(getVehicle);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSave(
            [Bind("Id,Name,Abrv")] VehicleMakeView vehicle)
        {
           
            if (ModelState.IsValid)
                {
                var update = mapper.Map<IVehicleMake>(vehicle);
                await  service.UpdateMake(update);
                  return RedirectToAction("Index");
                }
           
            return View(vehicle);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid? id, bool? saveChangesError = false)
        {
            if (id == null) { return BadRequest(); }
            var vehicle = await service.GetIdMake(id);
            if (vehicle == null) { return NotFound(); }
            VehicleMakeView getVehicle = mapper.Map<VehicleMakeView>(vehicle);

            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] = Strings.DeleteError;
            }
            return View(getVehicle);
          
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid? id)
        {
            if (id == null) { return BadRequest(); }
            try
            { 
                await service.DeleteMake(id);
               
                return RedirectToAction("Index");
            }

            catch(DbUpdateException)
            {
               
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
            }


        }
    }
}