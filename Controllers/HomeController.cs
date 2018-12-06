using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewToController.Models;
using ViewToController.ViewModel;

namespace ViewToController.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home 
        public ActionResult Homepage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Homepage(string text1, bool check1)
        {
            var t1 = Request.Form["text1"];
            var c1 = Request.Form.GetValues("check1")[0];

            return View();
        }

        public ActionResult homepage2()
        {
            //SelectList selectListCity = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            //SelectList selectListCountry = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName");

            //ViewBag.CitiesData = selectListCity;
            //ViewBag.CountriesData = selectListCountry;

            indexViewModel indexViewModel = new indexViewModel()
            {
                CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName"),
                CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName"),
                SelectedCityId = -1,
                SelectedCountryId = -1
            };

            return View(indexViewModel);
        }
        [HttpPost]
        public ActionResult homepage2(indexViewModel indexViewModel)
        {
            //ViewBag.SelectedCityId = SelectedCityId;
            //ViewBag.SelectedCountryId = SelectedCountryId;

            //ViewBag.CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            //ViewBag.CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName");
             

            indexViewModel.CitiesData = new SelectList(City.GetFakeCities(), "CityId", "CityName");
            indexViewModel.CountriesData = new SelectList(Country.GetFakeCountries(), "CountryId", "CountryName");

            return View(indexViewModel);
        }

        public JsonResult GetCitiesByCountry(int id)
        {
            int countryId = id;
            List<City> result = City.GetFakeCities().Where(x => x.CountryId == countryId).ToList();

            return Json(result, JsonRequestBehavior.AllowGet);
        }

    }
}