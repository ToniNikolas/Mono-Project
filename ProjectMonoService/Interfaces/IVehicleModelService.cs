using ProjectMonoService.Models;
using ProjectMonoService.Functionalities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMonoService.Interfaces
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
