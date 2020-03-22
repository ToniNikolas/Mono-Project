using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectMonoService.Models;
using ProjectMonoService.ModelsInterface;
using ProjectMonoService.PaginatedList;
using ProjectMonoService.SortFilter;
using ProjectMonoService.VehicleInterface;

namespace ProjectMonoService.VehicleService
{
    public class VehicleMakeService : IVehicleMakeService
    {
        private readonly VehicleDbContext context;
        private readonly IMapper mapper;

        public VehicleMakeService(VehicleDbContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

      
     
        //public IQueryable<VehicleMake> GetAllMakes(Searching searching,Sorting sorting,Paging paging)
            public async Task<List<IVehicleMake>> GetAllMakes(Searching searching, Sorting sorting, PaginatedList<IVehicleMake> paging)

        {
            
            IQueryable<IVehicleMake> vehicles;
            paging.PageCount = context.VehicleMakes.AsQueryable().Count();
            if (!String.IsNullOrWhiteSpace(searching.SearchingString))
            {
                switch (sorting.SortOrder)
                {
                    case Strings.Strings.AbrvAsc:
                        vehicles =      context.VehicleMakes.Where(s => s.Name.Contains(searching.SearchingString)
                                        || s.Abrv.Contains(searching.SearchingString)).OrderBy(s => s.Abrv)
                                        .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();

                        break;
                    case Strings.Strings.AbrvDesc:
                        vehicles = context.VehicleMakes.Where(s => s.Name.Contains(searching.SearchingString)
                                        || s.Abrv.Contains(searching.SearchingString)).OrderByDescending(s => s.Abrv)
                                        .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameAsc:
                        vehicles = context.VehicleMakes.Where(s => s.Name.Contains(searching.SearchingString)
                                        || s.Abrv.Contains(searching.SearchingString)).OrderBy(s => s.Name)
                                        .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.NameDesc:
                        vehicles = context.VehicleMakes.Where(s => s.Name.Contains(searching.SearchingString)
                                        || s.Abrv.Contains(searching.SearchingString)).OrderByDescending(s => s.Name)
                                        .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    default:
                        vehicles = context.VehicleMakes.Where(s => s.Name.Contains(searching.SearchingString)
                                        || s.Abrv.Contains(searching.SearchingString)).OrderBy(s => s.Name)
                                        .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                                                        
                        break;
                }

               
            }

            else
            {
                switch (sorting.SortOrder)
                {
                    case Strings.Strings.AbrvAsc:
                        vehicles = context.VehicleMakes.OrderBy(s => s.Abrv)
                            .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                    case Strings.Strings.AbrvDesc:
                        vehicles = context.VehicleMakes.OrderByDescending(s => s.Abrv)
                            .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking(); 
                        break;
                    case Strings.Strings.NameAsc:
                        vehicles = context.VehicleMakes.OrderBy(s => s.Name)
                            .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking(); 
                        break;
                    case Strings.Strings.NameDesc:
                        vehicles = context.VehicleMakes.OrderByDescending(s => s.Name)
                            .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking(); 
                        break;
                    default:
                        vehicles = context.VehicleMakes.OrderBy(s => s.Name)
                            .Skip((paging.PageNumber - 1) * Strings.Strings.PageSize).Take(Strings.Strings.PageSize).AsNoTracking();
                        break;
                }

               
            }
            return await vehicles.ToListAsync();
        }

        
        public async Task InsertMake(IVehicleMake vehicle)
        {
            VehicleMake create = mapper.Map<VehicleMake>(vehicle);
            context.VehicleMakes.Add(create);
            await context.SaveChangesAsync();
        }

        public async Task UpdateMake(IVehicleMake vehicle)
        {
            VehicleMake update = mapper.Map<VehicleMake>(vehicle);
            context.VehicleMakes.Update(update);
            await context.SaveChangesAsync();
        }

        public async Task DeleteMake(Guid? id)
        {
            VehicleMake vehicle = await context.VehicleMakes.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            context.VehicleMakes.Remove(vehicle);
            await context.SaveChangesAsync();
        }

        public async Task<IVehicleMake> GetIdMake(Guid? id)
        {
            VehicleMake vehicle = await context.VehicleMakes.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            var getVehicle = mapper.Map<IVehicleMake>(vehicle);
            return getVehicle;
        }

        public List<IVehicleMake> GetMakeList()
        {
            return mapper.Map<List<IVehicleMake>>(context.VehicleMakes.ToList());
        }

      




        /*Vehicle Model*/


    }
}
