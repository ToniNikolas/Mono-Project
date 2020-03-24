using ProjectMonoService.Models;
using ProjectMonoService.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectMonoService.Interfaces
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
