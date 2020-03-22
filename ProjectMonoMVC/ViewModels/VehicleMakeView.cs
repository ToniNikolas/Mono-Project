using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectMonoMVC.ViewModels
{
  
    public class VehicleMakeView
    {
        [Required,Key]
        public Guid Id { get; set; }
        [Required, StringLength(25)]
        public string Name { get; set; }
        [Required, StringLength(5)]
        public string Abrv { get; set; }
        
    }
}
