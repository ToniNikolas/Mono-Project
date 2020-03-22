using ProjectMonoService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProjectMonoMVC.ViewModels
{
   public class VehicleModelView
    {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public Guid MakeId { get; set; }
        [Required, StringLength(25)]
        public string ModelName { get; set; }
        [Required, StringLength(5)]
        public string Abrv { get; set; }
        public virtual VehicleMake VehicleMake { get; set; }
    }
}
