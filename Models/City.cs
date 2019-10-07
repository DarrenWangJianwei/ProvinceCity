using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProvinceCity.Models{
    public class City {
        [Key]
        public int CityId { get; set; }
        [Display (Name="City")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display (Name="Province")]
        #nullable enable
        public string? ProvinceName { get;set;}
    }
}