using Microsoft.AspNetCore.Mvc.Rendering;

namespace Systemtest_saince.Services
{
    public class APiCallRepo
    {
        public List<SelectListItem> GetCityLis()
        {
            List<SelectListItem> cityList= new List<SelectListItem>();

            cityList.Add(new SelectListItem { Text="Hyderabad",Value="1"});
            cityList.Add(new SelectListItem { Text = "Chennai", Value = "2" });
            cityList.Add(new SelectListItem { Text="mumbai",Value = "3"});
            return cityList;
        }

    }
}
