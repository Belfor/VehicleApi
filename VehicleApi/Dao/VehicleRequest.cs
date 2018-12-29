using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VehicleApi.Dao
{
    public class VehicleRequest
    {
        [Key]
        public int VehicleId { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string ManufacturerNameShort { get; set; }
        [Range(0.0, Double.MaxValue)]
        public decimal Price { get; set; }
    }
}
