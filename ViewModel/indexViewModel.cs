using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewToController.Models;

namespace ViewToController.ViewModel
{
    public class indexViewModel
    {
        public SelectList CitiesData { get; set; }
        public SelectList CountriesData { get; set; }
            
        public int SelectedCityId { get; set; }
        public int SelectedCountryId { get; set; }
    }
}