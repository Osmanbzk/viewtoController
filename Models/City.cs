using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewToController.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

        public static List<City> GetFakeCities()
        {
            return new List<City>()
            {
                new City{ CityId =11, CityName= "Leicester", CountryId=0 },
                new City{ CityId =12, CityName= "Sundarlan", CountryId=0 },
                new City{ CityId =13, CityName= "Bath", CountryId=1 },
                new City{ CityId =14, CityName= "Leeds", CountryId=1 },
                new City{ CityId =15, CityName= "Dallas", CountryId=2 },
                new City{ CityId =16, CityName= "Lancestar", CountryId=2 },
                new City{ CityId =17, CityName= "Tampa", CountryId=2 },
                new City{ CityId =18, CityName= "Chirstrchurch", CountryId=2 },
                new City{ CityId =19, CityName= "Laredo", CountryId=3 },
                new City{ CityId =20, CityName= "Indeanapolis", CountryId=3 },
            };
        }
    }
}