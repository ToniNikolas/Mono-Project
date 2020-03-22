using ProjectMonoService.Models;
using ProjectMonoService.ModelsInterface;
using ProjectMonoService.PaginatedList;
using ProjectMonoService.SortFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectMonoService.VehicleInterface
{
    public interface IVehicleMakeService
    {
        /* Vehicle Make*/
       
        Task<List<IVehicleMake>>GetAllMakes(Searching searchString,Sorting sorting, PaginatedList<IVehicleMake> paging);
        Task InsertMake(IVehicleMake vehicleMake);
        Task UpdateMake(IVehicleMake vehicleMake);
        Task DeleteMake(Guid? id);
        Task<IVehicleMake> GetIdMake(Guid? id);
        List<IVehicleMake> GetMakeList();

    }
}
