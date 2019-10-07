using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ProvinceCity.Models{
public class Province {
    [Key]
    [Display (Name="Province Postal Abbreviations")]
    public string ProvinceCode { get; set; }
    [Display (Name="Province")]
    public string ProvinceName { get; set; }
    public List<City> Cities { get; set; }
    }
}