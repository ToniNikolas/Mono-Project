using ProjectMonoService.Models;
using ProjectMonoService.VehicleInterface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ProjectMonoService.SortFilter;
using ProjectMonoService.PaginatedList;
using ProjectMonoService.ModelsInterface;
using AutoMapper;

namespace ProjectMonoService.VehicleService
{
 public  class VehicleModelService : IVehicleModelService
    {
        private readonly VehicleDbContext context;
        private readonly IMapper mapper;

        public VehicleModelService(VehicleDbContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }
        public async Task<List<IVehicleModel>> GetAllModels(Searching searching, Sorting sorting, PaginatedList<IVehicleModel> paging)
        {
            
            IQueryable<IVehicleModel> vehicles;
            paging.PageCount = context.VehicleModels.AsQueryable().Count();

            if (!String.IsNullOrWhiteSpace(searching.SearchingString))
            {
                switch (sorting.SortOrder)
                {
                    case Strings.Strings.AbrvAsc:
                        vehicles= context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderBy(s => s.Abrv)
                                 .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.AbrvDesc:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderByDescending(s => s.Abrv)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameAsc:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderBy(s => s.VehicleMake.Name)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameDesc:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderByDescending(s => s.VehicleMake.Name)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.ModelAsc:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderBy(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize);
                        break;
                    case Strings.Strings.ModelDesc:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderByDescending(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    default:
                        vehicles = context.VehicleModels.Where(s => s.VehicleMake.Name.Contains(searching.SearchingString)).OrderBy(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                }
               
            }

            else
            {
                switch (sorting.SortOrder)
                {
                    case Strings.Strings.AbrvAsc:
                        vehicles = context.VehicleModels.OrderBy(s => s.Abrv)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.AbrvDesc:
                        vehicles = context.VehicleModels.OrderByDescending(s => s.Abrv)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameAsc:
                        vehicles = context.VehicleModels.OrderBy(s => s.VehicleMake.Name)
                             .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameDesc:
                        vehicles = context.VehicleModels.OrderByDescending(s => s.VehicleMake.Name)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.ModelAsc:
                        vehicles = context.VehicleModels.OrderBy(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.ModelDesc:
                        vehicles = context.VehicleModels.OrderByDescending(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    default:
                        vehicles = context.VehicleModels.OrderBy(s => s.ModelName)
                                  .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                }
               
            }
            return await vehicles.Include(p => p.VehicleMake).ToListAsync();
        }

   
        public async Task InsertModel(IVehicleModel vehicle)
        {
            VehicleModel create = mapper.Map<VehicleModel>(vehicle);
            context.VehicleModels.Add(create);
            await context.SaveChangesAsync();
        }

        public async Task UpdateModel(IVehicleModel vehicle)
        {
            VehicleModel update = mapper.Map<VehicleModel>(vehicle);
            context.VehicleModels.Update(update);
            await context.SaveChangesAsync();
        }

        public async Task DeleteModel(Guid? id)
        {
            VehicleModel vehicle = await context.VehicleModels.Include(p => p.VehicleMake).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            context.VehicleModels.Remove(vehicle);
            await context.SaveChangesAsync();

        }

        public async Task<IVehicleModel> GetIdModel(Guid? id)
        {
            VehicleModel vehicle = await context.VehicleModels.Include(p => p.VehicleMake).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            var getVehicle = mapper.Map<IVehicleModel>(vehicle);
            return getVehicle;
        }

      

       
    }
}
