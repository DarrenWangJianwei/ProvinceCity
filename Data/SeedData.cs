using System.Collections.Generic;
using ProvinceCity.Models;
using Microsoft.EntityFrameworkCore;
public static class SeedData {
    // this is an extension method to the ModelBuilder class
    public static void Seed(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Province>().HasData(
            GetProvince()
        );
        modelBuilder.Entity<City>().HasData(
            GetCity()
        );
    }
    public static List<Province> GetProvince() {
        List<Province> province = new List<Province>() {
            new Province() {    // 1
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {    // 2
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {    // 3
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
        };

        return province;
    }

    public static List<City> GetCity() {
        List<City> city = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
            },
            new City {
                CityId = 2,
                CityName = "Burnaby",
                Population = 249197,
            },
            new City {
                CityId = 3,
                CityName = "Edmonton",
                Population = 930000,
            },
        };

        return city;
    }
}
