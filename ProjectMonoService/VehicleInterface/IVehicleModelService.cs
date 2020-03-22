using ProjectMonoService.Models;
using ProjectMonoService.ModelsInterface;
using ProjectMonoService.PaginatedList;
using ProjectMonoService.SortFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonoService.VehicleInterface
{
 public interface IVehicleModelService
    {
        Task<List<IVehicleModel>> GetAllModels(Searching searching, Sorting sorting, PaginatedList<IVehicleModel> paging);
        Task InsertModel(IVehicleModel vehicleModel);
        Task UpdateModel(IVehicleModel vehicleModel);
        Task DeleteModel(Guid? id);
        Task<IVehicleModel> GetIdModel(Guid? id);
    }
}
