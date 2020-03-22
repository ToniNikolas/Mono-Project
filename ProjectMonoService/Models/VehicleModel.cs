using ProjectMonoService.ModelsInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMonoService.Models
{
   
    public class VehicleModel : IVehicleModel
    {
        [Key]
        public Guid Id { get; set; }
        public Guid MakeId{ get; set; }
        [Required]
        public string ModelName { get; set; }
        [Required]
        public string Abrv { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }

    }
}
